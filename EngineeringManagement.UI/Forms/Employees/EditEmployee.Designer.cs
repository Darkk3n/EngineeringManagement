﻿namespace EngineeringManagement.UI.Forms
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
         label8 = new Label();
         TxtNss = new MaskedTextBox();
         ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).BeginInit();
         ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
         SuspendLayout();
         // 
         // CmbEmployees
         // 
         CmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
         CmbEmployees.FormattingEnabled = true;
         CmbEmployees.Location = new Point(1214, 21);
         CmbEmployees.Margin = new Padding(6, 6, 6, 6);
         CmbEmployees.Name = "CmbEmployees";
         CmbEmployees.Size = new Size(411, 40);
         CmbEmployees.TabIndex = 0;
         CmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(1086, 29);
         label1.Margin = new Padding(6, 0, 6, 0);
         label1.Name = "label1";
         label1.Size = new Size(125, 32);
         label1.TabIndex = 1;
         label1.Text = "Empleado:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(1103, 108);
         label2.Margin = new Padding(6, 0, 6, 0);
         label2.Name = "label2";
         label2.Size = new Size(107, 32);
         label2.TabIndex = 2;
         label2.Text = "Nombre:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(1117, 189);
         label3.Margin = new Padding(6, 0, 6, 0);
         label3.Name = "label3";
         label3.Size = new Size(91, 32);
         label3.TabIndex = 3;
         label3.Text = "Puesto:";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(1129, 364);
         label4.Margin = new Padding(6, 0, 6, 0);
         label4.Name = "label4";
         label4.Size = new Size(77, 32);
         label4.TabIndex = 4;
         label4.Text = "CURP:";
         // 
         // TxtName
         // 
         TxtName.Enabled = false;
         TxtName.Location = new Point(1214, 100);
         TxtName.Margin = new Padding(6, 6, 6, 6);
         TxtName.Name = "TxtName";
         TxtName.Size = new Size(413, 39);
         TxtName.TabIndex = 7;
         TxtName.Validating += TxtName_Validating;
         // 
         // TxtPosition
         // 
         TxtPosition.Enabled = false;
         TxtPosition.Location = new Point(1214, 181);
         TxtPosition.Margin = new Padding(6, 6, 6, 6);
         TxtPosition.Name = "TxtPosition";
         TxtPosition.Size = new Size(413, 39);
         TxtPosition.TabIndex = 8;
         TxtPosition.Validating += TxtPosition_Validating;
         // 
         // TxtCurp
         // 
         TxtCurp.Enabled = false;
         TxtCurp.Location = new Point(1214, 356);
         TxtCurp.Margin = new Padding(6, 6, 6, 6);
         TxtCurp.Name = "TxtCurp";
         TxtCurp.Size = new Size(413, 39);
         TxtCurp.TabIndex = 9;
         TxtCurp.Validating += TxtCurp_Validating;
         // 
         // BtnOk
         // 
         BtnOk.Enabled = false;
         BtnOk.Location = new Point(1214, 844);
         BtnOk.Margin = new Padding(6, 6, 6, 6);
         BtnOk.Name = "BtnOk";
         BtnOk.Size = new Size(139, 49);
         BtnOk.TabIndex = 5;
         BtnOk.Text = "Guardar";
         BtnOk.UseVisualStyleBackColor = true;
         BtnOk.Click += BtnOk_Click;
         // 
         // BtnCancel
         // 
         BtnCancel.Location = new Point(1392, 844);
         BtnCancel.Margin = new Padding(6, 6, 6, 6);
         BtnCancel.Name = "BtnCancel";
         BtnCancel.Size = new Size(139, 49);
         BtnCancel.TabIndex = 6;
         BtnCancel.Text = "Cancelar";
         BtnCancel.UseVisualStyleBackColor = true;
         // 
         // CmbEmployeeType
         // 
         CmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
         CmbEmployeeType.Enabled = false;
         CmbEmployeeType.FormattingEnabled = true;
         CmbEmployeeType.Location = new Point(1214, 434);
         CmbEmployeeType.Margin = new Padding(6, 6, 6, 6);
         CmbEmployeeType.Name = "CmbEmployeeType";
         CmbEmployeeType.Size = new Size(413, 40);
         CmbEmployeeType.TabIndex = 10;
         CmbEmployeeType.Validating += CmbEmployeeType_Validating;
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(1008, 443);
         label5.Margin = new Padding(6, 0, 6, 0);
         label5.Name = "label5";
         label5.Size = new Size(213, 32);
         label5.TabIndex = 11;
         label5.Text = "Tipo de Empleado:";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(153, 1019);
         label6.Margin = new Padding(6, 0, 6, 0);
         label6.Name = "label6";
         label6.Size = new Size(67, 32);
         label6.TabIndex = 12;
         label6.Text = "Foto:";
         // 
         // BtnPicture
         // 
         BtnPicture.Enabled = false;
         BtnPicture.Location = new Point(227, 1010);
         BtnPicture.Margin = new Padding(6, 6, 6, 6);
         BtnPicture.Name = "BtnPicture";
         BtnPicture.Size = new Size(416, 49);
         BtnPicture.TabIndex = 13;
         BtnPicture.Text = "Seleccionar Archivo...";
         BtnPicture.UseVisualStyleBackColor = true;
         BtnPicture.Click += BtnPicture_Click;
         // 
         // pbEmpPhoto
         // 
         pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
         pbEmpPhoto.Location = new Point(15, 15);
         pbEmpPhoto.Margin = new Padding(6, 6, 6, 6);
         pbEmpPhoto.Name = "pbEmpPhoto";
         pbEmpPhoto.Size = new Size(943, 943);
         pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
         pbEmpPhoto.TabIndex = 14;
         pbEmpPhoto.TabStop = false;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(1062, 524);
         label7.Margin = new Padding(6, 0, 6, 0);
         label7.Name = "label7";
         label7.Size = new Size(150, 32);
         label7.TabIndex = 15;
         label7.Text = "Laboratorios:";
         // 
         // LblLabsFileName
         // 
         LblLabsFileName.AutoSize = true;
         LblLabsFileName.Location = new Point(1214, 599);
         LblLabsFileName.Margin = new Padding(6, 0, 6, 0);
         LblLabsFileName.Name = "LblLabsFileName";
         LblLabsFileName.Size = new Size(338, 32);
         LblLabsFileName.TabIndex = 16;
         LblLabsFileName.Text = "Ningun archivo seleccionado...";
         LblLabsFileName.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // label9
         // 
         label9.AutoSize = true;
         label9.Location = new Point(1112, 673);
         label9.Margin = new Padding(6, 0, 6, 0);
         label9.Name = "label9";
         label9.Size = new Size(101, 32);
         label9.TabIndex = 17;
         label9.Text = "SISOSIT:";
         // 
         // BtnLabsFile
         // 
         BtnLabsFile.Enabled = false;
         BtnLabsFile.Location = new Point(1214, 516);
         BtnLabsFile.Margin = new Padding(6, 6, 6, 6);
         BtnLabsFile.Name = "BtnLabsFile";
         BtnLabsFile.Size = new Size(416, 49);
         BtnLabsFile.TabIndex = 18;
         BtnLabsFile.Text = "Seleccionar Archivo...";
         BtnLabsFile.UseVisualStyleBackColor = true;
         BtnLabsFile.Click += BtnLabsFile_Click;
         // 
         // BtnSisositFile
         // 
         BtnSisositFile.Enabled = false;
         BtnSisositFile.Location = new Point(1214, 665);
         BtnSisositFile.Margin = new Padding(6, 6, 6, 6);
         BtnSisositFile.Name = "BtnSisositFile";
         BtnSisositFile.Size = new Size(416, 49);
         BtnSisositFile.TabIndex = 19;
         BtnSisositFile.Text = "Seleccionar Archivo..";
         BtnSisositFile.UseVisualStyleBackColor = true;
         BtnSisositFile.Click += BtnSisositFile_Click;
         // 
         // LblSisositFileName
         // 
         LblSisositFileName.AutoSize = true;
         LblSisositFileName.Location = new Point(1214, 754);
         LblSisositFileName.Margin = new Padding(6, 0, 6, 0);
         LblSisositFileName.Name = "LblSisositFileName";
         LblSisositFileName.Size = new Size(338, 32);
         LblSisositFileName.TabIndex = 20;
         LblSisositFileName.Text = "Ningun archivo seleccionado...";
         LblSisositFileName.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // BtnViewLabs
         // 
         BtnViewLabs.Enabled = false;
         BtnViewLabs.Image = Properties.Resources.Lupa_Icon__2_;
         BtnViewLabs.Location = new Point(1641, 516);
         BtnViewLabs.Margin = new Padding(6, 6, 6, 6);
         BtnViewLabs.Name = "BtnViewLabs";
         BtnViewLabs.Size = new Size(78, 53);
         BtnViewLabs.TabIndex = 21;
         BtnViewLabs.UseVisualStyleBackColor = true;
         BtnViewLabs.Click += BtnViewLabs_Click;
         // 
         // BtnViewSisosit
         // 
         BtnViewSisosit.Enabled = false;
         BtnViewSisosit.Image = Properties.Resources.Lupa_Icon__2_;
         BtnViewSisosit.Location = new Point(1641, 665);
         BtnViewSisosit.Margin = new Padding(6, 6, 6, 6);
         BtnViewSisosit.Name = "BtnViewSisosit";
         BtnViewSisosit.Size = new Size(78, 53);
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
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new Point(1145, 272);
         label8.Margin = new Padding(6, 0, 6, 0);
         label8.Name = "label8";
         label8.Size = new Size(63, 32);
         label8.TabIndex = 23;
         label8.Text = "NSS:";
         // 
         // TxtNss
         // 
         TxtNss.Location = new Point(1214, 266);
         TxtNss.Margin = new Padding(6, 6, 6, 6);
         TxtNss.Mask = "00000000000";
         TxtNss.Name = "TxtNss";
         TxtNss.Size = new Size(413, 39);
         TxtNss.TabIndex = 24;
         // 
         // EditEmployee
         // 
         AcceptButton = BtnOk;
         AutoScaleDimensions = new SizeF(13F, 32F);
         AutoScaleMode = AutoScaleMode.Font;
         AutoScroll = true;
         CancelButton = BtnCancel;
         ClientSize = new Size(1770, 1091);
         Controls.Add(TxtNss);
         Controls.Add(label8);
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
         Margin = new Padding(6, 6, 6, 6);
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
        private MaskedTextBox TxtNss;
        private Label label8;
    }
}