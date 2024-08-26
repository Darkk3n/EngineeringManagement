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
         label1.Location = new Point(1405, 147);
         label1.Margin = new Padding(6, 0, 6, 0);
         label1.Name = "label1";
         label1.Size = new Size(107, 32);
         label1.TabIndex = 0;
         label1.Text = "Nombre:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(1405, 234);
         label2.Margin = new Padding(6, 0, 6, 0);
         label2.Name = "label2";
         label2.Size = new Size(91, 32);
         label2.TabIndex = 1;
         label2.Text = "Puesto:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(1405, 305);
         label3.Margin = new Padding(6, 0, 6, 0);
         label3.Name = "label3";
         label3.Size = new Size(77, 32);
         label3.TabIndex = 2;
         label3.Text = "CURP:";
         // 
         // txtName
         // 
         txtName.Location = new Point(1611, 147);
         txtName.Margin = new Padding(6);
         txtName.Name = "txtName";
         txtName.Size = new Size(372, 39);
         txtName.TabIndex = 5;
         txtName.Validating += txtName_Validating;
         // 
         // txtPosition
         // 
         txtPosition.Location = new Point(1611, 234);
         txtPosition.Margin = new Padding(6);
         txtPosition.Name = "txtPosition";
         txtPosition.Size = new Size(372, 39);
         txtPosition.TabIndex = 6;
         txtPosition.Validating += txtPosition_Validating;
         // 
         // txtCurp
         // 
         txtCurp.Location = new Point(1611, 305);
         txtCurp.Margin = new Padding(6);
         txtCurp.Name = "txtCurp";
         txtCurp.Size = new Size(372, 39);
         txtCurp.TabIndex = 7;
         txtCurp.Validating += txtCurp_Validating;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(1405, 462);
         label4.Margin = new Padding(6, 0, 6, 0);
         label4.Name = "label4";
         label4.Size = new Size(213, 32);
         label4.TabIndex = 8;
         label4.Text = "Tipo de Empleado:";
         // 
         // cmbEmployeeType
         // 
         cmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
         cmbEmployeeType.FormattingEnabled = true;
         cmbEmployeeType.Location = new Point(1611, 462);
         cmbEmployeeType.Margin = new Padding(6);
         cmbEmployeeType.Name = "cmbEmployeeType";
         cmbEmployeeType.Size = new Size(372, 40);
         cmbEmployeeType.TabIndex = 9;
         cmbEmployeeType.Validating += cmbEmployeeType_Validating;
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(1405, 537);
         label5.Margin = new Padding(6, 0, 6, 0);
         label5.Name = "label5";
         label5.Size = new Size(150, 32);
         label5.TabIndex = 10;
         label5.Text = "Laboratorios:";
         // 
         // btnOpenFile
         // 
         btnOpenFile.Location = new Point(1611, 537);
         btnOpenFile.Margin = new Padding(6);
         btnOpenFile.Name = "btnOpenFile";
         btnOpenFile.Size = new Size(375, 49);
         btnOpenFile.TabIndex = 11;
         btnOpenFile.Text = "Seleccionar Archivo...";
         btnOpenFile.UseVisualStyleBackColor = true;
         btnOpenFile.Click += btnOpenFile_Click;
         // 
         // lblSelectedLabsFile
         // 
         lblSelectedLabsFile.AutoSize = true;
         lblSelectedLabsFile.Location = new Point(1611, 601);
         lblSelectedLabsFile.Margin = new Padding(6, 0, 6, 0);
         lblSelectedLabsFile.Name = "lblSelectedLabsFile";
         lblSelectedLabsFile.Size = new Size(353, 32);
         lblSelectedLabsFile.TabIndex = 12;
         lblSelectedLabsFile.Text = "No se ha seleccionado archivo...";
         lblSelectedLabsFile.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(1405, 689);
         label6.Margin = new Padding(6, 0, 6, 0);
         label6.Name = "label6";
         label6.Size = new Size(101, 32);
         label6.TabIndex = 13;
         label6.Text = "SISOSIT:";
         // 
         // btnCancel
         // 
         btnCancel.Location = new Point(1762, 849);
         btnCancel.Margin = new Padding(6);
         btnCancel.Name = "btnCancel";
         btnCancel.Size = new Size(139, 49);
         btnCancel.TabIndex = 4;
         btnCancel.Text = "Cancelar";
         btnCancel.UseVisualStyleBackColor = true;
         btnCancel.Click += btnCancel_Click;
         // 
         // btnOk
         // 
         btnOk.Location = new Point(1611, 849);
         btnOk.Margin = new Padding(6);
         btnOk.Name = "btnOk";
         btnOk.Size = new Size(139, 49);
         btnOk.TabIndex = 3;
         btnOk.Text = "Guardar";
         btnOk.UseVisualStyleBackColor = true;
         btnOk.Click += btnOk_Click;
         // 
         // lblSisositFile
         // 
         lblSisositFile.AutoSize = true;
         lblSisositFile.Location = new Point(1611, 755);
         lblSisositFile.Margin = new Padding(6, 0, 6, 0);
         lblSisositFile.Name = "lblSisositFile";
         lblSisositFile.Size = new Size(353, 32);
         lblSisositFile.TabIndex = 14;
         lblSisositFile.Text = "No se ha seleccionado archivo...";
         lblSisositFile.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // btnSisositOpenFile
         // 
         btnSisositOpenFile.Location = new Point(1611, 689);
         btnSisositOpenFile.Margin = new Padding(6);
         btnSisositOpenFile.Name = "btnSisositOpenFile";
         btnSisositOpenFile.Size = new Size(375, 49);
         btnSisositOpenFile.TabIndex = 15;
         btnSisositOpenFile.Text = "Seleccionar Archivo...";
         btnSisositOpenFile.UseVisualStyleBackColor = true;
         btnSisositOpenFile.Click += btnSisositOpenFile_Click;
         // 
         // pbEmpPhoto
         // 
         pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
         pbEmpPhoto.Location = new Point(253, 67);
         pbEmpPhoto.Margin = new Padding(6);
         pbEmpPhoto.Name = "pbEmpPhoto";
         pbEmpPhoto.Size = new Size(943, 943);
         pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
         pbEmpPhoto.TabIndex = 16;
         pbEmpPhoto.TabStop = false;
         // 
         // btnPicture
         // 
         btnPicture.Location = new Point(534, 1030);
         btnPicture.Margin = new Padding(6);
         btnPicture.Name = "btnPicture";
         btnPicture.Size = new Size(375, 49);
         btnPicture.TabIndex = 17;
         btnPicture.Text = "Seleccionar Archivo...";
         btnPicture.UseVisualStyleBackColor = true;
         btnPicture.Click += btnPicture_Click;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(428, 1030);
         label7.Margin = new Padding(6, 0, 6, 0);
         label7.Name = "label7";
         label7.Size = new Size(67, 32);
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
         label8.Location = new Point(1405, 394);
         label8.Margin = new Padding(6, 0, 6, 0);
         label8.Name = "label8";
         label8.Size = new Size(63, 32);
         label8.TabIndex = 19;
         label8.Text = "NSS:";
         // 
         // TxtNss
         // 
         TxtNss.Location = new Point(1611, 388);
         TxtNss.Margin = new Padding(6);
         TxtNss.Mask = "00000000000";
         TxtNss.Name = "TxtNss";
         TxtNss.Size = new Size(372, 39);
         TxtNss.TabIndex = 8;
         TxtNss.ValidatingType = typeof(int);
         // 
         // AddEmployee
         // 
         AcceptButton = btnOk;
         AutoScaleDimensions = new SizeF(13F, 32F);
         AutoScaleMode = AutoScaleMode.Font;
         AutoScroll = true;
         CancelButton = btnCancel;
         ClientSize = new Size(2425, 1195);
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
         Margin = new Padding(6);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "AddEmployee";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Agregar Empleado";
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