using EngineeringManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringManagement.UI.Forms.Certifications
{
    public partial class EditEmployeeCertification : Form
    {
        private readonly MainForm mainForm;
        private readonly EmployeeCertification empCert;

        public EditEmployeeCertification(MainForm mainForm, EmployeeCertification empCert)
        {
            this.mainForm = mainForm;
            this.empCert = empCert;
            InitializeComponent();
        }
    }
}
