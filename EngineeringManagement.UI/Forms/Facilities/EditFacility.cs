using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.Facilities
{
    public partial class EditFacility : Form
    {
        public EditFacility()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadFacilities();
        }

        private void LoadFacilities()
        {
            using (var context = new Data.AppContext())
            {
                var facilities = context.Facilities.ToList();
                facilities.Add(new Facility { Id = -10000, FacilityName = "-- SELECCIONE --" });
                CmbFacilities.DataSource = facilities.OrderBy(r => r.Id).ToList();
                CmbFacilities.ValueMember = "Id";
                CmbFacilities.DisplayMember = "FacilityName";
            }
        }

        private void CmbFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var casted = (ComboBox)sender;
            if (casted.SelectedIndex != 0)
            {
                var facility = casted.SelectedItem as Facility;
                TxtName.Text = facility.FacilityName;
                TxtName.Enabled = true;
                BtnOk.Enabled = true;
            }
            else
            {
                TxtName.Text = string.Empty;
                TxtName.Enabled = false;
                BtnOk.Enabled = false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var facilityId = (int)CmbFacilities.SelectedValue;
            using (var context = new Data.AppContext())
            {
                var existingFacility = context.Facilities.Find(facilityId);
                if (existingFacility == null)
                {
                    return;
                }
                existingFacility.FacilityName = TxtName.Text.Trim();
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
                    MessageBox.Show("Guardado con exito.", "Editar Empleados", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
