namespace EngineeringManagement.UI.Forms.Certifications
{
    partial class AddEmployeeCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeCertification));
            label1 = new Label();
            CmbEmployees = new ComboBox();
            label2 = new Label();
            lbUnassignedCert = new ListBox();
            lbAssignedCert = new ListBox();
            BtnRemove = new Button();
            BtnRemoveAll = new Button();
            BtnAdd = new Button();
            BtnAddAll = new Button();
            BtnOk = new Button();
            BtnCancelar = new Button();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
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
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Certificacion(es):";
            // 
            // lbUnassignedCert
            // 
            lbUnassignedCert.Enabled = false;
            lbUnassignedCert.FormattingEnabled = true;
            lbUnassignedCert.ItemHeight = 15;
            lbUnassignedCert.Location = new Point(115, 68);
            lbUnassignedCert.Name = "lbUnassignedCert";
            lbUnassignedCert.SelectionMode = SelectionMode.MultiSimple;
            lbUnassignedCert.Size = new Size(283, 109);
            lbUnassignedCert.TabIndex = 3;
            // 
            // lbAssignedCert
            // 
            lbAssignedCert.Enabled = false;
            lbAssignedCert.FormattingEnabled = true;
            lbAssignedCert.ItemHeight = 15;
            lbAssignedCert.Location = new Point(457, 68);
            lbAssignedCert.Name = "lbAssignedCert";
            lbAssignedCert.SelectionMode = SelectionMode.MultiSimple;
            lbAssignedCert.Size = new Size(283, 109);
            lbAssignedCert.TabIndex = 4;
            // 
            // BtnRemove
            // 
            BtnRemove.Enabled = false;
            BtnRemove.Location = new Point(413, 68);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(38, 23);
            BtnRemove.TabIndex = 5;
            BtnRemove.Text = "<";
            BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveAll
            // 
            BtnRemoveAll.Enabled = false;
            BtnRemoveAll.Location = new Point(413, 97);
            BtnRemoveAll.Name = "BtnRemoveAll";
            BtnRemoveAll.Size = new Size(38, 23);
            BtnRemoveAll.TabIndex = 6;
            BtnRemoveAll.Text = "<<";
            BtnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Enabled = false;
            BtnAdd.Location = new Point(413, 126);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(38, 23);
            BtnAdd.TabIndex = 7;
            BtnAdd.Text = ">";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnAddAll
            // 
            BtnAddAll.Enabled = false;
            BtnAddAll.Location = new Point(413, 154);
            BtnAddAll.Name = "BtnAddAll";
            BtnAddAll.Size = new Size(38, 23);
            BtnAddAll.TabIndex = 8;
            BtnAddAll.Text = ">>";
            BtnAddAll.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(320, 254);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 9;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(401, 254);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label3
            // 
            label3.Location = new Point(232, 195);
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
            dtpStartDate.Location = new Point(301, 195);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(94, 23);
            dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(487, 196);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(87, 23);
            dtpEndDate.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(401, 196);
            label4.Name = "label4";
            label4.Size = new Size(80, 36);
            label4.TabIndex = 14;
            label4.Text = "Fecha de Vencimiento:";
            // 
            // AddEmployeeCertification
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = BtnCancelar;
            ClientSize = new Size(751, 287);
            Controls.Add(label4);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(BtnAddAll);
            Controls.Add(BtnAdd);
            Controls.Add(BtnRemoveAll);
            Controls.Add(BtnRemove);
            Controls.Add(lbAssignedCert);
            Controls.Add(lbUnassignedCert);
            Controls.Add(label2);
            Controls.Add(CmbEmployees);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployeeCertification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar DC-3 a Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CmbEmployees;
        private Label label2;
        private ListBox lbUnassignedCert;
        private ListBox lbAssignedCert;
        private Button BtnRemove;
        private Button BtnRemoveAll;
        private Button BtnAdd;
        private Button BtnAddAll;
        private Button BtnOk;
        private Button BtnCancelar;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label4;
    }
}