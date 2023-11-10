namespace EngineeringManagement.UI.Forms.Certifications
{
    partial class EditEmployeeCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeCertification));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblFileName = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnViewFile = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            BtnCancel = new Button();
            LblEmployeeName = new Label();
            LblCertName = new Label();
            BtnOk = new Button();
            BtnOpenFile = new Button();
            fileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "DC-3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 123);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Documento:";
            // 
            // LblFileName
            // 
            LblFileName.AutoSize = true;
            LblFileName.Location = new Point(133, 181);
            LblFileName.Name = "LblFileName";
            LblFileName.Size = new Size(209, 20);
            LblFileName.TabIndex = 3;
            LblFileName.Text = "Ningun archivo seleccionado...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 251);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 251);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Vencimiento:";
            // 
            // BtnViewFile
            // 
            BtnViewFile.Enabled = false;
            BtnViewFile.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewFile.Location = new Point(471, 175);
            BtnViewFile.Margin = new Padding(3, 4, 3, 4);
            BtnViewFile.Name = "BtnViewFile";
            BtnViewFile.Size = new Size(37, 33);
            BtnViewFile.TabIndex = 9;
            BtnViewFile.UseVisualStyleBackColor = true;
            BtnViewFile.Click += BtnViewFile_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(143, 243);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(101, 27);
            dtpStartDate.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(402, 243);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(105, 27);
            dtpEndDate.TabIndex = 11;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(270, 316);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(86, 31);
            BtnCancel.TabIndex = 13;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblEmployeeName
            // 
            LblEmployeeName.AutoSize = true;
            LblEmployeeName.Location = new Point(133, 27);
            LblEmployeeName.Name = "LblEmployeeName";
            LblEmployeeName.Size = new Size(50, 20);
            LblEmployeeName.TabIndex = 14;
            LblEmployeeName.Text = "label7";
            // 
            // LblCertName
            // 
            LblCertName.AutoSize = true;
            LblCertName.Location = new Point(133, 72);
            LblCertName.Name = "LblCertName";
            LblCertName.Size = new Size(50, 20);
            LblCertName.TabIndex = 15;
            LblCertName.Text = "label8";
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(159, 316);
            BtnOk.Margin = new Padding(3, 4, 3, 4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(86, 31);
            BtnOk.TabIndex = 16;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.Location = new Point(133, 117);
            BtnOpenFile.Margin = new Padding(3, 4, 3, 4);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(162, 31);
            BtnOpenFile.TabIndex = 17;
            BtnOpenFile.Text = "Seleccionar Archivo...";
            BtnOpenFile.UseVisualStyleBackColor = true;
            BtnOpenFile.Click += BtnOpenFile_Click;
            // 
            // fileDialog
            // 
            fileDialog.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Title = "Seleccionar DC-3";
            // 
            // EditEmployeeCertification
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(543, 377);
            Controls.Add(BtnOpenFile);
            Controls.Add(BtnOk);
            Controls.Add(LblCertName);
            Controls.Add(LblEmployeeName);
            Controls.Add(BtnCancel);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(BtnViewFile);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LblFileName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployeeCertification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar DC-3 de Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblFileName;
        private Label label5;
        private Label label6;
        private Button BtnViewFile;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button BtnCancel;
        private Label LblEmployeeName;
        private Label LblCertName;
        private Button BtnOk;
        private Button BtnOpenFile;
        private OpenFileDialog fileDialog;
    }
}