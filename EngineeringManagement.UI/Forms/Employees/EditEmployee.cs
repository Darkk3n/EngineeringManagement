using EngineeringManagement.Data.Models;
using EngineeringManagement.Data.Models.Enums;
using EngineeringManagement.UI.Extensions;
using EngineeringManagement.UI.Services;
using System.Data;
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

            using (var context = new Data.AppContext())
            {
                var employees = context.Employees.ToList();
                employees.Add(new Employee { Id = 1000000, EmployeeName = "-- SELECCIONE --" });
                CmbEmployees.DataSource = employees.OrderByDescending(r => r.Id).ToList();
                CmbEmployees.ValueMember = "Id";
                CmbEmployees.DisplayMember = "EmployeeName";
                CmbEmployees.SelectedIndex = 0;
            }
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
            TxtPosition.Text = employee?.Position;
            CmbEmployeeType.SelectedIndex = (int)employee?.EmployeeType;
            LblLabsFileName.Text = employee?.LabsFileName;
            LblSisositFileName.Text = employee?.SisositFileName;
            pbEmpPhoto.Image = Image.FromFile(GetFilePath(employee));
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
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((TextBox)sender).Text.HasValue())
            {
                e.Cancel = true;
                errors.SetError(TxtName, "Nombre es un campo requerido");
            }
            else
                errors.Clear();
        }

        private void TxtPosition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((TextBox)sender).Text.HasValue())
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
                    employee.EmployeeName = TxtName.Text.Trim();
                    employee.Curp = TxtCurp.Text.Trim();
                    employee.Position = TxtPosition.Text.Trim();
                    employee.EmployeeType = (EmployeeType)CmbEmployeeType.SelectedIndex;
                    employee.PictureFileName = PictureSafeFileName;
                    employee.LabsFileName = LabsSafeFileName;
                    employee.SisositFileName = SisositSafeFileName;
                    context.SaveChanges();
                    CopyFilesService.Execute(new CopyFilesServiceArgs
                    {
                        EmployeeName = employee.EmployeeName,
                        SisositFileName = SisositFileName,
                        SisositSafeFileName = SisositSafeFileName,
                        LabsFileName = LabsFileName,
                        LabsSafeFileName = LabsSafeFileName,
                        PictureFileName = PictureFileName,
                        PictureSafeFileName = PictureSafeFileName
                    });
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

        private void BtnLabsFile_Click(object sender, EventArgs e)
        {
            if (fileDialogLabs.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Esta a punto de modificar el archivo seleccionado de Laboratorios, ¿desea continuar?", "Editar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LabsFileName = fileDialogLabs.FileName;
                    LabsSafeFileName = LblLabsFileName.Text = fileDialogLabs.SafeFileName;
                }
            }
        }

        private void BtnSisositFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta a punto de modificar el archivo seleccionado de SISOSIT, ¿desea continuar?", "Editar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SisositFileName = fileDialogSisosit.FileName;
                SisositSafeFileName = LblSisositFileName.Text = fileDialogSisosit.SafeFileName;
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            if (fileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                PictureSafeFileName = fileDialogPicture.SafeFileName;
                PictureFileName = fileDialogPicture.FileName;
                pbEmpPhoto.Image = Image.FromFile(fileDialogPicture.FileName);
            }
        }
        #endregion
    }
}