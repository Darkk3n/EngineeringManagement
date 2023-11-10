using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using System.Diagnostics;

namespace EngineeringManagement.UI.Forms.Certifications
{
    public partial class EditEmployeeCertification : Form
    {
        private readonly MainForm mainForm;
        private readonly EmployeeCertification empCert;

        public string FileName { get; set; }
        public string SafeFileName { get; set; }

        public EditEmployeeCertification(MainForm mainForm, EmployeeCertification empCert)
        {
            this.mainForm = mainForm;
            this.empCert = empCert;
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
                using (var context = new Data.AppContext())
                {
                    var currentCert = context.EmployeeCertifications.Find(empCert.Id);
                    currentCert.StartDate = dtpStartDate.Value;
                    currentCert.EndDate = dtpEndDate.Value;
                    if (SafeFileName.HasValue())
                    {
                        currentCert.FileName = SafeFileName;
                    }
                    context.SaveChanges();
                }
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

        private void OpenFile(string fileName)
        {
            var completeFilePath = Path.Combine(Application.StartupPath, "Documentos", empCert.Employee.EmployeeName, fileName);
            Process.Start(new ProcessStartInfo
            {
                FileName = completeFilePath,
                UseShellExecute = true
            });
        }
    }
}