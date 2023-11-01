namespace EngineeringManagement.UI.Forms.Certifications
{
    partial class EditCertification
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CmbCertifications = new ComboBox();
            TxtCertName = new TextBox();
            TxtCertDesc = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2380943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.7619F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CmbCertifications, 1, 0);
            tableLayoutPanel1.Controls.Add(TxtCertName, 1, 1);
            tableLayoutPanel1.Controls.Add(TxtCertDesc, 1, 2);
            tableLayoutPanel1.Controls.Add(BtnOk, 0, 3);
            tableLayoutPanel1.Controls.Add(BtnCancel, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.22034F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.77966F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.Size = new Size(420, 194);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(108, 6);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "DC-3:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(91, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(73, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // CmbCertifications
            // 
            CmbCertifications.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbCertifications.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCertifications.FormattingEnabled = true;
            CmbCertifications.Location = new Point(151, 3);
            CmbCertifications.Name = "CmbCertifications";
            CmbCertifications.Size = new Size(266, 23);
            CmbCertifications.TabIndex = 3;
            CmbCertifications.SelectedIndexChanged += CmbCertifications_SelectedIndexChanged;
            // 
            // TxtCertName
            // 
            TxtCertName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCertName.Enabled = false;
            TxtCertName.Location = new Point(151, 35);
            TxtCertName.Name = "TxtCertName";
            TxtCertName.Size = new Size(266, 23);
            TxtCertName.TabIndex = 4;
            // 
            // TxtCertDesc
            // 
            TxtCertDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCertDesc.Enabled = false;
            TxtCertDesc.Location = new Point(151, 69);
            TxtCertDesc.Multiline = true;
            TxtCertDesc.Name = "TxtCertDesc";
            TxtCertDesc.Size = new Size(266, 78);
            TxtCertDesc.TabIndex = 5;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Right;
            BtnOk.Location = new Point(70, 160);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Left;
            BtnCancel.Location = new Point(151, 160);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // EditCertification
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(420, 194);
            Controls.Add(tableLayoutPanel1);
            Name = "EditCertification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar DC-3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CmbCertifications;
        private TextBox TxtCertName;
        private TextBox TxtCertDesc;
        private Button BtnOk;
        private Button BtnCancel;
    }
}