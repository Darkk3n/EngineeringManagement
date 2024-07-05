using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using Microsoft.EntityFrameworkCore;

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
            if (context.Facilities.Any(r => r.FacilityName.ToLower() == TxtFacilityName.Text.ToLower()))
            {
               MessageBox.Show($"La planta {TxtFacilityName.Text} ya existe.", "Agregar Planta", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            try
            {
               context.Facilities.Add(newFacility);
               context.SaveChanges();
               MessageBox.Show("Guardado con exito.", "Agregar Planta", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }
            catch (Exception)
            {
               throw;
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