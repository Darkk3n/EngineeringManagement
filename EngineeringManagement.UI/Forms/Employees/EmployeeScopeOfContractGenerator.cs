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
            txtName.Clear();
            cmbCivilState.SelectedIndex = 0;
            txtEmail.Clear();
            TxtNss.Clear();
            txtCurp.Clear();
            txtAddress.Clear();
            txtImssHosp.Clear();
            TxtPhone.Clear();
            txtInfonavitNumber.Clear();
            numUdQuota.Value = 1;
            txtFonacotId.Clear();
            txtCurp.Clear();
            TxtRfc.Clear();
            dtpBirthDate.Value = DateTime.Now;
            txtBirthPlace.Clear();
            txtDegree.Clear();
            txtDegreeDoc.Clear();
            txtProfession.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtBenefitiary.Clear();
            numUdPercent.Value = 1;
            TxtBenefitiaryPhone.Clear();
            dtpBenefiatiryBirthDate.Value = DateTime.Now;
            txtBenefiatiryAddress.Clear();
            txtBankAccount.Clear();
            txtBankCard.Clear();
            txtBankName.Clear();
        }

        private void MapFields()
        {
            txtName.Text = SelectedEmployee.EmployeeName;
            cmbCivilState.SelectedIndex = cmbCivilState.FindString(SelectedEmployee.MaritalStatus);
            txtEmail.Text = SelectedEmployee.Email;
            TxtNss.Text = SelectedEmployee.SocialSecurityNumber;
            txtCurp.Text = SelectedEmployee.Curp;
            txtAddress.Text = SelectedEmployee.Address;
            txtImssHosp.Text = SelectedEmployee.HospitalNumber;
            TxtPhone.Text = SelectedEmployee.PersonalCellPhone;
            txtInfonavitNumber.Text = SelectedEmployee.InfonavitNumber;
            numUdQuota.Value = decimal.Parse(SelectedEmployee.InfonavitPercent);
            txtFonacotId.Text = SelectedEmployee.FonacotClientNumber;
            txtCurp.Text = SelectedEmployee.Curp;
            TxtRfc.Text = SelectedEmployee.Rfc;
            dtpBirthDate.Value = SelectedEmployee.BirthDate.Value;
            txtBirthPlace.Text = SelectedEmployee.BirthPlace;
            txtDegree.Text = SelectedEmployee.AcademicDegree;
            txtDegreeDoc.Text = SelectedEmployee.AcademicDegreeDocument;
            txtProfession.Text = SelectedEmployee.Profession;
            txtFatherName.Text = SelectedEmployee.FatherName;
            txtMotherName.Text = SelectedEmployee.MotherName;
            txtBenefitiary.Text = SelectedEmployee.EmergencyContactName;
            numUdPercent.Value = SelectedEmployee.BenefitiaryPercent;
            TxtBenefitiaryPhone.Text = SelectedEmployee.EmergencyPhoneNumber;
            dtpBenefiatiryBirthDate.Value = SelectedEmployee.BenefitiaryBirthDate.Value;
            txtBenefiatiryAddress.Text = SelectedEmployee.BenefitiaryAddress;
            txtBankAccount.Text = SelectedEmployee.BankAccountNumber.ToString();
            txtBankCard.Text = SelectedEmployee.BankAccountCard.ToString();
            txtBankName.Text = SelectedEmployee.BankName;
        }
    }
}
