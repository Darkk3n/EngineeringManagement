using System.Data;
using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data;
using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.Employees
{
    public partial class EmployeeScopeOfContractGenerator : Form
    {
        private readonly IPdfGeneratorService pdfGeneratorService;
        private readonly IOpenFileService openFileService;
        private readonly HrDataContext context;
        private List<GeneralEmployee> Employees { get; set; } = [];
        private GeneralEmployee SelectedEmployee { get; set; }

        public EmployeeScopeOfContractGenerator(IPdfGeneratorService pdfGeneratorService, IOpenFileService openFileService, HrDataContext context)
        {
            InitializeComponent();
            this.pdfGeneratorService = pdfGeneratorService;
            this.openFileService = openFileService;
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
                    Thread.Sleep(1000);
                    openFileService.Execute($@"{pdfFilePath}\Alcance {Employees[0].EmployeeName}.pdf");
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

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
            {
                var empId = (((ComboBox)sender).SelectedItem as GeneralEmployee).Id;
                SelectedEmployee = context.GeneralEmployees.Find(empId);
                MapFields();
            }
            else
            {
                SelectedEmployee = null;
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            throw new NotImplementedException();
        }

        private void MapFields()
        {
            txtName.Text = SelectedEmployee.EmployeeName;
            cmbCivilState.SelectedIndex = cmbCivilState.FindString(SelectedEmployee.MaritalStatus);
            txtEmail.Text = SelectedEmployee.Email;
            TxtSocialSecurity.Text = SelectedEmployee.SocialSecurityNumber;
            txtCurp.Text = SelectedEmployee.Curp;
            txtAddress.Text = SelectedEmployee.Address;
            
        }
    }
}
