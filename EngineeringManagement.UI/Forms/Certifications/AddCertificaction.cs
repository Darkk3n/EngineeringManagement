using EngineeringManagement.Data.Models;
using EngineeringManagement.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringManagement.UI.Forms
{
    public partial class AddCertificaction : Form
    {
        public AddCertificaction()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!TxtCertName.Text.HasValue())
            {
                MessageBox.Show("Nombre es un campo requerido", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            var certification = new Certification
            {
                CertificationName = TxtCertName.Text,
                Description = TxtCertDesc.Text,
            };
            using (var context = new Data.AppContext())
            {
                try
                {
                    context.Certifications.Add(certification);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    MessageBox.Show("Guardado con exito.", "Agregar DC-3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
