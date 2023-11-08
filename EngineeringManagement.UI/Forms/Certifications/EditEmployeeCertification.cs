using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;

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
            }
            dtpStartDate.Value = empCert.StartDate.Value;
            dtpEndDate.Value = empCert.EndDate.Value;
        }

        private void BtnCancel_Click(object sender, EventArgs e) => Close();

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}