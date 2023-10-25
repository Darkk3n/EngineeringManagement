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
            dgvEmployees.DataSource = context.Employees
                .Select(r => new { r.Position, r.EmployeeName })
                .ToList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }
    }
}