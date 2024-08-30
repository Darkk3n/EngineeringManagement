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
         menuStrip1.SuspendLayout();
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
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(956, 488);
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
    }
}