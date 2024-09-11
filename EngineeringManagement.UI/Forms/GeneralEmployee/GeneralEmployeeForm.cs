using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.GeneralEmployeeForm
{
   public partial class GeneralEmployeeForm : Form
   {
      public string PictureSafeFileName { get; set; }
      public string PictureFileName { get; set; }

      public GeneralEmployeeForm()
      {
         InitializeComponent();
      }

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

      private void btnSave_Click(object sender, EventArgs e)
      {
         var employee = BuildEmployeeObject();
      }

      private GeneralEmployee BuildEmployeeObject()
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
            WorkCellPhone = txtWorkPhone.Text,
            PictureFileName = PictureSafeFileName
         };
      }
   }
}