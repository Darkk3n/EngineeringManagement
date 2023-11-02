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
            tabPage1.Text = $"Proximos a expirar entre {DateTime.Now.AddDays(-10).ToShortDateString()} y {DateTime.Now.ToShortDateString()}";
        }

        private void LoadGrids()
        {
            dgvAllEmployees.DataSource = null;
            dgvExpiringCertEmp.DataSource = null;
            using (var context = new Data.AppContext())
            {
                var allEmployees = context.EmployeeCertifications
                                .Include(r => r.Employee)
                                .Include(r => r.Certification)
                                .OrderByDescending(r => r.EmployeeId)
                                .Select(r => new
                                {
                                    r.Employee.EmployeeName,
                                    r.Certification.CertificationName,
                                    r.StartDate,
                                    r.EndDate
                                });
                var soonToExpire = allEmployees.Where(r => r.StartDate.HasValue
                    && DateTime.Now.AddDays(-10) < r.EndDate
                    && r.EndDate <= DateTime.Now)
                    .ToList();
                dgvExpiringCertEmp.DataSource = soonToExpire.OrderBy(r => r.EndDate).ToList();
                dgvAllEmployees.DataSource = allEmployees.ToList();
            }
        }

        private static void FormatColumnHeaders(DataGridView gridView)
        {
            gridView.Columns[0].HeaderText = "Colaborador";
            gridView.Columns[1].HeaderText = "Certificacion";
            gridView.Columns[2].HeaderText = "Inicio";
            gridView.Columns[3].HeaderText = "Vencimiento";
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
            using var addCertToEmployee = new AddEmployeeCertification(this);
            addCertToEmployee.ShowDialog();
            if (ShouldRefreshAllEmployees)
            {
                LoadGrids();
            }
        }
    }
}