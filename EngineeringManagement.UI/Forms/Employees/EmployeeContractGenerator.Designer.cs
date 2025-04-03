namespace EngineeringManagement.UI.Forms.Employees
{
    partial class EmployeeContractGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeContractGenerator));
            label1 = new Label();
            cmbEmployees = new ComboBox();
            BtnCreate = new Button();
            BtnCancel = new Button();
            label2 = new Label();
            TxtPosition = new TextBox();
            label3 = new Label();
            CmbGender = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            CmbMaritalStatus = new ComboBox();
            label12 = new Label();
            TxtCurp = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            MtxtRfc = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(322, 35);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(161, 23);
            cmbEmployees.TabIndex = 1;
            // 
            // BtnCreate
            // 
            BtnCreate.Location = new Point(520, 395);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(75, 23);
            BtnCreate.TabIndex = 2;
            BtnCreate.Text = "Generar";
            BtnCreate.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(601, 395);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Puesto:";
            // 
            // TxtPosition
            // 
            TxtPosition.Location = new Point(322, 74);
            TxtPosition.Name = "TxtPosition";
            TxtPosition.Size = new Size(161, 23);
            TxtPosition.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 107);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Sexo:";
            // 
            // CmbGender
            // 
            CmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGender.FormattingEnabled = true;
            CmbGender.Items.AddRange(new object[] { "Masculino", "Femenino" });
            CmbGender.Location = new Point(331, 112);
            CmbGender.Name = "CmbGender";
            CmbGender.Size = new Size(160, 23);
            CmbGender.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "Estado Civil:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 173);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "CURP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 213);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "RFC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 267);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 11;
            label7.Text = "Direccion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 461);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 12;
            label8.Text = "Duracion del Contrato:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 426);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 13;
            label9.Text = "Fechad de Contrato:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 341);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 14;
            label10.Text = "Actividades:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 383);
            label11.Name = "label11";
            label11.Size = new Size(178, 15);
            label11.TabIndex = 15;
            label11.Text = "Obra Determinada Denominada:";
            // 
            // CmbMaritalStatus
            // 
            CmbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMaritalStatus.FormattingEnabled = true;
            CmbMaritalStatus.Items.AddRange(new object[] { "--SELECCIONE--", "Soltero", "Casado", "Divorciado", "Viudo" });
            CmbMaritalStatus.Location = new Point(331, 152);
            CmbMaritalStatus.Name = "CmbMaritalStatus";
            CmbMaritalStatus.Size = new Size(152, 23);
            CmbMaritalStatus.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 503);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 17;
            label12.Text = "Empresa:";
            // 
            // TxtCurp
            // 
            TxtCurp.Location = new Point(274, 181);
            TxtCurp.Name = "TxtCurp";
            TxtCurp.Size = new Size(175, 23);
            TxtCurp.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 264);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 58);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 337);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            // 
            // MtxtRfc
            // 
            MtxtRfc.Location = new Point(204, 213);
            MtxtRfc.Name = "MtxtRfc";
            MtxtRfc.Size = new Size(100, 23);
            MtxtRfc.TabIndex = 21;
            // 
            // EmployeeContractGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 775);
            Controls.Add(MtxtRfc);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(TxtCurp);
            Controls.Add(label12);
            Controls.Add(CmbMaritalStatus);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CmbGender);
            Controls.Add(label3);
            Controls.Add(TxtPosition);
            Controls.Add(label2);
            Controls.Add(BtnCancel);
            Controls.Add(BtnCreate);
            Controls.Add(cmbEmployees);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeContractGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados - Generador de Contrato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEmployees;
        private Button BtnCreate;
        private Button BtnCancel;
        private Label label2;
        private TextBox TxtPosition;
        private Label label3;
        private ComboBox CmbGender;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox CmbMaritalStatus;
        private Label label12;
        private TextBox TxtCurp;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox MtxtRfc;
    }
}