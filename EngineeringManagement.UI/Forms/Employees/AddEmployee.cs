using EngineeringManagement.Data.Models;
using System.Text.RegularExpressions;

namespace EngineeringManagement.UI.Forms
{
    public partial class AddEmployee : Form
    {
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
            };
            try
            {
                using var context = new Data.AppContext();
                context.Employees.Add(newEmp);
                context.SaveChanges();
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

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEmptyString(((TextBox)sender).Text.ToString()))
            {
                e.Cancel = true;
                errors.SetError(txtName, "Nombre es un campo requerido");
            }
            else
                errors.Clear();
        }

        private static bool IsEmptyString(string value) => string.IsNullOrEmpty(value);

        private void txtPosition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEmptyString(((TextBox)sender).Text.ToString()))
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
            if (!string.IsNullOrEmpty(txtCurp.Text) && !rx.IsMatch(txtCurp.Text.Trim()))
            {
                e.Cancel = true;
                errors.SetError(txtCurp, "Formato de CURP invalido");
            }
            else
                errors.Clear();
        }

        private void cmbEmployeeType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0 && !string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                errors.SetError(cmbEmployeeType, "Seleccione un tipo de Empleado");
            }
            else
                errors.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private static string CuprRegex => @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
    }
}