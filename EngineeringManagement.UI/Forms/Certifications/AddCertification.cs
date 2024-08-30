using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringManagement.UI.Forms
{
   public partial class AddCertification : Form
   {
      private readonly Data.AppContext context;

      public AddCertification(Data.AppContext context)
      {
         InitializeComponent();
         Setup();
         this.context = context;
      }

      private void Setup()
      {
         LoadAllFacilities();
         lbAssignedFacilities.DisplayMember = "FacilityName";
         lbAssignedFacilities.ValueMember = "Id";
         lbAllFacilities.SelectedIndex = -1;
      }

      private void LoadAllFacilities()
      {
         var facilities = context.Facilities.ToList();
         lbAllFacilities.DataSource = facilities;
         lbAllFacilities.DisplayMember = "FacilityName";
         lbAllFacilities.ValueMember = "Id";
      }

      private void BtnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void BtnOk_Click(object sender, EventArgs e)
      {
         if (!TxtCertName.Text.HasValue())
         {
            MessageBox.Show("Nombre es un campo requerido", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }
         var certification = new Certification
         {
            CertificationName = TxtCertName.Text,
            Description = TxtCertDesc.Text,
         };

         try
         {
            context.Certifications.Add(certification);
            context.SaveChanges();
            if (lbAssignedFacilities.Items.Count > 0)
            {
               var facilityCertifications = AddFacilityCertifications(certification.Id);
               context.FacilityCertifications.AddRange(facilityCertifications);
               context.SaveChanges();
            }
         }
         catch (Exception)
         {

            throw;
         }
         finally
         {
            MessageBox.Show("Guardado con exito.", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
         }
      }

      private IEnumerable<FacilityCertification> AddFacilityCertifications(int certificationId)
      {
         var facilityCertification = new List<FacilityCertification>();
         foreach (var item in lbAssignedFacilities.Items.Cast<Facility>())
         {
            facilityCertification.Add(new FacilityCertification
            {
               CertificationId = certificationId,
               FacilityId = item.Id
            });
         }
         return facilityCertification;
      }

      private void BtnRemove_Click(object sender, EventArgs e)
      {
         if (lbAssignedFacilities.SelectedIndices.Count == 0)
         {
            MessageBox.Show("Seleccione por lo menos una planta antes de eliminar.", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }
         var allIds = lbAssignedFacilities.SelectedItems.Cast<Facility>().Select(r => r.Id).ToList();
         foreach (Facility selectedFacility in lbAssignedFacilities.SelectedItems.OfType<Facility>().ToList())
         {
            lbAssignedFacilities.Items.Remove(selectedFacility);
         }
         allIds.AddRange(lbAllFacilities.Items.Cast<Facility>().Select(r => r.Id));
         lbAllFacilities.DataSource = null;
         lbAllFacilities.DataSource = context.Facilities.Where(r => allIds.Contains(r.Id)).ToList();
         lbAllFacilities.DisplayMember = "FacilityName";
         lbAllFacilities.ValueMember = "Id";
         if (lbAssignedFacilities.Items.Count == 0)
         {
            BtnRemove.Enabled = BtnRemoveAll.Enabled = false;
         }
      }

      private void BtnAdd_Click(object sender, EventArgs e)
      {
         if (lbAllFacilities.SelectedIndices.Count == 0)
         {
            MessageBox.Show("Seleccione por lo menos una planta antes de agregar.", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }
         foreach (Facility selectedFacility in lbAllFacilities.SelectedItems)
         {
            lbAssignedFacilities.Items.Add(selectedFacility);
         }
         lbAssignedFacilities.DisplayMember = "FacilityName";
         lbAssignedFacilities.ValueMember = "Id";
         var casted = lbAssignedFacilities.Items
             .Cast<Facility>()
             .Select(r => r.Id)
             .ToList();
         lbAllFacilities.DataSource = null;
         lbAllFacilities.DataSource = context.Facilities.Where(r => !casted.Contains(r.Id)).ToList();
         lbAllFacilities.DisplayMember = "FacilityName";
         lbAllFacilities.ValueMember = "Id";
         if (lbAllFacilities.Items.Count == 0)
         {
            BtnAdd.Enabled = BtnAddAll.Enabled = false;
         }
         BtnRemove.Enabled = BtnRemoveAll.Enabled = true;
      }

      private void BtnAddAll_Click(object sender, EventArgs e)
      {
         var alreadySelectedFacilities = lbAssignedFacilities.Items.Cast<Facility>();
         var pendingToAdd = lbAllFacilities.Items.Cast<Facility>().Where(r => !alreadySelectedFacilities.Select(r => r.Id).Contains(r.Id)).ToList();
         pendingToAdd.AddRange(alreadySelectedFacilities);
         lbAllFacilities.DataSource = null;
         lbAssignedFacilities.DataSource = pendingToAdd;
         lbAssignedFacilities.DisplayMember = "FacilityName";
         lbAssignedFacilities.ValueMember = "Id";
         BtnAddAll.Enabled = BtnAdd.Enabled = false;
         BtnRemove.Enabled = BtnRemoveAll.Enabled = true;
      }

      private void BtnRemoveAll_Click(object sender, EventArgs e)
      {
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         LoadAllFacilities();
         BtnAdd.Enabled = BtnAddAll.Enabled = true;
         BtnRemove.Enabled = BtnRemoveAll.Enabled = false;
      }
   }
}