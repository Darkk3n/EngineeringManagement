using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Extensions;
using EngineeringManagement.Core.Models;
using EngineeringManagement.Data;
using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.GeneralEmployeeForm
{
    public partial class GeneralEmployeeForm : Form
    {
        #region Properties
        private string PictureSafeFileName { get; set; }
        private string PictureFileName { get; set; }
        private GeneralEmployee SelectedEmployee { get; set; }
        private readonly HrDataContext context;
        private readonly ICopyFilesService copyFilesService;
        public event EventHandler EmployeeAdded;
        public List<GeneralEmployee> CurrentEmployees { get; set; } = [];
        #endregion

        #region Setup
        public GeneralEmployeeForm(HrDataContext context, ICopyFilesService copyFilesService)
        {
            InitializeComponent();
            this.context = context;
            this.copyFilesService = copyFilesService;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CurrentEmployees.AddRange([.. context.GeneralEmployees]);
            if (CurrentEmployees.Count > 0)
            {
                cmbEmployees.Items.Add(new { Id = 0, EmployeeName = "-- SELECCIONE --" });
                cmbEmployees.DropDownStyle = ComboBoxStyle.DropDown;
                cmbEmployees.Items.AddRange([.. CurrentEmployees.OrderBy(r => r.EmployeeName)]);
                cmbEmployees.ValueMember = nameof(GeneralEmployee.Id);
                cmbEmployees.DisplayMember = nameof(GeneralEmployee.EmployeeName);
                cmbEmployees.SelectedIndex = 0;
                cmbEmployees.AutoCompleteCustomSource.AddRange(CurrentEmployees.Select(r => r.EmployeeName).ToArray());
                cmbEmployees.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbEmployees.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbEmployees.SelectedIndex = 0;
            }
            else
            {
                cmbEmployees.Items.Add("-- NO SE ENCONTRARON EMPLEADOS --");
                cmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEmployees.SelectedIndex = 0;
                btnUpdate.Enabled = false;
            }
            cmbMaritalStatus.SelectedIndex = 0;
            cmbBloodType.SelectedIndex = 0;
        }
        #endregion

        #region Button Callbacks
        private void btnPictureUpload_Click(object sender, EventArgs e)
        {
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                PictureSafeFileName = pictureDialog.SafeFileName;
                PictureFileName = pictureDialog.FileName;
                pbEmployee.Image?.Dispose();
                pbEmployee.Image = Image.FromFile(pictureDialog.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            var employee = BuildNewEmployeeObject();
            var recordCount = 0;
            try
            {
                context.GeneralEmployees.Add(employee);
                recordCount = context.SaveChanges();
                if (recordCount > 0)
                {
                    if (PictureSafeFileName.HasValue())
                    {
                        copyFilesService.Execute(new CopyFilesServiceArgs
                        {
                            EmployeeName = employee.EmployeeName,
                            FileName = PictureFileName,
                            SafeFileName = PictureSafeFileName,
                            StartupPath = Application.StartupPath
                        });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (recordCount > 0)
                {
                    MessageBox.Show("Empleado guardado con exito.", "Agregar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EmployeeAdded?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Private Methods
        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex != 0)
            {
                SelectedEmployee = CurrentEmployees.First(r => r.EmployeeName == ((GeneralEmployee)cmbEmployees.SelectedItem).EmployeeName);
                cmbBloodType.SelectedIndex = cmbBloodType.FindString(SelectedEmployee.BloodType);
                cmbMaritalStatus.SelectedIndex = cmbMaritalStatus.FindString(SelectedEmployee.MaritalStatus);
                txtCurp.Text = SelectedEmployee.Curp;
                txtEmail.Text = SelectedEmployee.Email;
                txtEmergencyContactName.Text = SelectedEmployee.EmergencyContactName;
                txtRelationship.Text = SelectedEmployee.EmergencyContactRelationShip;
                txtEmergencyPhone.Text = SelectedEmployee.EmergencyPhoneNumber;
                txtEmpName.Text = SelectedEmployee.EmployeeName;
                txtEmpCode.Text = SelectedEmployee.EmployeeId.ToString();
                chkPictures.Checked = SelectedEmployee.Has2Pictures ?? false;
                chkRecommendationLetters.Checked = SelectedEmployee.Has2RecomendationLetters ?? false;
                chkBankStatus.Checked = SelectedEmployee.HasBankStatement ?? false;
                chkCurp.Checked = SelectedEmployee.HasCurp ?? false;
                chkDriverLicense.Checked = SelectedEmployee.HasDrivingLicense ?? false;
                chkInfonavit.Checked = SelectedEmployee.HasInfonavit ?? false;
                chkSocialSecurity.Checked = SelectedEmployee.HasNss ?? false;
                chkProofOfStudies.Checked = SelectedEmployee.HasProofOfStudies ?? false;
                chkRfc.Checked = SelectedEmployee.HasSat ?? false;
                txtRfc.Text = SelectedEmployee.Rfc;
                txtPersonalPhone.Text = SelectedEmployee.PersonalCellPhone;
                dtpStartDate.Value = DateTime.Parse(SelectedEmployee.StartDate);
                dtpRenewalDate.Value = DateTime.Parse(SelectedEmployee.RenewalDate);
                txtSocialSecutiry.Text = SelectedEmployee.SocialSecurityNumber;
                //txtWorkPhone.Text = SelectedEmployee.WorkCellPhone;
                TxtAcademicDegree.Text = SelectedEmployee.AcademicDegree;
                TxtAcademicDocument.Text = SelectedEmployee.AcademicDegreeDocument;
                TxtAddress.Text = SelectedEmployee.Address;
                TxtBankCard.Text = SelectedEmployee.BankAccountCard.ToString();
                TxtBankAcc.Text = SelectedEmployee.BankAccountNumber.ToString();
                TxtBankName.Text = SelectedEmployee.BankName;
                DtpBenefitBirthDate.Value = SelectedEmployee.BenefitiaryBirthDate.Value;
                TxtBenefitPerc.Text = SelectedEmployee.BenefitiaryPercent.ToString();
                DtpBirthDate.Value = SelectedEmployee.BirthDate.Value;
                TxtBirthPlace.Text = SelectedEmployee.BirthPlace;
                TxtFatherName.Text = SelectedEmployee.FatherName;
                TxtFonacot.Text = SelectedEmployee.FonacotClientNumber;
                TxtHouseCredit.Text = SelectedEmployee.InfonavitNumber;
                TxtHouseCreditPercent.Text = SelectedEmployee.InfonavitPercent;
                TxtHospitalNumber.Text = SelectedEmployee.HospitalNumber;
                TxtMotherName.Text = SelectedEmployee.MotherName;
                TxtProfession.Text = SelectedEmployee.Profession;
                TxtBenefitAddress.Text = SelectedEmployee.BenefitiaryAddress;
                cmbBloodType.SelectedIndex = cmbBloodType.FindString(SelectedEmployee.BloodType);
                cmbMaritalStatus.SelectedIndex = cmbMaritalStatus.FindString(SelectedEmployee.MaritalStatus);
                if (SelectedEmployee.PictureFileName.HasValue())
                {
                    pbEmployee.Image?.Dispose();
                    pbEmployee.Image = Image.FromFile(GetFilePath(SelectedEmployee));
                }
            }
        }

        private static string GetFilePath(GeneralEmployee employee) => Path.Combine(Application.StartupPath, "Documentos", employee.EmployeeName, employee.PictureFileName);

        private GeneralEmployee BuildNewEmployeeObject()
        {
            return new()
            {
                BloodType = cmbBloodType.SelectedText,
                Curp = txtCurp.Text,
                Email = txtEmail.Text,
                EmergencyContactName = txtEmergencyContactName.Text,
                EmergencyContactRelationShip = txtRelationship.Text,
                EmergencyPhoneNumber = txtEmergencyPhone.Text,
                EmployeeName = txtEmpName.Text,
                //TODO: Figure out EmployeeType 
                Has2Pictures = chkPictures.Checked,
                Has2RecomendationLetters = chkRecommendationLetters.Checked,
                HasBankStatement = chkBankStatus.Checked,
                //TODO: These fields are not shown in mock ups HasCellPhone, HasComputer, HasEquipment, HasJobReferences
                //HasProofOfAddress, EmployeeType,
                EmployeeId = int.Parse(txtEmpCode.Text),
                HasCurp = chkCurp.Checked,
                HasDrivingLicense = chkDriverLicense.Checked,
                HasInfonavit = chkInfonavit.Checked,
                HasNss = chkSocialSecurity.Checked,
                HasProofOfStudies = chkProofOfStudies.Checked,
                HasSat = chkRfc.Checked,
                MaritalStatus = cmbMaritalStatus.SelectedText,
                Rfc = txtRfc.Text,
                PersonalCellPhone = txtPersonalPhone.Text,
                StartDate = dtpStartDate.Value.ToShortDateString(),
                RenewalDate = dtpRenewalDate.Value.ToShortDateString(),
                SocialSecurityNumber = txtSocialSecutiry.Text,
                //WorkCellPhone = txtWorkPhone.Text,
                PictureFileName = PictureSafeFileName,
                AcademicDegree = TxtAcademicDegree.Text,
                AcademicDegreeDocument = TxtAcademicDocument.Text,
                Address = TxtAddress.Text,
                BankAccountCard = int.Parse(TxtBankCard.Text),
                BankAccountNumber = int.Parse(TxtBankAcc.Text),
                BankName = TxtBankName.Text,
                BenefitiaryBirthDate = DtpBenefitBirthDate.Value,
                BenefitiaryPercent = int.Parse(TxtBenefitPerc.Text),
                BirthDate = DtpBirthDate.Value,
                BirthPlace = TxtBirthPlace.Text,
                FatherName = TxtFatherName.Text,
                FonacotClientNumber = TxtFonacot.Text,
                InfonavitNumber = TxtHouseCredit.Text,
                InfonavitPercent = TxtHouseCreditPercent.Text,
                HospitalNumber = TxtHospitalNumber.Text,
                MotherName = TxtMotherName.Text,
                Profession = TxtProfession.Text,
                BenefitiaryAddress = TxtBenefitAddress.Text
            };
        }
        #endregion
    }
}