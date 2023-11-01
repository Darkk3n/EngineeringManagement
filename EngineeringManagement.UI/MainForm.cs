using EngineeringManagement.UI.Forms.Employees;
using EngineeringManagement.UI.Forms.Facilities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EngineeringManagement.UI
{
    public partial class MainForm : Form
    {
        private readonly Data.AppContext context;

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
            FormatColumnHeaders(dgvExpiringCertEmp);
            FormatColumnHeaders(dgvAllEmployees);
            dgvAllEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblSoonToExpire.Text = $"{lblSoonToExpire.Text} {DateTime.Now.AddDays(-10).ToShortDateString()} y {DateTime.Now.ToShortDateString()}";
        }

        private static void FormatColumnHeaders(DataGridView gridView)
        {
            gridView.Columns[0].HeaderText = "Colaborador";
            gridView.Columns[1].HeaderText = "Certificacion";
            gridView.Columns[2].HeaderText = "Inicio";
            gridView.Columns[3].HeaderText = "Vencimiento";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
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
    }
}