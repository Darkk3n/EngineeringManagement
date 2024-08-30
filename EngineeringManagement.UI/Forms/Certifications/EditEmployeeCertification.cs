using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EngineeringManagement.UI.Forms.Certifications
{
   public partial class EditEmployeeCertification : Form
   {
      private readonly MainForm mainForm;
      private readonly EmployeeCertification empCert;
      private readonly IOpenFileService openFileService;
      private readonly Data.AppContext context;

      public string FileName { get; set; }
      public string SafeFileName { get; set; }

      public EditEmployeeCertification(EmployeeCertification empCert, MainForm mainForm, IOpenFileService openFileService, Data.AppContext context)
      {
         this.mainForm = mainForm;
         this.empCert = empCert;
         this.openFileService = openFileService;
         this.context = context;
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         LblCertName.Text = empCert.Certification.CertificationName;
         LblEmployeeName.Text = empCert.Employee.EmployeeName;
         if (empCert.FileName.HasValue())
         {
            LblFileName.Text = empCert.FileName;
            BtnViewFile.Enabled = true;
         }
         dtpStartDate.Value = empCert.StartDate.Value;
         dtpEndDate.Value = empCert.EndDate.Value;
      }

      private void BtnCancel_Click(object sender, EventArgs e) => Close();

      private void BtnOpenFile_Click(object sender, EventArgs e)
      {
         if (fileDialog.ShowDialog() == DialogResult.OK)
         {
            FileName = fileDialog.FileName;
            SafeFileName = LblFileName.Text = fileDialog.SafeFileName;
         }
      }

      private void BtnOk_Click(object sender, EventArgs e)
      {
         try
         {
            var currentCert = context.EmployeeCertifications
                .Include(r => r.Employee)
                .First(r => r.Id == empCert.Id);
            currentCert.StartDate = dtpStartDate.Value;
            currentCert.EndDate = dtpEndDate.Value;
            if (SafeFileName.HasValue())
            {
               currentCert.FileName = SafeFileName;
               HandleFile(currentCert.Employee.EmployeeName);
            }
            context.SaveChanges();
         }
         catch (Exception)
         {
            throw;
         }
         finally
         {
            MessageBox.Show("DC-3 actualizada con exito.", "Editar DC-3 a Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.ShouldRefreshAllEmployees = true;
            Close();
         }
      }

      private void HandleFile(string employeeName)
      {
         var pathToCopy = Path.Combine(Application.StartupPath, "Documentos", employeeName);
         try
         {
            File.Copy(FileName, Path.Combine(pathToCopy, SafeFileName), true);
         }
         catch (Exception)
         {
            throw;
         }
      }

      private void BtnViewFile_Click(object sender, EventArgs e)
      {
         if (FileName.HasValue())
         {
            OpenFile(FileName);
         }
         else if (empCert.FileName.HasValue())
         {
            OpenFile(empCert.FileName);
         }
      }

      private void OpenFile(string fileName) => openFileService.Execute(fileName, Application.StartupPath, empCert.Employee.EmployeeName);
   }
}