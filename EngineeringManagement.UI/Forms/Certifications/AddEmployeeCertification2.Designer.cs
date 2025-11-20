namespace EngineeringManagement.UI.Forms.Certifications
{
    partial class AddEmployeeCertification2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeCertification2));
            label1 = new Label();
            CmbEmployees = new ComboBox();
            label2 = new Label();
            BtnOk = new Button();
            BtnCancelar = new Button();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
            CmbCertifications = new ComboBox();
            label5 = new Label();
            BtnCertFile = new Button();
            fileDialog = new OpenFileDialog();
            LblFileName = new Label();
            BtnViewCert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // CmbEmployees
            // 
            CmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployees.FormattingEnabled = true;
            CmbEmployees.Location = new Point(115, 20);
            CmbEmployees.Name = "CmbEmployees";
            CmbEmployees.Size = new Size(299, 23);
            CmbEmployees.TabIndex = 1;
            CmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "DC-3:";
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(146, 228);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 9;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(227, 228);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label3
            // 
            label3.Location = new Point(58, 169);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 11;
            label3.Text = "Fecha de Inicio:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(115, 170);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(94, 23);
            dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(311, 170);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(87, 23);
            dtpEndDate.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(227, 170);
            label4.Name = "label4";
            label4.Size = new Size(80, 36);
            label4.TabIndex = 14;
            label4.Text = "Fecha de Vencimiento:";
            // 
            // CmbCertifications
            // 
            CmbCertifications.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCertifications.Enabled = false;
            CmbCertifications.FormattingEnabled = true;
            CmbCertifications.Location = new Point(115, 64);
            CmbCertifications.Name = "CmbCertifications";
            CmbCertifications.Size = new Size(299, 23);
            CmbCertifications.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 109);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 16;
            label5.Text = "Documento:";
            // 
            // BtnCertFile
            // 
            BtnCertFile.Location = new Point(115, 105);
            BtnCertFile.Name = "BtnCertFile";
            BtnCertFile.Size = new Size(133, 23);
            BtnCertFile.TabIndex = 17;
            BtnCertFile.Text = "Seleccionar Archivo...";
            BtnCertFile.UseVisualStyleBackColor = true;
            BtnCertFile.Click += BtnCertFile_Click;
            // 
            // fileDialog
            // 
            fileDialog.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Title = "Seleccionar DC-3";
            // 
            // LblFileName
            // 
            LblFileName.AutoSize = true;
            LblFileName.Location = new Point(115, 143);
            LblFileName.Name = "LblFileName";
            LblFileName.Size = new Size(170, 15);
            LblFileName.TabIndex = 18;
            LblFileName.Text = "Ningun archivo seleccionado...";
            // 
            // BtnViewCert
            // 
            BtnViewCert.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewCert.Location = new Point(384, 135);
            BtnViewCert.Name = "BtnViewCert";
            BtnViewCert.Size = new Size(30, 29);
            BtnViewCert.TabIndex = 19;
            BtnViewCert.UseVisualStyleBackColor = true;
            BtnViewCert.Click += BtnViewCert_Click;
            // 
            // AddEmployeeCertification2
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = BtnCancelar;
            ClientSize = new Size(428, 260);
            Controls.Add(BtnViewCert);
            Controls.Add(LblFileName);
            Controls.Add(BtnCertFile);
            Controls.Add(label5);
            Controls.Add(CmbCertifications);
            Controls.Add(label4);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(label2);
            Controls.Add(CmbEmployees);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployeeCertification2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar DC-3 a Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CmbEmployees;
        private Label label2;
        private Button BtnOk;
        private Button BtnCancelar;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private ComboBox CmbCertifications;
        private Label label5;
        private Button BtnCertFile;
        private OpenFileDialog fileDialog;
        private Label LblFileName;
        private Button BtnViewCert;
    }
}