using System.Globalization;
using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Forms;
using EngineeringManagement.UI.Forms.Certifications;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.UI
{
    public partial class MainForm : Form
    {
        public bool ShouldRefreshAllEmployees { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Setup();
        }

        private void Setup()
        {
            LoadGrids();
            FormatColumnHeaders(dgvExpiringCertEmp);
            FormatColumnHeaders(dgvAllEmployees);
            dgvAllEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabPage1.Text = $"Proximos a expirar entre {DateTime.Now.AddDays(-10).ToString("dd/MM/yyyy", new CultureInfo("es-MX"))} y {DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("es-MX"))}";
        }

        private void LoadGrids()
        {
            dgvAllEmployees.DataSource = null;
            dgvExpiringCertEmp.DataSource = null;
            var tenDaysAgo = DateTime.Now.AddDays(-10);
            using (var context = new Data.AppContext())
            {
                var allEmployees = context.EmployeeCertifications
                                .Include(r => r.Employee)
                                .Include(r => r.Certification)
                                .OrderByDescending(r => r.EmployeeId)
                                .Select(r => new
                                {
                                    EmployeeCertId = r.Id,
                                    r.Employee.EmployeeName,
                                    r.Certification.CertificationName,
                                    StarDate = r.StartDate.Value.Date,
                                    EndDate = r.EndDate.Value.Date,
                                    StartDateStr = r.StartDate.Value.Date.ToString("dd/MM/yyyy", new CultureInfo("es-MX")),
                                    EndDateStr = r.EndDate.Value.Date.ToString("dd/MM/yyyy", new CultureInfo("es-MX")),
                                });
                var soonToExpire = allEmployees.Where(r =>
                    r.EndDate >= tenDaysAgo
                    && r.EndDate <= DateTime.Now)
                    .ToList();
                dgvExpiringCertEmp.DataSource = soonToExpire.OrderBy(r => r.EndDate).ToList();
                dgvAllEmployees.DataSource = allEmployees.ToList();
                FormatColumnHeaders(dgvAllEmployees);
                FormatColumnHeaders(dgvExpiringCertEmp);
            }
        }

        private static void FormatColumnHeaders(DataGridView gridView)
        {
            gridView.Columns[1].HeaderText = "Colaborador";
            gridView.Columns[2].HeaderText = "Certificacion";
            gridView.Columns[5].HeaderText = "Inicio";
            gridView.Columns[6].HeaderText = "Vencimiento";
            gridView.Columns[0].Visible = false;
            gridView.Columns[3].Visible = false;
            gridView.Columns[4].Visible = false;
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addEmp = new AddEmployee();
            addEmp.ShowDialog();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var editEmp = new EditEmployee();
            editEmp.ShowDialog();
        }

        private void agregarPlantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addFacility = new AddFacility();
            addFacility.ShowDialog();
        }

        private void editarPlantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var editFacility = new EditFacility();
            editFacility.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarDC3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addCertificacion = new AddCertification();
            addCertificacion.ShowDialog();
        }

        private void editarDC3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var editCertification = new EditCertification();
            editCertification.ShowDialog();
        }

        private void agregarDC3AEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addCertToEmployee = new AddEmployeeCertification2(this);
            addCertToEmployee.ShowDialog();
            ReloadGrids();
        }

        private void dgvExpiringCertEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var empCert = GetCertificationFromGrid(sender as DataGridView, e.RowIndex);
            OpenEditCertificationDialog(empCert);
        }

        private void dgvAllEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var empCert = GetCertificationFromGrid(sender as DataGridView, e.RowIndex);
            OpenEditCertificationDialog(empCert);
        }

        private void OpenEditCertificationDialog(EmployeeCertification empCert)
        {
            using var editCertification = new EditEmployeeCertification(this, empCert);
            editCertification.ShowDialog();
            ReloadGrids();
        }

        private void ReloadGrids()
        {
            if (ShouldRefreshAllEmployees)
            {
                LoadGrids();
            }
        }

        private static EmployeeCertification GetCertificationFromGrid(DataGridView dataGridView, int rowIndex)
        {
            var empCertificationId = (int)dataGridView.Rows[rowIndex].Cells[0].Value;
            using var context = new Data.AppContext();
            var empCert = context.EmployeeCertifications
                .Include(r => r.Certification)
                .Include(r => r.Employee)
                .First(r => r.Id == empCertificationId);
            return empCert;
        }
    }
}