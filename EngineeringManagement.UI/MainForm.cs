using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Forms;
using EngineeringManagement.UI.Forms.Certifications;
using EngineeringManagement.UI.Forms.Employees;
using EngineeringManagement.UI.Forms.GeneralEmployee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EngineeringManagement.UI
{
   public partial class MainForm : Form
   {
      #region Properties
      public bool ShouldRefreshAllEmployees { get; set; }
      private readonly IServiceProvider serviceProvider;
      private readonly Data.AppContext context;
      private List<Employee> Employees { get; set; } = [];
      private bool IsLoading { get; set; }
      #endregion

      #region Initialization
      public MainForm(IServiceProvider serviceProvider, Data.AppContext context)
      {
         InitializeComponent();
         this.serviceProvider = serviceProvider;
         this.context = context;
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         IsLoading = true;
         Setup();
         IsLoading = false;
      } 
      #endregion

      #region Private Methods
      private void Setup()
      {
         //LoadGrids();
         //FormatColumnHeaders(dgvExpiringCertEmp);
         //FormatColumnHeaders(dgvAllEmployees);
         //dgvAllEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         //tabPage1.Text = $"Proximos a expirar entre {DateTime.Now.AddDays(-10).ToString("dd/MM/yyyy", new CultureInfo("es-MX"))} y {DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("es-MX"))}";

         //TODO: Create statements to insert default data into GeneralEmployee table and
         //change this DbSet to GeneralEmployees
         Employees.AddRange([.. context.Employees]);
         if (Employees.Count == 0)
         {
            cmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployees.Items.Add("-- NO SE ENCONTRARON EMPLEADOS --");
            cmbEmployees.SelectedIndex = 0;
         }
         else
         {
            SetupComboBox();
            SetupGridView();
         }
      }

      private void SetupGridView()
      {
         dgvEmployeeList.Rows.Clear();
         AddColumnsToGrid();
         AddAllEmployees();
         dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         dgvEmployeeList.Columns[2].Visible = false;
      }

      private void AddAllEmployees()
      {
         var orderedEmployees = Employees.OrderBy(r => r.EmployeeName).ToList();
         foreach (var employee in orderedEmployees)
         {
            dgvEmployeeList.Rows.Add(false, employee.EmployeeName, employee.Id, employee.Position, employee.SocialSecurityNumber);
         }
      }

      private void AddColumnsToGrid()
      {
         var checkBoxColumn = new DataGridViewCheckBoxColumn
         {
            Name = "Select",
            HeaderText = "",
            Width = 20,
            MinimumWidth = 20,
            FillWeight = 20
         };
         int totalWidth = dgvEmployeeList.ClientSize.Width - checkBoxColumn.Width;
         var columns = new DataGridViewTextBoxColumn[] {
            new() {
               Name = "Name",
               HeaderText = "Empleado",
               Width = totalWidth / 3
            },
            new() {
               Name = "EmployeeId",
               HeaderText = "Employee ID",
            },
            new() {
               Name = "Position",
               HeaderText = "Puesto",
               Width = totalWidth / 3
            },
            new() {
               Name = "Phone",
               HeaderText = "Telefono",
               Width = totalWidth / 3
            }
         };

         dgvEmployeeList.Columns.Add(checkBoxColumn);
         dgvEmployeeList.Columns.AddRange(columns);
      }

      private void SetupComboBox()
      {
         cmbEmployees.DropDownStyle = ComboBoxStyle.DropDown;
         cmbEmployees.Items.AddRange([.. Employees.OrderBy(r => r.EmployeeName)]);
         cmbEmployees.ValueMember = nameof(Employee.Id);
         cmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
         cmbEmployees.SelectedIndex = 0;
         cmbEmployees.AutoCompleteCustomSource.AddRange(Employees.Select(r => r.EmployeeName).ToArray());
         cmbEmployees.AutoCompleteSource = AutoCompleteSource.CustomSource;
         cmbEmployees.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      }

      private void ReloadGrid()
      {
         dgvEmployeeList.Rows.Clear();
         Employees.Clear();
         Employees.AddRange([.. context.Employees]);
         AddAllEmployees();
      } 
      #endregion

      //private void LoadGrids()
      //{
      //   dgvAllEmployees.DataSource = null;
      //   dgvExpiringCertEmp.DataSource = null;
      //   var tenDaysAgo = DateTime.Now.AddDays(-10);
      //   var allEmployees = context.EmployeeCertifications
      //                   .Include(r => r.Employee)
      //                   .Include(r => r.Certification)
      //                   .OrderByDescending(r => r.EmployeeId)
      //                   .Select(r => new
      //                   {
      //                      EmployeeCertId = r.Id,
      //                      r.Employee.EmployeeName,
      //                      r.Certification.CertificationName,
      //                      StarDate = r.StartDate.Value.Date,
      //                      EndDate = r.EndDate.Value.Date,
      //                      StartDateStr = r.StartDate.Value.Date.ToString("dd/MM/yyyy", new CultureInfo("es-MX")),
      //                      EndDateStr = r.EndDate.Value.Date.ToString("dd/MM/yyyy", new CultureInfo("es-MX")),
      //                   });
      //   var soonToExpire = allEmployees.Where(r =>
      //       r.EndDate >= tenDaysAgo
      //       && r.EndDate <= DateTime.Now)
      //       .ToList();
      //   dgvExpiringCertEmp.DataSource = soonToExpire.OrderBy(r => r.EndDate).ToList();
      //   dgvAllEmployees.DataSource = allEmployees.ToList();
      //   FormatColumnHeaders(dgvAllEmployees);
      //   FormatColumnHeaders(dgvExpiringCertEmp);
      //}

      //private static void FormatColumnHeaders(DataGridView gridView)
      //{
      //   gridView.Columns[1].HeaderText = "Colaborador";
      //   gridView.Columns[2].HeaderText = "Certificacion";
      //   gridView.Columns[5].HeaderText = "Inicio";
      //   gridView.Columns[6].HeaderText = "Vencimiento";
      //   gridView.Columns[0].Visible = false;
      //   gridView.Columns[3].Visible = false;
      //   gridView.Columns[4].Visible = false;
      //}

      #region Menu Options
      private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var addEmp = serviceProvider.GetRequiredService<AddEmployee>();
         addEmp.ShowDialog();
      }

      private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var editEmp = serviceProvider.GetRequiredService<EditEmployee>();
         editEmp.ShowDialog();
      }

      private void agregarPlantaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var addFacility = serviceProvider.GetRequiredService<AddFacility>();
         addFacility.ShowDialog();
      }

      private void editarPlantaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var editFacility = serviceProvider.GetRequiredService<EditFacility>();
         editFacility.ShowDialog();
      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void agregarDC3ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var addCertificacion = serviceProvider.GetRequiredService<AddCertification>();
         addCertificacion.ShowDialog();
      }

      private void editarDC3ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var editCertification = serviceProvider.GetRequiredService<EditCertification>();
         editCertification.ShowDialog();
      }

      private void agregarDC3AEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var addCertToEmployee = serviceProvider.GetRequiredService<AddEmployeeCertification2>();
         addCertToEmployee.ShowDialog();
         //ReloadGrids();
      }

      //private void dgvExpiringCertEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      //{
      //   if (e.RowIndex < 0)
      //      return;
      //   var empCert = GetCertificationFromGrid(sender as DataGridView, e.RowIndex);
      //   OpenEditCertificationDialog(empCert);
      //}

      //private void dgvAllEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      //{
      //   if (e.RowIndex < 0)
      //      return;
      //   var empCert = GetCertificationFromGrid(sender as DataGridView, e.RowIndex);
      //   OpenEditCertificationDialog(empCert);
      //}

      //private void OpenEditCertificationDialog(EmployeeCertification empCert)
      //{
      //   var openFileService = serviceProvider.GetRequiredService<IOpenFileService>();
      //   var mainForm = serviceProvider.GetRequiredService<MainForm>();
      //   using var editCertification = new EditEmployeeCertification(empCert, mainForm, openFileService, context);
      //   editCertification.ShowDialog();
      //   //ReloadGrids();
      //}

      //private void ReloadGrids()
      //{
      //   if (ShouldRefreshAllEmployees)
      //   {
      //      LoadGrids();
      //   }
      //}

      //private EmployeeCertification GetCertificationFromGrid(DataGridView dataGridView, int rowIndex)
      //{
      //   var empCertificationId = (int)dataGridView.Rows[rowIndex].Cells[0].Value;
      //   var empCert = context.EmployeeCertifications
      //       .Include(r => r.Certification)
      //       .Include(r => r.Employee)
      //       .First(r => r.Id == empCertificationId);
      //   return empCert;
      //}

      private void expedientesMedicosToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var medFiles = serviceProvider.GetRequiredService<EmployeeMedFileForm>();
         medFiles.ShowDialog();
      }
      #endregion

      #region Button Callbacks
      private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsLoading)
         {
            var employee = ((ComboBox)sender).SelectedItem as Employee;
            dgvEmployeeList.Rows.Clear();
            dgvEmployeeList.Rows.Add(false, employee.EmployeeName, employee.Id, employee.Position, employee.SocialSecurityNumber);
         }
      }

      private void cmbEmployees_TextChanged(object sender, EventArgs e)
      {
         if ((sender as ComboBox).Text == "")
         {
            dgvEmployeeList.Rows.Clear();
            AddAllEmployees();
         }
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         var generalEmpForm = serviceProvider.GetRequiredService<GeneralEmployeeForm>();
         generalEmpForm.ShowDialog();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         var checkedRows = dgvEmployeeList.Rows
          .Cast<DataGridViewRow>()
          .Where(row => Convert.ToBoolean(row.Cells[0].Value) == true)
          .Select(r => new
          {
             Id = Convert.ToInt32(r.Cells[2].Value),
             Name = r.Cells[1].Value.ToString(),
          })
          .ToList();
         if (checkedRows.Count == 0)
         {
            MessageBox.Show("Seleccione al menos 1 Empleado.", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
         else
         {
            var message = string.Join(Environment.NewLine, checkedRows.Select(r => r.Name));

            if (MessageBox.Show($"Esta seguro que desea eliminar el/los siguiente(s) empleado(s): {Environment.NewLine}{Environment.NewLine}{message}", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
               context.Employees
                  .Where(r => checkedRows.Select(r => r.Id).Contains(r.Id))
                  .ExecuteDelete();
               MessageBox.Show("Empleado(s) eliminado(s) con exito.", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ReloadGrid();
            }
         }
      } 
      #endregion      
   }
}