﻿namespace EngineeringManagement.UI
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
            dgvExpiringCertEmp = new DataGridView();
            menuStrip1 = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            editarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            plantasToolStripMenuItem = new ToolStripMenuItem();
            dC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3ToolStripMenuItem = new ToolStripMenuItem();
            editarDC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3AEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblSoonToExpire = new Label();
            tabPage2 = new TabPage();
            dgvAllEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExpiringCertEmp).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvExpiringCertEmp
            // 
            dgvExpiringCertEmp.AllowUserToAddRows = false;
            dgvExpiringCertEmp.AllowUserToDeleteRows = false;
            dgvExpiringCertEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpiringCertEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpiringCertEmp.Dock = DockStyle.Bottom;
            dgvExpiringCertEmp.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvExpiringCertEmp.Location = new Point(3, 59);
            dgvExpiringCertEmp.Name = "dgvExpiringCertEmp";
            dgvExpiringCertEmp.ReadOnly = true;
            dgvExpiringCertEmp.RowTemplate.Height = 25;
            dgvExpiringCertEmp.Size = new Size(942, 374);
            dgvExpiringCertEmp.TabIndex = 0;
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
            agregarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            editarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            editarEmpleadoToolStripMenuItem.Click += editarEmpleadoToolStripMenuItem_Click;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(956, 464);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblSoonToExpire);
            tabPage1.Controls.Add(dgvExpiringCertEmp);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(948, 436);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proximos a Expirar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSoonToExpire
            // 
            lblSoonToExpire.AutoSize = true;
            lblSoonToExpire.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoonToExpire.Location = new Point(256, 24);
            lblSoonToExpire.Name = "lblSoonToExpire";
            lblSoonToExpire.Size = new Size(235, 21);
            lblSoonToExpire.TabIndex = 1;
            lblSoonToExpire.Text = "Proximos a Expirar Entre:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAllEmployees);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(948, 436);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Todos los Empleados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAllEmployees
            // 
            dgvAllEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEmployees.Dock = DockStyle.Fill;
            dgvAllEmployees.Location = new Point(3, 3);
            dgvAllEmployees.Name = "dgvAllEmployees";
            dgvAllEmployees.RowTemplate.Height = 25;
            dgvAllEmployees.Size = new Size(942, 430);
            dgvAllEmployees.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 488);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL TOTAL INGENIERIA";
            ((System.ComponentModel.ISupportInitialize)dgvExpiringCertEmp).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExpiringCertEmp;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem plantasToolStripMenuItem;
        private ToolStripMenuItem dC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3ToolStripMenuItem;
        private ToolStripMenuItem editarDC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3AEmpleadoToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvAllEmployees;
        private Label lblSoonToExpire;
    }
}