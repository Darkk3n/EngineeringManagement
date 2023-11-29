namespace EngineeringManagement.UI.Forms
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            CmbEmployees = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtName = new TextBox();
            TxtPosition = new TextBox();
            TxtCurp = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            CmbEmployeeType = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            BtnPicture = new Button();
            pbEmpPhoto = new PictureBox();
            label7 = new Label();
            LblLabsFileName = new Label();
            label9 = new Label();
            BtnLabsFile = new Button();
            BtnSisositFile = new Button();
            LblSisositFileName = new Label();
            BtnViewLabs = new Button();
            BtnViewSisosit = new Button();
            errors = new ErrorProvider(components);
            fileDialogLabs = new OpenFileDialog();
            fileDialogSisosit = new OpenFileDialog();
            fileDialogPicture = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // CmbEmployees
            // 
            CmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployees.FormattingEnabled = true;
            CmbEmployees.Location = new Point(119, 432);
            CmbEmployees.Name = "CmbEmployees";
            CmbEmployees.Size = new Size(223, 23);
            CmbEmployees.TabIndex = 0;
            CmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 436);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 473);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 511);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Puesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 549);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "CURP:";
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(119, 469);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(224, 23);
            TxtName.TabIndex = 7;
            TxtName.Validating += TxtName_Validating;
            // 
            // TxtPosition
            // 
            TxtPosition.Enabled = false;
            TxtPosition.Location = new Point(119, 507);
            TxtPosition.Name = "TxtPosition";
            TxtPosition.Size = new Size(224, 23);
            TxtPosition.TabIndex = 8;
            TxtPosition.Validating += TxtPosition_Validating;
            // 
            // TxtCurp
            // 
            TxtCurp.Enabled = false;
            TxtCurp.Location = new Point(119, 545);
            TxtCurp.Name = "TxtCurp";
            TxtCurp.Size = new Size(224, 23);
            TxtCurp.TabIndex = 9;
            TxtCurp.Validating += TxtCurp_Validating;
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(119, 774);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 5;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(215, 774);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CmbEmployeeType
            // 
            CmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployeeType.Enabled = false;
            CmbEmployeeType.FormattingEnabled = true;
            CmbEmployeeType.Location = new Point(119, 582);
            CmbEmployeeType.Name = "CmbEmployeeType";
            CmbEmployeeType.Size = new Size(224, 23);
            CmbEmployeeType.TabIndex = 10;
            CmbEmployeeType.Validating += CmbEmployeeType_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 586);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo de Empleado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 397);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 12;
            label6.Text = "Foto:";
            // 
            // BtnPicture
            // 
            BtnPicture.Enabled = false;
            BtnPicture.Location = new Point(119, 393);
            BtnPicture.Name = "BtnPicture";
            BtnPicture.Size = new Size(224, 23);
            BtnPicture.TabIndex = 13;
            BtnPicture.Text = "Seleccionar Archivo...";
            BtnPicture.UseVisualStyleBackColor = true;
            BtnPicture.Click += BtnPicture_Click;
            // 
            // pbEmpPhoto
            // 
            pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbEmpPhoto.Location = new Point(12, 0);
            pbEmpPhoto.Name = "pbEmpPhoto";
            pbEmpPhoto.Size = new Size(384, 384);
            pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmpPhoto.TabIndex = 14;
            pbEmpPhoto.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 624);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 15;
            label7.Text = "Laboratorios:";
            // 
            // LblLabsFileName
            // 
            LblLabsFileName.AutoSize = true;
            LblLabsFileName.Location = new Point(119, 659);
            LblLabsFileName.Name = "LblLabsFileName";
            LblLabsFileName.Size = new Size(170, 15);
            LblLabsFileName.TabIndex = 16;
            LblLabsFileName.Text = "Ningun archivo seleccionado...";
            LblLabsFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 694);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 17;
            label9.Text = "SISOSIT:";
            // 
            // BtnLabsFile
            // 
            BtnLabsFile.Enabled = false;
            BtnLabsFile.Location = new Point(119, 620);
            BtnLabsFile.Name = "BtnLabsFile";
            BtnLabsFile.Size = new Size(224, 23);
            BtnLabsFile.TabIndex = 18;
            BtnLabsFile.Text = "Seleccionar Archivo...";
            BtnLabsFile.UseVisualStyleBackColor = true;
            BtnLabsFile.Click += BtnLabsFile_Click;
            // 
            // BtnSisositFile
            // 
            BtnSisositFile.Enabled = false;
            BtnSisositFile.Location = new Point(119, 690);
            BtnSisositFile.Name = "BtnSisositFile";
            BtnSisositFile.Size = new Size(224, 23);
            BtnSisositFile.TabIndex = 19;
            BtnSisositFile.Text = "Seleccionar Archivo..";
            BtnSisositFile.UseVisualStyleBackColor = true;
            BtnSisositFile.Click += BtnSisositFile_Click;
            // 
            // LblSisositFileName
            // 
            LblSisositFileName.AutoSize = true;
            LblSisositFileName.Location = new Point(119, 732);
            LblSisositFileName.Name = "LblSisositFileName";
            LblSisositFileName.Size = new Size(170, 15);
            LblSisositFileName.TabIndex = 20;
            LblSisositFileName.Text = "Ningun archivo seleccionado...";
            LblSisositFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnViewLabs
            // 
            BtnViewLabs.Enabled = false;
            BtnViewLabs.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewLabs.Location = new Point(349, 620);
            BtnViewLabs.Name = "BtnViewLabs";
            BtnViewLabs.Size = new Size(42, 25);
            BtnViewLabs.TabIndex = 21;
            BtnViewLabs.UseVisualStyleBackColor = true;
            BtnViewLabs.Click += BtnViewLabs_Click;
            // 
            // BtnViewSisosit
            // 
            BtnViewSisosit.Enabled = false;
            BtnViewSisosit.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewSisosit.Location = new Point(349, 690);
            BtnViewSisosit.Name = "BtnViewSisosit";
            BtnViewSisosit.Size = new Size(42, 25);
            BtnViewSisosit.TabIndex = 22;
            BtnViewSisosit.UseVisualStyleBackColor = true;
            BtnViewSisosit.Click += BtnViewSisosit_Click;
            // 
            // errors
            // 
            errors.ContainerControl = this;
            // 
            // fileDialogLabs
            // 
            fileDialogLabs.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialogLabs.InitialDirectory = "C:\\";
            fileDialogLabs.Title = "Seleccionar Laboratorios";
            // 
            // fileDialogSisosit
            // 
            fileDialogSisosit.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialogSisosit.InitialDirectory = "C:\\";
            // 
            // fileDialogPicture
            // 
            fileDialogPicture.Filter = "Archivos de Imagen (*.png, *.jpg, *.jpeg) | *.png ;*.jpg;*.jpeg";
            fileDialogPicture.InitialDirectory = "C:\\";
            // 
            // EditEmployee
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            CancelButton = BtnCancel;
            ClientSize = new Size(405, 806);
            Controls.Add(pbEmpPhoto);
            Controls.Add(CmbEmployees);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(BtnCancel);
            Controls.Add(label3);
            Controls.Add(BtnOk);
            Controls.Add(label4);
            Controls.Add(BtnPicture);
            Controls.Add(TxtName);
            Controls.Add(BtnViewSisosit);
            Controls.Add(TxtPosition);
            Controls.Add(BtnViewLabs);
            Controls.Add(TxtCurp);
            Controls.Add(LblSisositFileName);
            Controls.Add(CmbEmployeeType);
            Controls.Add(BtnSisositFile);
            Controls.Add(label5);
            Controls.Add(BtnLabsFile);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(LblLabsFileName);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Empleado";
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CmbEmployees;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtName;
        private TextBox TxtPosition;
        private TextBox TxtCurp;
        private Button BtnOk;
        private Button BtnCancel;
        private ComboBox CmbEmployeeType;
        private Label label5;
        private ErrorProvider errors;
        private Label label6;
        private Button BtnPicture;
        private PictureBox pbEmpPhoto;
        private Label label7;
        private Label LblLabsFileName;
        private Label label9;
        private Button BtnLabsFile;
        private Button BtnSisositFile;
        private Label LblSisositFileName;
        private OpenFileDialog fileDialogLabs;
        private OpenFileDialog fileDialogSisosit;
        private OpenFileDialog fileDialogPicture;
        private Button BtnViewLabs;
        private Button BtnViewSisosit;
    }
}