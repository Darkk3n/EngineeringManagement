namespace EngineeringManagement.UI
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            plantasToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            editarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(956, 331);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, plantasToolStripMenuItem });
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
            // plantasToolStripMenuItem
            // 
            plantasToolStripMenuItem.Name = "plantasToolStripMenuItem";
            plantasToolStripMenuItem.Size = new Size(57, 20);
            plantasToolStripMenuItem.Text = "Plantas";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            editarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 488);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem plantasToolStripMenuItem;
    }
}