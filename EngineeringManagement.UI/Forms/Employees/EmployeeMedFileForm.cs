using System.Data;
using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using EngineeringManagement.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace EngineeringManagement.UI.Forms.Employees
{
    public partial class EmployeeMedFileForm : Form
    {
        #region Properties
        public EmployeeMedFile CurrentMedFile { get; set; }
        #endregion

        #region Constructor
        public EmployeeMedFileForm()
        {
            InitializeComponent();
            Setup();
        }
        #endregion

        #region Methods
        private void Setup()
        {
            CmbEmployees.DataSource = new EmployeeListService().Get().OrderByDescending(r => r.Id).ToList();
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
            using var context = new Data.AppContext();
            var medFile = context.EmployeeMedFiles
                .Include(r => r.Employee)
                .FirstOrDefault(r => r.EmployeeId == employeeId);

            EnableControls(true);
            if (medFile == null)
            {
                var emp = GetBasicEmployeeData(employeeId);
                LblCurp.Text = emp.Item1.HasValue() ? emp.Item1 : "_";
                LblNss.Text = emp.Item2.HasValue() ? emp.Item2 : "_";
                return;
            }
            CurrentMedFile = medFile;
            TxtBloodType.Text = medFile.BloodType;
            TxtEmergName.Text = medFile.EmergencyName;
            TxtEmergPhone.Text = medFile.EmergencyPhone;
            TxtRelation.Text = medFile.Relation;
            LblCurp.Text = medFile.Employee.Curp.HasValue() ? medFile.Employee.Curp : "_";
            LblNss.Text = medFile.Employee.SocialSecurityNumber.HasValue() ? medFile.Employee.SocialSecurityNumber : "_";
        }

        private static Tuple<string, string> GetBasicEmployeeData(int employeeId)
        {
            using var context = new Data.AppContext();
            var employee = context.Employees.Find(employeeId);
            return new Tuple<string, string>(employee.Curp, employee.SocialSecurityNumber);
        }

        private void BtnCancel_Click(object sender, EventArgs e) => Close();

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var empId = (int)CmbEmployees.SelectedValue;
            using var context = new Data.AppContext();
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
        #endregion
    }
}