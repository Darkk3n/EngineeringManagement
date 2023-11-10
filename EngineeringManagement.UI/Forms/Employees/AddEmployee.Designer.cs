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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 291F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.Size = new Size(498, 745);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(164, 357);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(175, 407);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Puesto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(183, 450);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "CURP:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(237, 354);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 27);
            txtName.TabIndex = 5;
            txtName.Validating += txtName_Validating;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPosition.Location = new Point(237, 403);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(233, 27);
            txtPosition.TabIndex = 6;
            txtPosition.Validating += txtPosition_Validating;
            // 
            // txtCurp
            // 
            txtCurp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurp.Location = new Point(237, 446);
            txtCurp.Margin = new Padding(3, 4, 3, 4);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(233, 27);
            txtCurp.TabIndex = 7;
            txtCurp.Validating += txtCurp_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(96, 494);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 8;
            label4.Text = "Tipo de Empleado:";
            // 
            // cmbEmployeeType
            // 
            cmbEmployeeType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployeeType.FormattingEnabled = true;
            cmbEmployeeType.Location = new Point(237, 490);
            cmbEmployeeType.Margin = new Padding(3, 4, 3, 4);
            cmbEmployeeType.Name = "cmbEmployeeType";
            cmbEmployeeType.Size = new Size(233, 28);
            cmbEmployeeType.TabIndex = 9;
            cmbEmployeeType.Validating += cmbEmployeeType_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(135, 540);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 10;
            label5.Text = "Laboratorios:";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnOpenFile.Location = new Point(237, 534);
            btnOpenFile.Margin = new Padding(3, 4, 3, 4);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(233, 31);
            btnOpenFile.TabIndex = 11;
            btnOpenFile.Text = "Seleccionar Archivo...";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lblSelectedLabsFile
            // 
            lblSelectedLabsFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedLabsFile.AutoSize = true;
            lblSelectedLabsFile.Location = new Point(237, 587);
            lblSelectedLabsFile.Name = "lblSelectedLabsFile";
            lblSelectedLabsFile.Size = new Size(233, 20);
            lblSelectedLabsFile.TabIndex = 12;
            lblSelectedLabsFile.Text = "No se ha seleccionado archivo...";
            lblSelectedLabsFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(168, 634);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 13;
            label6.Text = "SISOSIT:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 708);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOk.Location = new Point(145, 708);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 31);
            btnOk.TabIndex = 3;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblSisositFile
            // 
            lblSisositFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSisositFile.AutoSize = true;
            lblSisositFile.Location = new Point(237, 675);
            lblSisositFile.Name = "lblSisositFile";
            lblSisositFile.Size = new Size(233, 20);
            lblSisositFile.TabIndex = 14;
            lblSisositFile.Text = "No se ha seleccionado archivo...";
            lblSisositFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSisositOpenFile
            // 
            btnSisositOpenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSisositOpenFile.Location = new Point(237, 629);
            btnSisositOpenFile.Margin = new Padding(3, 4, 3, 4);
            btnSisositOpenFile.Name = "btnSisositOpenFile";
            btnSisositOpenFile.Size = new Size(233, 31);
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
            pbEmpPhoto.Location = new Point(3, 4);
            pbEmpPhoto.Margin = new Padding(3, 4, 3, 4);
            pbEmpPhoto.Name = "pbEmpPhoto";
            pbEmpPhoto.Size = new Size(492, 283);
            pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmpPhoto.TabIndex = 16;
            pbEmpPhoto.TabStop = false;
            // 
            // btnPicture
            // 
            btnPicture.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPicture.Location = new Point(237, 300);
            btnPicture.Margin = new Padding(3, 4, 3, 4);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(233, 31);
            btnPicture.TabIndex = 17;
            btnPicture.Text = "Seleccionar Archivo...";
            btnPicture.UseVisualStyleBackColor = true;
            btnPicture.Click += btnPicture_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(189, 305);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(498, 745);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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