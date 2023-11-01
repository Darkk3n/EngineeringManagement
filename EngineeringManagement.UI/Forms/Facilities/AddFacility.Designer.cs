namespace EngineeringManagement.UI.Forms
{
    partial class AddFacility
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            TxtFacilityName = new TextBox();
            BtnOk = new Button();
            BtnCancelar = new Button();
            errors = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(TxtFacilityName, 1, 0);
            tableLayoutPanel1.Controls.Add(BtnOk, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnCancelar, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.75969F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.24031F));
            tableLayoutPanel1.Size = new Size(316, 85);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(101, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // TxtFacilityName
            // 
            TxtFacilityName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFacilityName.Location = new Point(161, 4);
            TxtFacilityName.Name = "TxtFacilityName";
            TxtFacilityName.Size = new Size(152, 23);
            TxtFacilityName.TabIndex = 1;
            TxtFacilityName.TextChanged += TxtFacilityName_TextChanged;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Right;
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(80, 47);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Left;
            BtnCancelar.Location = new Point(161, 47);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // errors
            // 
            errors.ContainerControl = this;
            // 
            // AddFacility
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelar;
            ClientSize = new Size(316, 85);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFacility";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Planta";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox TxtFacilityName;
        private Button BtnOk;
        private Button BtnCancelar;
        private ErrorProvider errors;
    }
}