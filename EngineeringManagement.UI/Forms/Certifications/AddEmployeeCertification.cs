using EngineeringManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EngineeringManagement.UI.Forms.Certifications
{
    public partial class AddEmployeeCertification : Form
    {
        private readonly MainForm mainForm;

        public AddEmployeeCertification(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Setup();
        }

        private void Setup()
        {
            using (var context = new Data.AppContext())
            {
                var employees = context.Employees.ToList();
                employees.Add(new Employee { Id = 10000, EmployeeName = "-- SELECCIONE --" });
                CmbEmployees.DataSource = employees.OrderByDescending(r => r.Id).ToList();
                CmbEmployees.ValueMember = nameof(Employee.Id);
                CmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
                CmbEmployees.SelectedIndex = 0;
            }
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
            {
                var empId = (((ComboBox)sender).SelectedItem as Employee).Id;
                LoadEmployeeCertifications(empId);
                EnableControls(true);
            }
            else
            {
                lbAssignedCert.DataSource = null;
                lbAssignedCert.Items.Clear();
                lbUnassignedCert.DataSource = null;
                lbUnassignedCert.Items.Clear();
                EnableControls(false);
            }
        }

        private void EnableControls(bool value)
        {
            lbAssignedCert.Enabled = lbUnassignedCert.Enabled = value;
            BtnAdd.Enabled = BtnAddAll.Enabled = BtnRemove.Enabled = BtnRemoveAll.Enabled = value;
            BtnOk.Enabled = value;
            dtpStartDate.Enabled = dtpEndDate.Enabled = value;
        }

        private void LoadEmployeeCertifications(int empId)
        {
            using (var context = new Data.AppContext())
            {
                var assignedCerts = context.EmployeeCertifications
                    .Include(r => r.Certification)
                    .Where(r => r.EmployeeId == empId)
                    .Select(r => r.Certification)
                    .ToList();
                var unassignedCerts = context.Certifications
                    .Where(r => !assignedCerts.Select(r => r.Id).Contains(r.Id))
                    .ToList();

                lbAssignedCert.DataSource = assignedCerts;
                lbUnassignedCert.DataSource = unassignedCerts;
                lbAssignedCert.ValueMember = lbUnassignedCert.ValueMember = nameof(Certification.Id);
                lbAssignedCert.DisplayMember = lbUnassignedCert.DisplayMember = nameof(Certification.CertificationName);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                MessageBox.Show("DC-3 asignadas con exito.", "Agregar DC-3 a Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.ShouldRefreshAllEmployees = true;
                Close();
            }
        }
    }
}