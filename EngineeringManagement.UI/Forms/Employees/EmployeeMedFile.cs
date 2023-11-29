using System.Data;
using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Services;

namespace EngineeringManagement.UI.Forms.Employees
{
    public partial class EmployeeMedFile : Form
    {
        public EmployeeMedFile()
        {
            InitializeComponent();
            Setup();
        }

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
                LoadEmployee(CmbEmployees.SelectedItem as Employee);
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
        }

        private void LoadEmployee(Employee employee)
        {
            
        }
    }
}