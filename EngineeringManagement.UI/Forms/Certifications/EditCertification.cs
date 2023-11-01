using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using System.Data;

namespace EngineeringManagement.UI.Forms.Certifications
{
    public partial class EditCertification : Form
    {
        public EditCertification()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Setup();
        }

        private void Setup()
        {
            using (var context = new Data.AppContext())
            {
                var certifications = context.Certifications.ToList();
                certifications.Add(new Certification { Id = -10000, CertificationName = "-- SELECCIONE --" });
                CmbCertifications.DataSource = certifications.OrderBy(r => r.Id).ToList();
                CmbCertifications.ValueMember = "Id";
                CmbCertifications.DisplayMember = "CertificationName";
                CmbCertifications.SelectedIndex = 0;
            }
        }

        private void CmbCertifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
            {
                LoadCertification(((ComboBox)sender).SelectedItem as Certification);
                EnableTextBoxes(true);
            }
            else
            {
                TxtCertDesc.Text = string.Empty;
                TxtCertName.Text = string.Empty;
                EnableTextBoxes(false);
            }
        }

        private void LoadCertification(Certification certification)
        {
            using (var context = new Data.AppContext())
            {
                var existingCertification = context.Certifications.Find(certification.Id);
                TxtCertName.Text = existingCertification.CertificationName;
                TxtCertDesc.Text = existingCertification.Description;
            }
        }

        private void EnableTextBoxes(bool enabled) => TxtCertName.Enabled = TxtCertDesc.Enabled = enabled;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(!TxtCertName.Text.HasValue())
            {
                MessageBox.Show("Nombre es un campo requerido", "Editar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            var certId = (int)CmbCertifications.SelectedValue;
            using (var context = new Data.AppContext())
            {
                var certification = context.Certifications.Find(certId);
                certification.CertificationName = TxtCertName.Text.Trim();
                certification.Description = TxtCertDesc.Text.Trim();
                try
                {
                context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    MessageBox.Show("Actualizado con exito", "Editar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}