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
         btnSearch = new Button();
         btnClear = new Button();
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
         menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, empleadosToolStripMenuItem, plantasToolStripMenuItem, dC3ToolStripMenuItem });
         menuStrip1.Location = new Point(0, 0);
         menuStrip1.Name = "menuStrip1";
         menuStrip1.Size = new Size(956, 24);
         menuStrip1.TabIndex = 1;
         menuStrip1.Text = "menuStrip1";
         // 
         // toolStripMenuItem1
         // 
         toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
         toolStripMenuItem1.Name = "toolStripMenuItem1";
         toolStripMenuItem1.Size = new Size(60, 20);
         toolStripMenuItem1.Text = "Archivo";
         // 
         // salirToolStripMenuItem
         // 
         salirToolStripMenuItem.Name = "salirToolStripMenuItem";
         salirToolStripMenuItem.Size = new Size(96, 22);
         salirToolStripMenuItem.Text = "Salir";
         salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
         // 
         // empleadosToolStripMenuItem
         // 
         empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, editarEmpleadoToolStripMenuItem, expedientesMedicosToolStripMenuItem });
         empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
         empleadosToolStripMenuItem.Size = new Size(77, 20);
         empleadosToolStripMenuItem.Text = "Empleados";
         // 
         // agregarEmpleadoToolStripMenuItem
         // 
         agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
         agregarEmpleadoToolStripMenuItem.Size = new Size(185, 22);
         agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
         agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
         // 
         // editarEmpleadoToolStripMenuItem
         // 
         editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
         editarEmpleadoToolStripMenuItem.Size = new Size(185, 22);
         editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
         editarEmpleadoToolStripMenuItem.Click += editarEmpleadoToolStripMenuItem_Click;
         // 
         // expedientesMedicosToolStripMenuItem
         // 
         expedientesMedicosToolStripMenuItem.Name = "expedientesMedicosToolStripMenuItem";
         expedientesMedicosToolStripMenuItem.Size = new Size(185, 22);
         expedientesMedicosToolStripMenuItem.Text = "Expedientes Medicos";
         expedientesMedicosToolStripMenuItem.Click += expedientesMedicosToolStripMenuItem_Click;
         // 
         // plantasToolStripMenuItem
         // 
         plantasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPlantaToolStripMenuItem, editarPlantaToolStripMenuItem });
         plantasToolStripMenuItem.Name = "plantasToolStripMenuItem";
         plantasToolStripMenuItem.Size = new Size(57, 20);
         plantasToolStripMenuItem.Text = "Plantas";
         // 
         // agregarPlantaToolStripMenuItem
         // 
         agregarPlantaToolStripMenuItem.Name = "agregarPlantaToolStripMenuItem";
         agregarPlantaToolStripMenuItem.Size = new Size(152, 22);
         agregarPlantaToolStripMenuItem.Text = "Agregar Planta";
         agregarPlantaToolStripMenuItem.Click += agregarPlantaToolStripMenuItem_Click;
         // 
         // editarPlantaToolStripMenuItem
         // 
         editarPlantaToolStripMenuItem.Name = "editarPlantaToolStripMenuItem";
         editarPlantaToolStripMenuItem.Size = new Size(152, 22);
         editarPlantaToolStripMenuItem.Text = "Editar Planta";
         editarPlantaToolStripMenuItem.Click += editarPlantaToolStripMenuItem_Click;
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
         agregarDC3ToolStripMenuItem.Click += agregarDC3ToolStripMenuItem_Click;
         // 
         // editarDC3ToolStripMenuItem
         // 
         editarDC3ToolStripMenuItem.Name = "editarDC3ToolStripMenuItem";
         editarDC3ToolStripMenuItem.Size = new Size(211, 22);
         editarDC3ToolStripMenuItem.Text = "Editar DC-3";
         editarDC3ToolStripMenuItem.Click += editarDC3ToolStripMenuItem_Click;
         // 
         // agregarDC3AEmpleadoToolStripMenuItem
         // 
         agregarDC3AEmpleadoToolStripMenuItem.Name = "agregarDC3AEmpleadoToolStripMenuItem";
         agregarDC3AEmpleadoToolStripMenuItem.Size = new Size(211, 22);
         agregarDC3AEmpleadoToolStripMenuItem.Text = "Agregar DC-3 a Empleado";
         agregarDC3AEmpleadoToolStripMenuItem.Click += agregarDC3AEmpleadoToolStripMenuItem_Click;
         // 
         // cmbEmployees
         // 
         cmbEmployees.FormattingEnabled = true;
         cmbEmployees.Location = new Point(12, 30);
         cmbEmployees.Name = "cmbEmployees";
         cmbEmployees.Size = new Size(322, 23);
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
         dgvEmployeeList.Name = "dgvEmployeeList";
         dgvEmployeeList.Size = new Size(956, 550);
         dgvEmployeeList.TabIndex = 3;
         // 
         // btnAdd
         // 
         btnAdd.Image = Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312__1_;
         btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
         btnAdd.Location = new Point(400, 19);
         btnAdd.Name = "btnAdd";
         btnAdd.Size = new Size(77, 43);
         btnAdd.TabIndex = 4;
         btnAdd.Text = "Agregar";
         btnAdd.TextAlign = ContentAlignment.MiddleRight;
         btnAdd.UseVisualStyleBackColor = true;
         btnAdd.Click += btnAdd_Click;
         // 
         // btnDelete
         // 
         btnDelete.Image = Properties.Resources.vcsconflicting_93497__1_;
         btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
         btnDelete.Location = new Point(483, 20);
         btnDelete.Name = "btnDelete";
         btnDelete.Size = new Size(77, 43);
         btnDelete.TabIndex = 5;
         btnDelete.Text = "Eliminar";
         btnDelete.TextAlign = ContentAlignment.MiddleRight;
         btnDelete.UseVisualStyleBackColor = true;
         btnDelete.Click += btnDelete_Click;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(12, 7);
         label1.Name = "label1";
         label1.Size = new Size(68, 15);
         label1.TabIndex = 6;
         label1.Text = "Empleados:";
         // 
         // splitContainer1
         // 
         splitContainer1.Dock = DockStyle.Fill;
         splitContainer1.Location = new Point(0, 24);
         splitContainer1.Name = "splitContainer1";
         splitContainer1.Orientation = Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
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
         splitContainer1.Size = new Size(956, 626);
         splitContainer1.SplitterDistance = 72;
         splitContainer1.TabIndex = 7;
         // 
         // btnSearch
         // 
         btnSearch.Image = Properties.Resources.Lupa_Icon__2_;
         btnSearch.Location = new Point(340, 29);
         btnSearch.Name = "btnSearch";
         btnSearch.Size = new Size(33, 24);
         btnSearch.TabIndex = 8;
         btnSearch.UseVisualStyleBackColor = true;
         btnSearch.Click += btnSearch_Click;
         // 
         // btnClear
         // 
         btnClear.Location = new Point(566, 19);
         btnClear.Name = "btnClear";
         btnClear.Size = new Size(77, 43);
         btnClear.TabIndex = 7;
         btnClear.Text = "Anular Seleccion";
         btnClear.UseVisualStyleBackColor = true;
         btnClear.Click += btnClear_Click;
         // 
         // MainForm
         // 
         AcceptButton = btnSearch;
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(956, 650);
         Controls.Add(splitContainer1);
         Controls.Add(menuStrip1);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         Icon = (Icon)resources.GetObject("$this.Icon");
         MainMenuStrip = menuStrip1;
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
   }
}