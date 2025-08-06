using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringManagement.Data;
using EngineeringManagement.Data.Models;

namespace EngineeringManagement.UI.Forms.Employees
{
    public partial class EmployeeScopeOfContractGenerator : Form
    {
        private readonly IServiceProvider serviceProvider;
        private readonly HrDataContext context;
        private List<GeneralEmployee> Employees { get; set; } = [];

        public EmployeeScopeOfContractGenerator(IServiceProvider serviceProvider, HrDataContext context)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            this.context = context;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            Employees.AddRange([.. context.GeneralEmployees]);
            if (Employees.Count == 0)
            {
                cmbEmployees.Items.Add("-- NO SE ENCONTRARON EMPLEADOS --");
            }
            else
            {
                cmbEmployees.Items.Clear();
                cmbEmployees.Items.AddRange([.. Employees.OrderBy(r => r.EmployeeName)]);
                cmbEmployees.ValueMember = nameof(Employee.Id);
                cmbEmployees.DisplayMember = nameof(Employee.EmployeeName);
                cmbEmployees.Items.Insert(0, "--SELECCIONE--");
            }
            cmbEmployees.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
