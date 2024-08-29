namespace EngineeringManagement.UI.Forms
{
    partial class AddEmployee
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         txtName = new TextBox();
         txtPosition = new TextBox();
         txtCurp = new TextBox();
         label4 = new Label();
         cmbEmployeeType = new ComboBox();
         label5 = new Label();
         btnOpenFile = new Button();
         lblSelectedLabsFile = new Label();
         label6 = new Label();
         btnCancel = new Button();
         btnOk = new Button();
         lblSisositFile = new Label();
         btnSisositOpenFile = new Button();
         pbEmpPhoto = new PictureBox();
         btnPicture = new Button();
         label7 = new Label();
         errors = new ErrorProvider(components);
         fileDialog = new OpenFileDialog();
         fileDialogPicture = new OpenFileDialog();
         fileDialogSisosit = new OpenFileDialog();
         label8 = new Label();
         TxtNss = new MaskedTextBox();
         ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).BeginInit();
         ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(873, 12);
         label1.Name = "label1";
         label1.Size = new Size(54, 15);
         label1.TabIndex = 0;
         label1.Text = "Nombre:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(873, 53);
         label2.Name = "label2";
         label2.Size = new Size(46, 15);
         label2.TabIndex = 1;
         label2.Text = "Puesto:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(873, 86);
         label3.Name = "label3";
         label3.Size = new Size(40, 15);
         label3.TabIndex = 2;
         label3.Text = "CURP:";
         // 
         // txtName
         // 
         txtName.Location = new Point(983, 12);
         txtName.Name = "txtName";
         txtName.Size = new Size(202, 23);
         txtName.TabIndex = 5;
         txtName.Validating += txtName_Validating;
         // 
         // txtPosition
         // 
         txtPosition.Location = new Point(983, 53);
         txtPosition.Name = "txtPosition";
         txtPosition.Size = new Size(202, 23);
         txtPosition.TabIndex = 6;
         txtPosition.Validating += txtPosition_Validating;
         // 
         // txtCurp
         // 
         txtCurp.Location = new Point(983, 86);
         txtCurp.Name = "txtCurp";
         txtCurp.Size = new Size(202, 23);
         txtCurp.TabIndex = 7;
         txtCurp.Validating += txtCurp_Validating;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(873, 160);
         label4.Name = "label4";
         label4.Size = new Size(105, 15);
         label4.TabIndex = 8;
         label4.Text = "Tipo de Empleado:";
         // 
         // cmbEmployeeType
         // 
         cmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
         cmbEmployeeType.FormattingEnabled = true;
         cmbEmployeeType.Location = new Point(983, 160);
         cmbEmployeeType.Name = "cmbEmployeeType";
         cmbEmployeeType.Size = new Size(202, 23);
         cmbEmployeeType.TabIndex = 9;
         cmbEmployeeType.Validating += cmbEmployeeType_Validating;
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(873, 195);
         label5.Name = "label5";
         label5.Size = new Size(76, 15);
         label5.TabIndex = 10;
         label5.Text = "Laboratorios:";
         // 
         // btnOpenFile
         // 
         btnOpenFile.Location = new Point(983, 195);
         btnOpenFile.Name = "btnOpenFile";
         btnOpenFile.Size = new Size(202, 23);
         btnOpenFile.TabIndex = 11;
         btnOpenFile.Text = "Seleccionar Archivo...";
         btnOpenFile.UseVisualStyleBackColor = true;
         btnOpenFile.Click += btnOpenFile_Click;
         // 
         // lblSelectedLabsFile
         // 
         lblSelectedLabsFile.AutoSize = true;
         lblSelectedLabsFile.Location = new Point(983, 225);
         lblSelectedLabsFile.Name = "lblSelectedLabsFile";
         lblSelectedLabsFile.Size = new Size(176, 15);
         lblSelectedLabsFile.TabIndex = 12;
         lblSelectedLabsFile.Text = "No se ha seleccionado archivo...";
         lblSelectedLabsFile.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(873, 266);
         label6.Name = "label6";
         label6.Size = new Size(49, 15);
         label6.TabIndex = 13;
         label6.Text = "SISOSIT:";
         // 
         // btnCancel
         // 
         btnCancel.Location = new Point(1065, 341);
         btnCancel.Name = "btnCancel";
         btnCancel.Size = new Size(75, 23);
         btnCancel.TabIndex = 4;
         btnCancel.Text = "Cancelar";
         btnCancel.UseVisualStyleBackColor = true;
         btnCancel.Click += btnCancel_Click;
         // 
         // btnOk
         // 
         btnOk.Location = new Point(983, 341);
         btnOk.Name = "btnOk";
         btnOk.Size = new Size(75, 23);
         btnOk.TabIndex = 3;
         btnOk.Text = "Guardar";
         btnOk.UseVisualStyleBackColor = true;
         btnOk.Click += btnOk_Click;
         // 
         // lblSisositFile
         // 
         lblSisositFile.AutoSize = true;
         lblSisositFile.Location = new Point(983, 297);
         lblSisositFile.Name = "lblSisositFile";
         lblSisositFile.Size = new Size(176, 15);
         lblSisositFile.TabIndex = 14;
         lblSisositFile.Text = "No se ha seleccionado archivo...";
         lblSisositFile.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // btnSisositOpenFile
         // 
         btnSisositOpenFile.Location = new Point(983, 266);
         btnSisositOpenFile.Name = "btnSisositOpenFile";
         btnSisositOpenFile.Size = new Size(202, 23);
         btnSisositOpenFile.TabIndex = 15;
         btnSisositOpenFile.Text = "Seleccionar Archivo...";
         btnSisositOpenFile.UseVisualStyleBackColor = true;
         btnSisositOpenFile.Click += btnSisositOpenFile_Click;
         // 
         // pbEmpPhoto
         // 
         pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
         pbEmpPhoto.Location = new Point(145, 12);
         pbEmpPhoto.Name = "pbEmpPhoto";
         pbEmpPhoto.Size = new Size(639, 632);
         pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
         pbEmpPhoto.TabIndex = 16;
         pbEmpPhoto.TabStop = false;
         // 
         // btnPicture
         // 
         btnPicture.Location = new Point(376, 669);
         btnPicture.Name = "btnPicture";
         btnPicture.Size = new Size(202, 23);
         btnPicture.TabIndex = 17;
         btnPicture.Text = "Seleccionar Archivo...";
         btnPicture.UseVisualStyleBackColor = true;
         btnPicture.Click += btnPicture_Click;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(318, 669);
         label7.Name = "label7";
         label7.Size = new Size(34, 15);
         label7.TabIndex = 18;
         label7.Text = "Foto:";
         // 
         // errors
         // 
         errors.ContainerControl = this;
         // 
         // fileDialog
         // 
         fileDialog.Filter = "PDF files (*.pdf) | *.pdf";
         fileDialog.InitialDirectory = "C:\\";
         fileDialog.Tag = "";
         fileDialog.Title = "Seleccionar Laboratorios";
         // 
         // fileDialogPicture
         // 
         fileDialogPicture.Filter = "Archivos de Imagen (*.png, *.jpg, *.jpeg) | *.png ;*.jpg;*.jpeg";
         fileDialogPicture.InitialDirectory = "C:\\";
         // 
         // fileDialogSisosit
         // 
         fileDialogSisosit.Filter = "PDF files (*.pdf) | *.pdf";
         fileDialogSisosit.InitialDirectory = "C:\\";
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new Point(873, 128);
         label8.Name = "label8";
         label8.Size = new Size(31, 15);
         label8.TabIndex = 19;
         label8.Text = "NSS:";
         // 
         // TxtNss
         // 
         TxtNss.Location = new Point(983, 125);
         TxtNss.Mask = "00000000000";
         TxtNss.Name = "TxtNss";
         TxtNss.Size = new Size(202, 23);
         TxtNss.TabIndex = 8;
         TxtNss.ValidatingType = typeof(int);
         // 
         // AddEmployee
         // 
         AcceptButton = btnOk;
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         AutoScroll = true;
         CancelButton = btnCancel;
         ClientSize = new Size(1479, 718);
         Controls.Add(TxtNss);
         Controls.Add(label8);
         Controls.Add(label1);
         Controls.Add(label2);
         Controls.Add(pbEmpPhoto);
         Controls.Add(label3);
         Controls.Add(lblSisositFile);
         Controls.Add(txtName);
         Controls.Add(label7);
         Controls.Add(txtPosition);
         Controls.Add(btnPicture);
         Controls.Add(txtCurp);
         Controls.Add(btnSisositOpenFile);
         Controls.Add(label4);
         Controls.Add(btnOk);
         Controls.Add(cmbEmployeeType);
         Controls.Add(btnCancel);
         Controls.Add(label5);
         Controls.Add(label6);
         Controls.Add(btnOpenFile);
         Controls.Add(lblSelectedLabsFile);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         Icon = (Icon)resources.GetObject("$this.Icon");
         MinimizeBox = false;
         Name = "AddEmployee";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Agregar Empleado";
         WindowState = FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).EndInit();
         ((System.ComponentModel.ISupportInitialize)errors).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtPosition;
        private TextBox txtCurp;
        private Label label4;
        private ComboBox cmbEmployeeType;
        private ErrorProvider errors;
        private Label label5;
        private OpenFileDialog fileDialog;
        private Button btnOpenFile;
        private Label lblSelectedLabsFile;
        private Label label6;
        private Label lblSisositFile;
        private Button btnSisositOpenFile;
        private PictureBox pbEmpPhoto;
        private Button btnPicture;
        private Label label7;
        private OpenFileDialog fileDialogPicture;
        private OpenFileDialog fileDialogSisosit;
        private Label label8;
        private MaskedTextBox TxtNss;
    }
}