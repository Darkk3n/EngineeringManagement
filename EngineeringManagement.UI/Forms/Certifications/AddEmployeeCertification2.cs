using EngineeringManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;

namespace EngineeringManagement.UI.Forms.Certifications
{
    public partial class AddEmployeeCertification2 : Form
    {
        private readonly MainForm mainForm;

        private string FileName { get; set; }

        private string SafeFileName { get; set; }

        public AddEmployeeCertification2(MainForm mainForm)
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
                CleanAndDisableControls();
            }
        }

        private void CleanAndDisableControls()
        {
            CmbCertifications.DataSource = null;
            CmbCertifications.Items.Clear();
            EnableControls(false);
        }

        private void EnableControls(bool value)
        {
            CmbCertifications.Enabled = value;
            BtnOk.Enabled = BtnCertFile.Enabled = value;
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
                unassignedCerts.Add(new Certification { Id = -10000, CertificationName = "-- SELECCIONE --" });
                CmbCertifications.DataSource = unassignedCerts.OrderBy(r => r.Id).ToList();
                CmbCertifications.ValueMember = nameof(Certification.Id);
                CmbCertifications.DisplayMember = nameof(Certification.CertificationName);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var emp = CmbEmployees.SelectedItem as Employee;
            var certId = ((Certification)CmbCertifications.SelectedItem).Id;
            var newEmpCertification = new EmployeeCertification
            {
                EmployeeId = emp.Id,
                CertificationId = certId,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                FileName = SafeFileName
            };
            try
            {
                using (var context = new Data.AppContext())
                {
                    context.EmployeeCertifications.Add(newEmpCertification);
                    context.SaveChanges();
                }
                HandleFile(emp.EmployeeName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                MessageBox.Show("DC-3 asignada con exito.", "Agregar DC-3 a Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var result = MessageBox.Show("Desea continuar?", "Agregar DC-3 a Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CleanAndDisableControls();
                    CmbEmployees.SelectedIndex = 0;
                    CmbEmployees.Focus();
                }
                else
                {
                    mainForm.ShouldRefreshAllEmployees = true;
                    Close();
                }
            }
        }

        private void HandleFile(string employeeName)
        {
            var pathToCopy = Path.Combine(Application.StartupPath, "Documentos", employeeName);
            try
            {
                File.Copy(FileName, Path.Combine(pathToCopy, SafeFileName));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCertFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = fileDialog.FileName;
                SafeFileName = LblFileName.Text = fileDialog.SafeFileName;
            }
        }

        private void BtnViewCert_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = FileName,
                UseShellExecute = true
            });
        }
    }
}