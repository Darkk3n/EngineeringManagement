using System.Data;
using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.UI.Forms.Employees
{
   public partial class EmployeeMedFileForm : Form
   {
      #region Properties
      private readonly IEmployeeListService employeeListService;
      private readonly IOpenFileService openFileService;
      private readonly Data.AppContext context;

      private EmployeeMedFile CurrentMedFile { get; set; }
      private Employee SelectedEmployee { get; set; }
      #endregion

      #region Constructor
      public EmployeeMedFileForm(IEmployeeListService employeeListService, IOpenFileService openFileService, Data.AppContext context)
      {
         InitializeComponent();
         Setup();
         this.employeeListService = employeeListService;
         this.openFileService = openFileService;
         this.context = context;
      }
      #endregion

      #region Methods
      private void Setup()
      {
         CmbEmployees.DataSource = employeeListService.Get().OrderByDescending(r => r.Id).ToList();
         CmbEmployees.ValueMember = nameof(Employee.Id);
         CmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
         CmbEmployees.SelectedIndex = 0;
      }

      private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (CmbEmployees.SelectedIndex != 0)
         {
            LoadEmployee((CmbEmployees.SelectedItem as Employee).Id);
            EnableControls(true);
         }
         else
         {
            EnableControls(false);
            CleanControls();
         }
      }

      private void CleanControls()
      {
         TxtBloodType.Text = TxtEmergName.Text = TxtEmergPhone.Text = TxtRelation.Text = string.Empty;
      }

      private void EnableControls(bool enabled)
      {
         TxtBloodType.Enabled = TxtEmergName.Enabled = TxtEmergPhone.Enabled = TxtRelation.Enabled = enabled;
         BtnOk.Enabled = BtnViewLabs.Enabled = BtnViewSisosit.Enabled = enabled;
         CmbAble.Enabled = enabled;
      }

      private void LoadEmployee(int employeeId)
      {
         var medFile = context.EmployeeMedFiles
             .Include(r => r.Employee)
             .FirstOrDefault(r => r.EmployeeId == employeeId);
         LoadEmployeeData(employeeId);
         EnableControls(true);
         if (medFile == null)
         {
            LblCurp.Text = SelectedEmployee.Curp.HasValue() ? SelectedEmployee.Curp : "_";
            LblNss.Text = SelectedEmployee.SocialSecurityNumber.HasValue() ? SelectedEmployee.SocialSecurityNumber : "_";
            return;
         }
         CurrentMedFile = medFile;
         TxtBloodType.Text = medFile.BloodType;
         TxtEmergName.Text = medFile.EmergencyName;
         TxtEmergPhone.Text = medFile.EmergencyPhone;
         TxtRelation.Text = medFile.Relation;
      }

      private void LoadEmployeeData(int employeeId)
      {
         SelectedEmployee = GetBasicEmployeeData(employeeId);
         LblCurp.Text = SelectedEmployee.Curp.HasValue() ? SelectedEmployee.Curp : "_";
         LblNss.Text = SelectedEmployee.SocialSecurityNumber.HasValue() ? SelectedEmployee.SocialSecurityNumber : "_";
      }

      private Employee GetBasicEmployeeData(int employeeId)
      {
         var employee = context.Employees.Find(employeeId);
         return employee;
      }

      private void BtnCancel_Click(object sender, EventArgs e) => Close();

      private void BtnOk_Click(object sender, EventArgs e)
      {
         var empId = (int)CmbEmployees.SelectedValue;
         if (CurrentMedFile == null)
         {
            var medFile = new EmployeeMedFile
            {
               EmployeeId = empId,
               BloodType = TxtBloodType.Text,
               EmergencyName = TxtEmergName.Text,
               EmergencyPhone = TxtEmergPhone.Text,
               Relation = TxtRelation.Text
               //TODO: Add Able field value
            };
            context.EmployeeMedFiles.Add(medFile);
         }
         else
         {
            var existingFile = context.EmployeeMedFiles.Find(CurrentMedFile.Id);
            existingFile.BloodType = TxtBloodType.Text;
            existingFile.Relation = TxtRelation.Text;
            existingFile.EmergencyPhone = TxtEmergPhone.Text;
            existingFile.EmergencyName = TxtEmergName.Text;
            //TODO: Add Able field value
         }
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
            var message = CurrentMedFile == null ? "Creado" : "Actualizado";
            MessageBox.Show($"{message} con exito.", "Expedientes Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
         }
      }

      private void BtnViewSisosit_Click(object sender, EventArgs e)
      {
         if (SelectedEmployee.SisositFileName.HasValue())
            OpenFile(SelectedEmployee.SisositFileName);
         else
            MessageBox.Show("Empleado no cuenta con dicho archivo.", "Expedientes Medicos - Ver SISOSIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }

      private void BtnViewLabs_Click(object sender, EventArgs e)
      {
         if (SelectedEmployee.LabsFileName.HasValue())
            OpenFile(SelectedEmployee.LabsFileName);
         else
            MessageBox.Show("Empleado no cuenta con dicho archivo.", "Expedientes Medicos - Ver Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      private void OpenFile(string fileName) => openFileService.Execute(fileName, Application.StartupPath, SelectedEmployee.EmployeeName);
      #endregion
   }
}