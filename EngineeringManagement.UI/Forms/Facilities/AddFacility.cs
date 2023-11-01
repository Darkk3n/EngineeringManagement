using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;

namespace EngineeringManagement.UI.Forms
{
    public partial class AddFacility : Form
    {
        public AddFacility()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var newFacility = new Facility
            {
                FacilityName = TxtFacilityName.Text
            };
            using (var context = new Data.AppContext())
            {
                try
                {
                    context.Facilities.Add(newFacility);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    MessageBox.Show("Guardado con exito.", "Agregar Planta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void TxtFacilityName_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.HasValue())
            {
                BtnOk.Enabled = true;
            }
            else
            {
                BtnOk.Enabled = false;
            }
        }
    }
}