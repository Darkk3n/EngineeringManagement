namespace EngineeringManagement.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            menuStrip1 = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            editarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            plantasToolStripMenuItem = new ToolStripMenuItem();
            dC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3ToolStripMenuItem = new ToolStripMenuItem();
            editarDC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3AEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(0, 24);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(956, 464);
            dgvEmployees.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, plantasToolStripMenuItem, dC3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(956, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, editarEmpleadoToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(172, 22);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            editarEmpleadoToolStripMenuItem.Size = new Size(172, 22);
            editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            // 
            // plantasToolStripMenuItem
            // 
            plantasToolStripMenuItem.Name = "plantasToolStripMenuItem";
            plantasToolStripMenuItem.Size = new Size(57, 20);
            plantasToolStripMenuItem.Text = "Plantas";
            // 
            // dC3ToolStripMenuItem
            // 
            dC3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarDC3ToolStripMenuItem, editarDC3ToolStripMenuItem, agregarDC3AEmpleadoToolStripMenuItem });
            dC3ToolStripMenuItem.Name = "dC3ToolStripMenuItem";
            dC3ToolStripMenuItem.Size = new Size(46, 20);
            dC3ToolStripMenuItem.Text = "DC-3";
            // 
            // agregarDC3ToolStripMenuItem
            // 
            agregarDC3ToolStripMenuItem.Name = "agregarDC3ToolStripMenuItem";
            agregarDC3ToolStripMenuItem.Size = new Size(211, 22);
            agregarDC3ToolStripMenuItem.Text = "Agregar DC-3";
            // 
            // editarDC3ToolStripMenuItem
            // 
            editarDC3ToolStripMenuItem.Name = "editarDC3ToolStripMenuItem";
            editarDC3ToolStripMenuItem.Size = new Size(211, 22);
            editarDC3ToolStripMenuItem.Text = "Editar DC-3";
            // 
            // agregarDC3AEmpleadoToolStripMenuItem
            // 
            agregarDC3AEmpleadoToolStripMenuItem.Name = "agregarDC3AEmpleadoToolStripMenuItem";
            agregarDC3AEmpleadoToolStripMenuItem.Size = new Size(211, 22);
            agregarDC3AEmpleadoToolStripMenuItem.Text = "Agregar DC-3 a Empleado";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 488);
            Controls.Add(dgvEmployees);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL TOTAL INGENIERIA";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem plantasToolStripMenuItem;
        private ToolStripMenuItem dC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3ToolStripMenuItem;
        private ToolStripMenuItem editarDC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3AEmpleadoToolStripMenuItem;
    }
}