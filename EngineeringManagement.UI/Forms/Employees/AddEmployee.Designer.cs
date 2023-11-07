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
            tableLayoutPanel1 = new TableLayoutPanel();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4717F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txtName, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPosition, 1, 3);
            tableLayoutPanel1.Controls.Add(txtCurp, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbEmployeeType, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(btnOpenFile, 1, 6);
            tableLayoutPanel1.Controls.Add(lblSelectedLabsFile, 1, 7);
            tableLayoutPanel1.Controls.Add(label6, 0, 8);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 10);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 10);
            tableLayoutPanel1.Controls.Add(lblSisositFile, 1, 9);
            tableLayoutPanel1.Controls.Add(btnSisositOpenFile, 1, 8);
            tableLayoutPanel1.Controls.Add(pbEmpPhoto, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPicture, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Size = new Size(436, 690);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(149, 344);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(157, 385);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Puesto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(163, 423);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "CURP:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(209, 340);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 5;
            txtName.Validating += txtName_Validating;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPosition.Location = new Point(209, 381);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(203, 23);
            txtPosition.TabIndex = 6;
            txtPosition.Validating += txtPosition_Validating;
            // 
            // txtCurp
            // 
            txtCurp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurp.Location = new Point(209, 419);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(203, 23);
            txtCurp.TabIndex = 7;
            txtCurp.Validating += txtCurp_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(98, 462);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 8;
            label4.Text = "Tipo de Empleado:";
            // 
            // cmbEmployeeType
            // 
            cmbEmployeeType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployeeType.FormattingEnabled = true;
            cmbEmployeeType.Location = new Point(209, 458);
            cmbEmployeeType.Name = "cmbEmployeeType";
            cmbEmployeeType.Size = new Size(203, 23);
            cmbEmployeeType.TabIndex = 9;
            cmbEmployeeType.Validating += cmbEmployeeType_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(127, 503);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "Laboratorios:";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnOpenFile.Location = new Point(209, 499);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(203, 23);
            btnOpenFile.TabIndex = 11;
            btnOpenFile.Text = "Seleccionar Archivo...";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lblSelectedLabsFile
            // 
            lblSelectedLabsFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedLabsFile.AutoSize = true;
            lblSelectedLabsFile.Location = new Point(209, 538);
            lblSelectedLabsFile.Name = "lblSelectedLabsFile";
            lblSelectedLabsFile.Size = new Size(203, 15);
            lblSelectedLabsFile.TabIndex = 12;
            lblSelectedLabsFile.Text = "No se ha seleccionado archivo...";
            lblSelectedLabsFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(154, 583);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "SISOSIT:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(209, 653);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOk.Location = new Point(128, 653);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblSisositFile
            // 
            lblSisositFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSisositFile.AutoSize = true;
            lblSisositFile.Location = new Point(209, 628);
            lblSisositFile.Name = "lblSisositFile";
            lblSisositFile.Size = new Size(203, 15);
            lblSisositFile.TabIndex = 14;
            lblSisositFile.Text = "No se ha seleccionado archivo...";
            lblSisositFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSisositOpenFile
            // 
            btnSisositOpenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSisositOpenFile.Location = new Point(209, 579);
            btnSisositOpenFile.Name = "btnSisositOpenFile";
            btnSisositOpenFile.Size = new Size(203, 23);
            btnSisositOpenFile.TabIndex = 15;
            btnSisositOpenFile.Text = "Seleccionar Archivo...";
            btnSisositOpenFile.UseVisualStyleBackColor = true;
            btnSisositOpenFile.Click += btnSisositOpenFile_Click;
            // 
            // pbEmpPhoto
            // 
            pbEmpPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(pbEmpPhoto, 3);
            pbEmpPhoto.Location = new Point(3, 3);
            pbEmpPhoto.Name = "pbEmpPhoto";
            pbEmpPhoto.Size = new Size(430, 290);
            pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmpPhoto.TabIndex = 16;
            pbEmpPhoto.TabStop = false;
            // 
            // btnPicture
            // 
            btnPicture.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPicture.Location = new Point(209, 302);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(203, 23);
            btnPicture.TabIndex = 17;
            btnPicture.Text = "Seleccionar Archivo...";
            btnPicture.UseVisualStyleBackColor = true;
            btnPicture.Click += btnPicture_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(169, 306);
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
            // AddEmployee
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(436, 690);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Empleado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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
    }
}