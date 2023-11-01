namespace EngineeringManagement.UI.Forms
{
    partial class AddCertificaction
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
            TxtCertName = new TextBox();
            TxtCertDesc = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.2364578F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.7635422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(TxtCertName, 1, 0);
            tableLayoutPanel1.Controls.Add(TxtCertDesc, 1, 1);
            tableLayoutPanel1.Controls.Add(BtnOk, 0, 2);
            tableLayoutPanel1.Controls.Add(BtnCancel, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.8823547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1176453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new Size(307, 154);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(90, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(72, 67);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // TxtCertName
            // 
            TxtCertName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCertName.Location = new Point(150, 15);
            TxtCertName.Name = "TxtCertName";
            TxtCertName.Size = new Size(124, 23);
            TxtCertName.TabIndex = 2;
            // 
            // TxtCertDesc
            // 
            TxtCertDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCertDesc.Location = new Point(150, 63);
            TxtCertDesc.Name = "TxtCertDesc";
            TxtCertDesc.Size = new Size(124, 23);
            TxtCertDesc.TabIndex = 3;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Right;
            BtnOk.Location = new Point(69, 113);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Left;
            BtnCancel.Location = new Point(150, 113);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // AddCertificaction
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(307, 154);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCertificaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar DC-3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox TxtCertName;
        private TextBox TxtCertDesc;
        private Button BtnOk;
        private Button BtnCancel;
    }
}