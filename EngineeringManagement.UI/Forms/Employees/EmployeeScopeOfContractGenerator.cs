using System.Data;
using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data;
using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.Employees
{
    public partial class EmployeeScopeOfContractGenerator : Form
    {
        private readonly IPdfGeneratorService pdfGeneratorService;
        private readonly HrDataContext context;
        private List<GeneralEmployee> Employees { get; set; } = [];

        public EmployeeScopeOfContractGenerator(IPdfGeneratorService pdfGeneratorService, HrDataContext context)
        {
            InitializeComponent();
            this.pdfGeneratorService = pdfGeneratorService;
            this.context = context;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            Employees.AddRange([.. context.GeneralEmployees]);
            if (Employees.Count == 0)
            {
                cmbEmployees.Items.Add("-- NO SE ENCONTRARON EMPLEADOS --");
            }
            else
            {
                cmbEmployees.Items.Clear();
                cmbEmployees.Items.AddRange([.. Employees.OrderBy(r => r.EmployeeName)]);
                cmbEmployees.ValueMember = nameof(Employee.Id);
                cmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
                cmbEmployees.Items.Insert(0, "--SELECCIONE--");
            }
            cmbEmployees.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PdfTest";
            pdfGeneratorService.Generate(Employees[0], location);
        }
    }
}
