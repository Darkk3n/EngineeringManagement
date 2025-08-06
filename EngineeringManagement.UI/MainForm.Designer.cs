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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            editarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            expedientesMedicosToolStripMenuItem = new ToolStripMenuItem();
            generarContratoToolStripMenuItem = new ToolStripMenuItem();
            plantasToolStripMenuItem = new ToolStripMenuItem();
            agregarPlantaToolStripMenuItem = new ToolStripMenuItem();
            editarPlantaToolStripMenuItem = new ToolStripMenuItem();
            dC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3ToolStripMenuItem = new ToolStripMenuItem();
            editarDC3ToolStripMenuItem = new ToolStripMenuItem();
            agregarDC3AEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            cmbEmployees = new ComboBox();
            dgvEmployeeList = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            BtnExport = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            generarAlcanceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, empleadosToolStripMenuItem, plantasToolStripMenuItem, dC3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1093, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(73, 24);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, editarEmpleadoToolStripMenuItem, expedientesMedicosToolStripMenuItem, generarContratoToolStripMenuItem, generarAlcanceToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(97, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(232, 26);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            editarEmpleadoToolStripMenuItem.Size = new Size(232, 26);
            editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            editarEmpleadoToolStripMenuItem.Click += editarEmpleadoToolStripMenuItem_Click;
            // 
            // expedientesMedicosToolStripMenuItem
            // 
            expedientesMedicosToolStripMenuItem.Name = "expedientesMedicosToolStripMenuItem";
            expedientesMedicosToolStripMenuItem.Size = new Size(232, 26);
            expedientesMedicosToolStripMenuItem.Text = "Expedientes Medicos";
            expedientesMedicosToolStripMenuItem.Click += expedientesMedicosToolStripMenuItem_Click;
            // 
            // generarContratoToolStripMenuItem
            // 
            generarContratoToolStripMenuItem.Name = "generarContratoToolStripMenuItem";
            generarContratoToolStripMenuItem.Size = new Size(232, 26);
            generarContratoToolStripMenuItem.Text = "Generar Contrato";
            // 
            // plantasToolStripMenuItem
            // 
            plantasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPlantaToolStripMenuItem, editarPlantaToolStripMenuItem });
            plantasToolStripMenuItem.Name = "plantasToolStripMenuItem";
            plantasToolStripMenuItem.Size = new Size(70, 24);
            plantasToolStripMenuItem.Text = "Plantas";
            // 
            // agregarPlantaToolStripMenuItem
            // 
            agregarPlantaToolStripMenuItem.Name = "agregarPlantaToolStripMenuItem";
            agregarPlantaToolStripMenuItem.Size = new Size(191, 26);
            agregarPlantaToolStripMenuItem.Text = "Agregar Planta";
            agregarPlantaToolStripMenuItem.Click += agregarPlantaToolStripMenuItem_Click;
            // 
            // editarPlantaToolStripMenuItem
            // 
            editarPlantaToolStripMenuItem.Name = "editarPlantaToolStripMenuItem";
            editarPlantaToolStripMenuItem.Size = new Size(191, 26);
            editarPlantaToolStripMenuItem.Text = "Editar Planta";
            editarPlantaToolStripMenuItem.Click += editarPlantaToolStripMenuItem_Click;
            // 
            // dC3ToolStripMenuItem
            // 
            dC3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarDC3ToolStripMenuItem, editarDC3ToolStripMenuItem, agregarDC3AEmpleadoToolStripMenuItem });
            dC3ToolStripMenuItem.Name = "dC3ToolStripMenuItem";
            dC3ToolStripMenuItem.Size = new Size(57, 24);
            dC3ToolStripMenuItem.Text = "DC-3";
            // 
            // agregarDC3ToolStripMenuItem
            // 
            agregarDC3ToolStripMenuItem.Name = "agregarDC3ToolStripMenuItem";
            agregarDC3ToolStripMenuItem.Size = new Size(268, 26);
            agregarDC3ToolStripMenuItem.Text = "Agregar DC-3";
            agregarDC3ToolStripMenuItem.Click += agregarDC3ToolStripMenuItem_Click;
            // 
            // editarDC3ToolStripMenuItem
            // 
            editarDC3ToolStripMenuItem.Name = "editarDC3ToolStripMenuItem";
            editarDC3ToolStripMenuItem.Size = new Size(268, 26);
            editarDC3ToolStripMenuItem.Text = "Editar DC-3";
            editarDC3ToolStripMenuItem.Click += editarDC3ToolStripMenuItem_Click;
            // 
            // agregarDC3AEmpleadoToolStripMenuItem
            // 
            agregarDC3AEmpleadoToolStripMenuItem.Name = "agregarDC3AEmpleadoToolStripMenuItem";
            agregarDC3AEmpleadoToolStripMenuItem.Size = new Size(268, 26);
            agregarDC3AEmpleadoToolStripMenuItem.Text = "Agregar DC-3 a Empleado";
            agregarDC3AEmpleadoToolStripMenuItem.Click += agregarDC3AEmpleadoToolStripMenuItem_Click;
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(14, 40);
            cmbEmployees.Margin = new Padding(3, 4, 3, 4);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(367, 28);
            cmbEmployees.TabIndex = 2;
            cmbEmployees.SelectedIndexChanged += cmbEmployees_SelectedIndexChanged;
            cmbEmployees.TextChanged += cmbEmployees_TextChanged;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AllowUserToAddRows = false;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Dock = DockStyle.Fill;
            dgvEmployeeList.Location = new Point(0, 0);
            dgvEmployeeList.Margin = new Padding(3, 4, 3, 4);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersWidth = 51;
            dgvEmployeeList.Size = new Size(1093, 736);
            dgvEmployeeList.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312__1_;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(457, 25);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 57);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar/Editar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.vcsconflicting_93497__1_;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(592, 27);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 57);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 6;
            label1.Text = "Empleados:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 30);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnExport);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(btnClear);
            splitContainer1.Panel1.Controls.Add(cmbEmployees);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvEmployeeList);
            splitContainer1.Size = new Size(1093, 837);
            splitContainer1.SplitterDistance = 96;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 7;
            // 
            // BtnExport
            // 
            BtnExport.Location = new Point(687, 27);
            BtnExport.Margin = new Padding(3, 4, 3, 4);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(88, 57);
            BtnExport.TabIndex = 9;
            BtnExport.Text = "Exportar a Excel";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.Lupa_Icon__2_;
            btnSearch.Location = new Point(389, 39);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 32);
            btnSearch.TabIndex = 8;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(782, 25);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 57);
            btnClear.TabIndex = 7;
            btnClear.Text = "Anular Seleccion";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // generarAlcanceToolStripMenuItem
            // 
            generarAlcanceToolStripMenuItem.Name = "generarAlcanceToolStripMenuItem";
            generarAlcanceToolStripMenuItem.Size = new Size(232, 26);
            generarAlcanceToolStripMenuItem.Text = "Generar Alcance";
            generarAlcanceToolStripMenuItem.Click += generarAlcanceToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 867);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL TOTAL INGENIERIA";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem plantasToolStripMenuItem;
        private ToolStripMenuItem dC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3ToolStripMenuItem;
        private ToolStripMenuItem editarDC3ToolStripMenuItem;
        private ToolStripMenuItem agregarDC3AEmpleadoToolStripMenuItem;
        private ToolStripMenuItem agregarPlantaToolStripMenuItem;
        private ToolStripMenuItem editarPlantaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem expedientesMedicosToolStripMenuItem;
      private ComboBox cmbEmployees;
      private DataGridView dgvEmployeeList;
      private Button btnAdd;
      private Button btnDelete;
      private Label label1;
      private SplitContainer splitContainer1;
      private Button btnClear;
      private Button btnSearch;
        private ToolStripMenuItem generarContratoToolStripMenuItem;
        private Button BtnExport;
        private ToolStripMenuItem generarAlcanceToolStripMenuItem;
    }
}