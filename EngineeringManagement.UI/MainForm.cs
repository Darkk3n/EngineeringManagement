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
            dgvEmployees.DataSource = context.EmployeeCertifications
                .Include(r => r.Employee)
                .Include(r => r.Certification)
                .Where(r => r.StartDate.HasValue && DateTime.Now.AddDays(-10) > r.EndDate)
                .Select(r => new
                {
                    r.Employee.EmployeeName,
                    r.Certification.CertificationName,
                    r.StartDate,
                    r.EndDate
                })
                .ToList();
            FormatColumnHeaders();
        }

        private void FormatColumnHeaders()
        {
            dgvEmployees.Columns[0].HeaderText = "Colaborador";
            dgvEmployees.Columns[1].HeaderText = "Puesto";
            dgvEmployees.Columns[2].HeaderText = "Inicio";
            dgvEmployees.Columns[3].HeaderText = "Vencimiento";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }
    }
}