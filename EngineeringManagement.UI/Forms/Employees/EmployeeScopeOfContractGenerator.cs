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
            var retry = true;
            var pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads") + @"\PdfTest";
            var logoPath = Path.Combine(AppContext.BaseDirectory, "Resources");
            while (retry)
            {

                try
                {
                    pdfGeneratorService.Generate(Employees[0], pdfFilePath, logoPath);
                    MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retry = false;
                }
                catch (IOException)
                {
                    var result = MessageBox.Show("No se puede sobrescribir el archivo porque está abierto. ¿Deseas intentar de nuevo?", "Archivo en uso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    if (result != DialogResult.Retry)
                    {
                        retry = false;
                    }
                }
            }
        }
    }
}
