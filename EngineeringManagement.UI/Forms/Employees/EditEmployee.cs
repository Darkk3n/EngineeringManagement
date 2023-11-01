using EngineeringManagement.Data.Models;
using EngineeringManagement.Data.Models.Enums;
using System.Data;
using System.Text.RegularExpressions;

namespace EngineeringManagement.UI.Forms
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

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
                employees.Add(new Employee { Id = -1000000, EmployeeName = "-- SELECCIONE --" });
                CmbEmployees.DataSource = employees.OrderBy(r => r.Id).ToList();
                CmbEmployees.ValueMember = "Id";
                CmbEmployees.DisplayMember = "EmployeeName";
                CmbEmployees.SelectedIndex = 0;
            }
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEmployees.SelectedIndex != 0)
            {
                LoadEmployee(CmbEmployees.SelectedItem);
                EnableControls(true);
            }
            else
            {
                EnableControls(false);
                CleanControls();
            }
        }

        private void LoadEmployee(object selectedItem)
        {
            var casted = (Employee)selectedItem;
            TxtName.Text = casted.EmployeeName;
            TxtCurp.Text = casted.Curp;
            TxtPosition.Text = casted.Position;
            CmbEmployeeType.SelectedIndex = (int)casted.EmployeeType;
        }

        private void CleanControls()
        {
            TxtName.Text = string.Empty;
            TxtCurp.Text = string.Empty;
            TxtPosition.Text = string.Empty;
            CmbEmployeeType.SelectedIndex = 0;
        }

        private void EnableControls(bool enable)
        {
            TxtName.Enabled = enable;
            TxtCurp.Enabled = enable;
            TxtPosition.Enabled = enable;
            CmbEmployeeType.Enabled = enable;
            BtnOk.Enabled = enable;
        }

        private static bool IsEmptyString(string value) => string.IsNullOrEmpty(value);

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEmptyString(((TextBox)sender).Text.ToString()))
            {
                e.Cancel = true;
                errors.SetError(TxtName, "Nombre es un campo requerido");
            }
            else
                errors.Clear();
        }

        private void TxtPosition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsEmptyString(((TextBox)sender).Text.ToString()))
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
            if (!string.IsNullOrEmpty(TxtCurp.Text) && !rx.IsMatch(TxtCurp.Text.Trim()))
            {
                e.Cancel = true;
                errors.SetError(TxtCurp, "Formato de CURP invalido");
            }
            else
                errors.Clear();
        }

        private void CmbEmployeeType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0 && !string.IsNullOrEmpty(TxtName.Text))
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
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                MessageBox.Show("Actualizado con exito.", "Editar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private static string CuprRegex => @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
    }
}
