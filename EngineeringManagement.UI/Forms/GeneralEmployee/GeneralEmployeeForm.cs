namespace EngineeringManagement.UI.Forms.GeneralEmployee
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
   }
}