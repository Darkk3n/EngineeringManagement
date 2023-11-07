using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using System.Text.RegularExpressions;

namespace EngineeringManagement.UI.Forms
{
    public partial class AddEmployee : Form
    {
        private string LabsFileName { get; set; }
        private string LabsSafeFileName { get; set; }
        private string SisositFileName { get; set; }
        private string SisositSafeFileName { get; set; }
        public string PictureSafeFileName { get; set; }
        public string PictureFileName { get; set; }

        public AddEmployee()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbEmployeeType.Items.Add(new { Value = 0, Display = "-- SELECCIONE --" });
            cmbEmployeeType.Items.Add(new { Value = 1, Display = "Operativo" });
            cmbEmployeeType.Items.Add(new { Value = 2, Display = "Administrativo" });
            cmbEmployeeType.SelectedIndex = 0;
            cmbEmployeeType.ValueMember = "Value";
            cmbEmployeeType.DisplayMember = "Display";
            txtCurp.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errors.Clear();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmployeeName = txtName.Text,
                Curp = txtCurp.Text,
                Position = txtPosition.Text,
                LabsFileName = LabsSafeFileName.HasValue() ? LabsSafeFileName : string.Empty,
                SisositFileName = SisositSafeFileName.HasValue() ? SisositSafeFileName : string.Empty,
                PictureFileName = PictureSafeFileName.HasValue() ? PictureSafeFileName : string.Empty,
            };
            try
            {
                using var context = new Data.AppContext();
                context.Employees.Add(newEmp);
                context.SaveChanges();
                HandleLabsFile(newEmp.EmployeeName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                MessageBox.Show("Guardado con exito", "Agregar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void HandleLabsFile(string employeeName)
        {
            var pathToCopy = Path.Combine(Application.StartupPath, "Documentos", employeeName);
            if (!Directory.Exists(pathToCopy))
            {
                Directory.CreateDirectory(pathToCopy);
            }
            if (LabsFileName.HasValue())
            {
                CopyFile(LabsFileName, Path.Combine(pathToCopy, LabsSafeFileName));
            }
            if (SisositFileName.HasValue())
            {
                CopyFile(SisositFileName, Path.Combine(pathToCopy, SisositSafeFileName));
            }
            if (PictureSafeFileName.HasValue())
            {
                CopyFile(PictureFileName, Path.Combine(pathToCopy, PictureSafeFileName));
            }
        }

        private void CopyFile(string fileName, string pathToCopy)
        {
            try
            {
                File.Copy(fileName, pathToCopy);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!((TextBox)sender).Text.HasValue())
            {
                e.Cancel = true;
                errors.SetError(txtName, "Nombre es un campo requerido");
            }
            else
                errors.Clear();
        }

        private void txtPosition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!((TextBox)sender).Text.HasValue())
            {
                e.Cancel = true;
                errors.SetError(txtPosition, "Puesto es un campo requerido");
            }
            else
                errors.Clear();
        }

        private void txtCurp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rx = new(CuprRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (txtCurp.Text.HasValue() && !rx.IsMatch(txtCurp.Text.Trim()))
            {
                e.Cancel = true;
                errors.SetError(txtCurp, "Formato de CURP invalido");
            }
            else
                errors.Clear();
        }

        private void cmbEmployeeType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0 && txtName.Text.HasValue())
            {
                e.Cancel = true;
                errors.SetError(cmbEmployeeType, "Seleccione un tipo de Empleado");
            }
            else
                errors.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LabsFileName = fileDialog.FileName;
                LabsSafeFileName = lblSelectedLabsFile.Text = fileDialog.SafeFileName;
            }
        }

        private void btnSisositOpenFile_Click(object sender, EventArgs e)
        {
            if (fileDialogSisosit.ShowDialog() == DialogResult.OK)
            {
                SisositFileName = fileDialogSisosit.FileName;
                SisositSafeFileName = lblSisositFile.Text = fileDialogSisosit.SafeFileName;
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (fileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                PictureSafeFileName = fileDialogPicture.SafeFileName;
                PictureFileName = fileDialogPicture.FileName;
                pbEmpPhoto.Image = Image.FromFile(fileDialogPicture.FileName);
            }
        }

        private static string CuprRegex => @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
    }
}