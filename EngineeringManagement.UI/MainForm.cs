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
            context = new Data.AppContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var data = context.EmployeeCertifications
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
            var filteredData = data.Where(r => r.StartDate.HasValue && DateTime.Now.AddDays(-10) > r.EndDate).ToList();
            dgvExpiringCertEmp.DataSource = filteredData.OrderBy(r => r.EndDate).ToList();
            dgvAllEmployees.DataSource = data.ToList();
            FormatColumnHeaders(dgvExpiringCertEmp);
            FormatColumnHeaders(dgvAllEmployees);
        }

        private void FormatColumnHeaders(DataGridView gridView)
        {
            gridView.Columns[0].HeaderText = "Colaborador";
            gridView.Columns[1].HeaderText = "Puesto";
            gridView.Columns[2].HeaderText = "Inicio";
            gridView.Columns[3].HeaderText = "Vencimiento";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }
    }
}