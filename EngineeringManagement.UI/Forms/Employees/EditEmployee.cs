using EngineeringManagement.Data.Models;
using EngineeringManagement.Data.Models.Enums;
using EngineeringManagement.UI.Extensions;
using EngineeringManagement.UI.Services;
using System.Data;
using System.Diagnostics;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EngineeringManagement.UI.Forms
{
   public partial class EditEmployee : Form
   {
      #region Properties
      private Employee _employee;
      private string LabsFileName { get; set; }
      private string LabsSafeFileName { get; set; }
      private string SisositFileName { get; set; }
      private string SisositSafeFileName { get; set; }
      private string PictureSafeFileName { get; set; }
      private string PictureFileName { get; set; }
      private static string CuprRegex => @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
      #endregion

      #region Constructor
      public EditEmployee()
      {
         InitializeComponent();
      }
      #endregion

      #region Methods
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         Setup();
      }

      private void Setup()
      {
         CmbEmployeeType.Items.Add(new { Value = 0, Display = "-- SELECCIONE --" });
         CmbEmployeeType.Items.Add(new { Value = 1, Display = "Operativo" });
         CmbEmployeeType.Items.Add(new { Value = 2, Display = "Administrativo" });
         CmbEmployeeType.SelectedIndex = 0;
         CmbEmployeeType.ValueMember = "Value";
         CmbEmployeeType.DisplayMember = "Display";
         TxtCurp.CharacterCasing = CharacterCasing.Upper;

         CmbEmployees.DataSource = new EmployeeListService().Get().OrderByDescending(r => r.Id).ToList();
         CmbEmployees.ValueMember = nameof(Employee.Id);
         CmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
         CmbEmployees.SelectedIndex = 0;
      }

      private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (CmbEmployees.SelectedIndex != 0)
         {
            LoadEmployee(CmbEmployees.SelectedItem as Employee);
            EnableControls(true);
         }
         else
         {
            EnableControls(false);
            CleanControls();
         }
      }

      private void LoadEmployee(Employee employee)
      {
         TxtName.Text = employee?.EmployeeName;
         TxtCurp.Text = employee?.Curp;
         TxtNss.Text = employee?.SocialSecurityNumber;
         TxtPosition.Text = employee?.Position;
         CmbEmployeeType.SelectedIndex = (int)employee?.EmployeeType;
         LblLabsFileName.Text = employee.LabsFileName.HasValue() ? employee?.LabsFileName : "Ningun archivo seleccionado...";
         BtnViewLabs.Enabled = employee.LabsFileName.HasValue();
         LblSisositFileName.Text = employee.SisositFileName.HasValue() ? employee.SisositFileName : "Ningun archivo seleccionado";
         BtnViewSisosit.Enabled = employee.SisositFileName.HasValue();
         pbEmpPhoto.Image = null;
         if (employee.PictureFileName.HasValue())
         {
            pbEmpPhoto.Image = Image.FromFile(GetFilePath(employee));
         }
         _employee = employee;
      }

      private static string GetFilePath(Employee employee) => Path.Combine(Application.StartupPath, "Documentos", employee.EmployeeName, employee.PictureFileName);

      private void CleanControls()
      {
         TxtName.Text = string.Empty;
         TxtCurp.Text = string.Empty;
         TxtPosition.Text = string.Empty;
         CmbEmployeeType.SelectedIndex = 0;
         LblLabsFileName.Text = LblSisositFileName.Text = "Ningun archivo seleccionado...";
      }

      private void EnableControls(bool enable)
      {
         TxtName.Enabled = enable;
         TxtCurp.Enabled = enable;
         TxtPosition.Enabled = enable;
         CmbEmployeeType.Enabled = enable;
         BtnOk.Enabled = enable;
         BtnLabsFile.Enabled = enable;
         BtnPicture.Enabled = enable;
         BtnSisositFile.Enabled = enable;
         TxtNss.Enabled = enable;
      }

      private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (!((TextBox)sender).Text.HasValue())
         {
            e.Cancel = true;
            errors.SetError(TxtName, "Nombre es un campo requerido");
         }
         else
            errors.Clear();
      }

      private void TxtPosition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (!((TextBox)sender).Text.HasValue())
         {
            e.Cancel = true;
            errors.SetError(TxtPosition, "Puesto es un campo requerido");
         }
         else
            errors.Clear();
      }

      private void TxtCurp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         Regex rx = new(CuprRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
         if (TxtCurp.Text.HasValue() && !rx.IsMatch(TxtCurp.Text.Trim()))
         {
            e.Cancel = true;
            errors.SetError(TxtCurp, "Formato de CURP invalido");
         }
         else
            errors.Clear();
      }

      private void CmbEmployeeType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (((ComboBox)sender).SelectedIndex == 0 && TxtName.Text.HasValue())
         {
            e.Cancel = true;
            errors.SetError(CmbEmployeeType, "Seleccione un tipo de Empleado");
         }
         else
            errors.Clear();
      }

      private void BtnOk_Click(object sender, EventArgs e)
      {
         var employeeId = (int)CmbEmployees.SelectedValue;
         try
         {
            using (var context = new Data.AppContext())
            {
               var employee = context.Employees.Find(employeeId);
               var originalPicture = employee.PictureFileName;
               var originalLabs = employee.LabsFileName;
               var originalSisosit = employee.SisositFileName;
               var originalEmployeeName = employee.EmployeeName;
               employee.EmployeeName = TxtName.Text.Trim();
               employee.Curp = TxtCurp.Text.Trim();
               employee.SocialSecurityNumber = TxtNss.Text.Trim();
               employee.Position = TxtPosition.Text.Trim();
               employee.EmployeeType = (EmployeeType)CmbEmployeeType.SelectedIndex;
               if (PictureSafeFileName.HasValue())
               {
                  employee.PictureFileName = PictureSafeFileName;
               }
               if (LabsSafeFileName.HasValue())
               {
                  employee.LabsFileName = LabsSafeFileName;
               }
               if (SisositSafeFileName.HasValue())
               {
                  employee.SisositFileName = SisositSafeFileName;
               }
               context.SaveChanges();
               RelocateFilesIfNecessary(originalEmployeeName, employee);
               HandleFiles(employee, originalPicture, originalLabs, originalSisosit);
            }
         }
         catch (Exception)
         {
            throw;
         }
         finally
         {
            MessageBox.Show("Actualizado con exito.", "Editar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
         }
      }

      private void RelocateFilesIfNecessary(string originalEmployeeName, Employee employee)
      {
         if (originalEmployeeName == employee.EmployeeName)
            return;
         var files = Directory.GetFiles(Path.Combine(Application.StartupPath, "Documentos", originalEmployeeName));
         var newPath = Path.Combine(Application.StartupPath, "Documentos", employee.EmployeeName);
         Directory.CreateDirectory(newPath);
         foreach (var file in files)
         {
            var fileName = Path.GetFileName(file);
            File.Copy(file, Path.Combine(newPath, fileName));
         }
         ReloadPicture(Path.Combine(newPath, employee.PictureFileName));
         files.ToList().ForEach(r => File.Delete(r));
         Directory.Delete(Path.Combine(Application.StartupPath, "Documentos", originalEmployeeName));
      }

      private void ReloadPicture(string pictureFileName)
      {
         pbEmpPhoto.Image.Dispose();
         pbEmpPhoto.Image = Image.FromFile(pictureFileName);
      }

      private void HandleFiles(Employee employee, string originalPicture, string originalLabs, string originalSisosit)
      {
         if (PictureSafeFileName.HasValue())
         {
            CopyFilesService.Execute(new CopyFilesServiceArgs
            {
               EmployeeName = employee.EmployeeName,
               FileName = PictureFileName,
               SafeFileName = PictureSafeFileName,
               OriginalFileName = originalPicture
            });
         }
         if (LabsSafeFileName.HasValue())
         {
            CopyFilesService.Execute(new CopyFilesServiceArgs
            {
               EmployeeName = employee.EmployeeName,
               FileName = LabsFileName,
               SafeFileName = LabsSafeFileName,
               OriginalFileName = originalLabs
            });
         }
         if (SisositSafeFileName.HasValue())
         {
            CopyFilesService.Execute(new CopyFilesServiceArgs
            {
               EmployeeName = employee.EmployeeName,
               FileName = SisositFileName,
               SafeFileName = SisositSafeFileName,
               OriginalFileName = originalSisosit
            });
         }
      }

      private void BtnLabsFile_Click(object sender, EventArgs e)
      {
         if (fileDialogLabs.ShowDialog() == DialogResult.OK && MessageBox.Show("Esta a punto de modificar el archivo seleccionado de Laboratorios, ¿desea continuar?", "Editar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            LabsFileName = _employee.LabsFileName = fileDialogLabs.FileName;
            LabsSafeFileName = LblLabsFileName.Text = fileDialogLabs.SafeFileName;
         }
      }

      private void BtnSisositFile_Click(object sender, EventArgs e)
      {
         if (fileDialogSisosit.ShowDialog() == DialogResult.OK && MessageBox.Show("Esta a punto de modificar el archivo seleccionado de SISOSIT, ¿desea continuar?", "Editar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            SisositFileName = _employee.SisositFileName = fileDialogSisosit.FileName;
            SisositSafeFileName = LblSisositFileName.Text = fileDialogSisosit.SafeFileName;
         }
      }

      private void BtnPicture_Click(object sender, EventArgs e)
      {
         if (fileDialogPicture.ShowDialog() == DialogResult.OK)
         {
            PictureSafeFileName = fileDialogPicture.SafeFileName;
            PictureFileName = fileDialogPicture.FileName;
            pbEmpPhoto.Image?.Dispose();
            pbEmpPhoto.Image = Image.FromFile(fileDialogPicture.FileName);
         }
      }

      private void BtnViewLabs_Click(object sender, EventArgs e) => OpenFile(_employee.LabsFileName);

      private void BtnViewSisosit_Click(object sender, EventArgs e) => OpenFile(_employee.SisositFileName);

      private void OpenFile(string fileName) => OpenFileService.Execute(fileName, _employee.EmployeeName);
      #endregion
   }
}