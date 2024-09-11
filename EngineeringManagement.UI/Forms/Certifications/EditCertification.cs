using EngineeringManagement.Data.Models;
using EngineeringManagement.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EngineeringManagement.UI.Forms.Certifications
{
   public partial class EditCertification : Form
   {
      private List<FacilityCertification> facilityCertifications = new();
      private readonly Data.HrDataContext context;

      public EditCertification(Data.HrDataContext context)
      {
         InitializeComponent();
         this.context = context;
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         Setup();
      }

      private void Setup()
      {
         var certifications = context.Certifications.ToList();
         certifications.Add(new Certification { Id = 10000, CertificationName = "-- SELECCIONE --" });
         CmbCertifications.DataSource = certifications.OrderByDescending(r => r.Id).ToList();
         CmbCertifications.ValueMember = "Id";
         CmbCertifications.DisplayMember = "CertificationName";
         CmbCertifications.SelectedIndex = 0;
      }

      private void CmbCertifications_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (((ComboBox)sender).SelectedIndex != 0)
         {
            LoadCertification(((ComboBox)sender).SelectedItem as Certification);
            EnableControls(true);
         }
         else
         {
            lbAllFacilities.DataSource = null;
            lbAllFacilities.Items.Clear();
            lbAssignedFacilities.DataSource = null;
            lbAssignedFacilities.Items.Clear();
            TxtCertDesc.Text = string.Empty;
            TxtCertName.Text = string.Empty;
            EnableControls(false);
         }
      }

      private void LoadCertification(Certification certification)
      {
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         lbAllFacilities.DataSource = null;
         lbAllFacilities.Items.Clear();
         var existingCertification = context.Certifications.Find(certification.Id);
         TxtCertName.Text = existingCertification.CertificationName;
         TxtCertDesc.Text = existingCertification.Description;

         facilityCertifications = context.FacilityCertifications
             .AsNoTracking()
             .Include(r => r.Facility)
             .Where(r => r.CertificationId == certification.Id)
             .ToList();
         if (facilityCertifications.Any())
         {
            lbAssignedFacilities.DataSource = facilityCertifications.Select(r => r.Facility).ToList();
            lbAssignedFacilities.ValueMember = "Id";
            lbAssignedFacilities.DisplayMember = "FacilityName";
            var remainingFacilities = context.Facilities
                .AsNoTracking()
                .Where(r => !facilityCertifications.Select(r => r.FacilityId).Contains(r.Id))
                .ToList();
            lbAllFacilities.DataSource = remainingFacilities;
            lbAllFacilities.ValueMember = "Id";
            lbAllFacilities.DisplayMember = "FacilityName";
         }
         else
         {
            LoadAllFacilities();
         }
      }

      private void EnableControls(bool enabled)
      {
         TxtCertName.Enabled = TxtCertDesc.Enabled = enabled;
         lbAllFacilities.Enabled = lbAssignedFacilities.Enabled = enabled;
         if (!enabled)
         {
            BtnAdd.Enabled = BtnAddAll.Enabled = BtnRemove.Enabled = BtnRemoveAll.Enabled = false;
         }
         if (lbAllFacilities.Items.Count > 0)
         {
            BtnAdd.Enabled = BtnAddAll.Enabled = true;
         }
         if (lbAssignedFacilities.Items.Count > 0)
         {
            BtnRemove.Enabled = BtnRemoveAll.Enabled = true;
         }
      }

      private void BtnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void LoadAllFacilities()
      {
         var facilities = context.Facilities.ToList();
         lbAllFacilities.DataSource = facilities;
         lbAllFacilities.DisplayMember = "FacilityName";
         lbAllFacilities.ValueMember = "Id";
      }

      private void BtnOk_Click(object sender, EventArgs e)
      {
         if (!TxtCertName.Text.HasValue())
         {
            MessageBox.Show("Nombre es un campo requerido", "Editar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
         }
         var certId = (int)CmbCertifications.SelectedValue;
         facilityCertifications = new();
         facilityCertifications.AddRange(lbAssignedFacilities.Items
             .Cast<Facility>()
             .Select(r => new FacilityCertification
             {
                CertificationId = certId,
                FacilityId = r.Id
             }));
         var certification = context.Certifications.Find(certId);
         certification.CertificationName = TxtCertName.Text.Trim();
         certification.Description = TxtCertDesc.Text.Trim();
         try
         {
            context.SaveChanges();
            var facilities = context.FacilityCertifications
                .AsNoTracking()
                .Where(r => r.CertificationId == certId)
                .ToList();
            context.FacilityCertifications.RemoveRange(facilities);
            context.SaveChanges();
            context.FacilityCertifications.AddRange(facilityCertifications);
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

      private void BtnRemove_Click(object sender, EventArgs e)
      {
         if (lbAssignedFacilities.SelectedIndices.Count == 0)
         {
            MessageBox.Show("Seleccione por lo menos una planta antes de eliminar.", "Editar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }
         var assignedIds = lbAssignedFacilities.Items.Cast<Facility>().Select(r => r.Id).ToList();
         var remainingIds = lbAllFacilities.Items.Cast<Facility>().Select(r => r.Id).ToList();
         var toRemove = lbAssignedFacilities.SelectedItems.Cast<Facility>().Select(r => r.Id).ToList();
         remainingIds.AddRange(toRemove);
         assignedIds.RemoveAll(r => toRemove.Contains(r));
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         lbAllFacilities.DataSource = context.Facilities.Where(r => remainingIds.Contains(r.Id)).ToList();
         lbAssignedFacilities.DataSource = context.Facilities.Where(r => assignedIds.Contains(r.Id)).ToList();
         lbAssignedFacilities.DisplayMember = lbAllFacilities.DisplayMember = "FacilityName";
         lbAssignedFacilities.ValueMember = lbAllFacilities.ValueMember = "Id";
         if (lbAssignedFacilities.Items.Count == 0)
         {
            BtnRemove.Enabled = BtnRemoveAll.Enabled = false;
         }
         if (lbAllFacilities.Items.Count > 0)
         {
            BtnAdd.Enabled = BtnAddAll.Enabled = true;
         }
      }

      private void BtnRemoveAll_Click(object sender, EventArgs e)
      {
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         LoadAllFacilities();
         BtnAdd.Enabled = BtnAddAll.Enabled = true;
         BtnRemove.Enabled = BtnRemoveAll.Enabled = false;
      }

      private void BtnAdd_Click(object sender, EventArgs e)
      {
         if (lbAllFacilities.SelectedIndices.Count == 0)
         {
            MessageBox.Show("Seleccione por lo menos una planta antes de agregar.", "Editar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }
         var assignedIds = lbAllFacilities.Items.Cast<Facility>().Select(r => r.Id).ToList();
         var remainingIds = lbAssignedFacilities.Items.Cast<Facility>().Select(r => r.Id).ToList();
         var toRemove = lbAllFacilities.SelectedItems.Cast<Facility>().Select(r => r.Id).ToList();
         remainingIds.AddRange(toRemove);
         assignedIds.RemoveAll(r => toRemove.Contains(r));
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         lbAssignedFacilities.DataSource = null;
         lbAssignedFacilities.Items.Clear();
         lbAssignedFacilities.DataSource = context.Facilities.Where(r => remainingIds.Contains(r.Id)).ToList();
         lbAllFacilities.DataSource = context.Facilities.Where(r => assignedIds.Contains(r.Id)).ToList();
         lbAssignedFacilities.DisplayMember = lbAllFacilities.DisplayMember = "FacilityName";
         lbAssignedFacilities.ValueMember = lbAllFacilities.ValueMember = "Id";
         if (lbAllFacilities.Items.Count == 0)
         {
            BtnAdd.Enabled = BtnAddAll.Enabled = false;
         }
         if (lbAssignedFacilities.Items.Count > 0)
         {
            BtnRemove.Enabled = BtnRemoveAll.Enabled = true;
         }
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
   }
}