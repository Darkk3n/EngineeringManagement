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
            tableLayoutPanel1 = new TableLayoutPanel();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.42365F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.576355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(CmbEmployees, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(TxtName, 1, 3);
            tableLayoutPanel1.Controls.Add(TxtPosition, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtCurp, 1, 5);
            tableLayoutPanel1.Controls.Add(BtnOk, 0, 11);
            tableLayoutPanel1.Controls.Add(BtnCancel, 1, 11);
            tableLayoutPanel1.Controls.Add(CmbEmployeeType, 1, 6);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnPicture, 1, 1);
            tableLayoutPanel1.Controls.Add(pbEmpPhoto, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 7);
            tableLayoutPanel1.Controls.Add(LblLabsFileName, 1, 8);
            tableLayoutPanel1.Controls.Add(label9, 0, 9);
            tableLayoutPanel1.Controls.Add(BtnLabsFile, 1, 7);
            tableLayoutPanel1.Controls.Add(BtnSisositFile, 1, 9);
            tableLayoutPanel1.Controls.Add(LblSisositFileName, 1, 10);
            tableLayoutPanel1.Controls.Add(BtnViewLabs, 2, 8);
            tableLayoutPanel1.Controls.Add(BtnViewSisosit, 2, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 290F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(444, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CmbEmployees
            // 
            CmbEmployees.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployees.FormattingEnabled = true;
            CmbEmployees.Location = new Point(155, 338);
            CmbEmployees.Name = "CmbEmployees";
            CmbEmployees.Size = new Size(239, 23);
            CmbEmployees.TabIndex = 0;
            CmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(86, 342);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(95, 382);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(103, 423);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Puesto:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(109, 463);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "CURP:";
            // 
            // TxtName
            // 
            TxtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtName.Enabled = false;
            TxtName.Location = new Point(155, 378);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(239, 23);
            TxtName.TabIndex = 7;
            TxtName.Validating += TxtName_Validating;
            // 
            // TxtPosition
            // 
            TxtPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPosition.Enabled = false;
            TxtPosition.Location = new Point(155, 419);
            TxtPosition.Name = "TxtPosition";
            TxtPosition.Size = new Size(239, 23);
            TxtPosition.TabIndex = 8;
            TxtPosition.Validating += TxtPosition_Validating;
            // 
            // TxtCurp
            // 
            TxtCurp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCurp.Enabled = false;
            TxtCurp.Location = new Point(155, 459);
            TxtCurp.Name = "TxtCurp";
            TxtCurp.Size = new Size(239, 23);
            TxtCurp.TabIndex = 9;
            TxtCurp.Validating += TxtCurp_Validating;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Right;
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(74, 690);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 5;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Left;
            BtnCancel.Location = new Point(155, 690);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CmbEmployeeType
            // 
            CmbEmployeeType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployeeType.Enabled = false;
            CmbEmployeeType.FormattingEnabled = true;
            CmbEmployeeType.Location = new Point(155, 497);
            CmbEmployeeType.Name = "CmbEmployeeType";
            CmbEmployeeType.Size = new Size(239, 23);
            CmbEmployeeType.TabIndex = 10;
            CmbEmployeeType.Validating += CmbEmployeeType_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(44, 501);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo de Empleado:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(115, 303);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 12;
            label6.Text = "Foto:";
            // 
            // BtnPicture
            // 
            BtnPicture.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnPicture.Enabled = false;
            BtnPicture.Location = new Point(155, 299);
            BtnPicture.Name = "BtnPicture";
            BtnPicture.Size = new Size(239, 23);
            BtnPicture.TabIndex = 13;
            BtnPicture.Text = "Seleccionar Archivo...";
            BtnPicture.UseVisualStyleBackColor = true;
            BtnPicture.Click += BtnPicture_Click;
            // 
            // pbEmpPhoto
            // 
            pbEmpPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbEmpPhoto.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(pbEmpPhoto, 3);
            pbEmpPhoto.Location = new Point(3, 3);
            pbEmpPhoto.Name = "pbEmpPhoto";
            pbEmpPhoto.Size = new Size(438, 284);
            pbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmpPhoto.TabIndex = 14;
            pbEmpPhoto.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(73, 535);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 15;
            label7.Text = "Laboratorios:";
            // 
            // LblLabsFileName
            // 
            LblLabsFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblLabsFileName.AutoSize = true;
            LblLabsFileName.Location = new Point(155, 569);
            LblLabsFileName.Name = "LblLabsFileName";
            LblLabsFileName.Size = new Size(239, 15);
            LblLabsFileName.TabIndex = 16;
            LblLabsFileName.Text = "Ningun archivo seleccionado...";
            LblLabsFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(100, 609);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 17;
            label9.Text = "SISOSIT:";
            // 
            // BtnLabsFile
            // 
            BtnLabsFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnLabsFile.Enabled = false;
            BtnLabsFile.Location = new Point(155, 531);
            BtnLabsFile.Name = "BtnLabsFile";
            BtnLabsFile.Size = new Size(239, 23);
            BtnLabsFile.TabIndex = 18;
            BtnLabsFile.Text = "Seleccionar Archivo...";
            BtnLabsFile.UseVisualStyleBackColor = true;
            BtnLabsFile.Click += BtnLabsFile_Click;
            // 
            // BtnSisositFile
            // 
            BtnSisositFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnSisositFile.Enabled = false;
            BtnSisositFile.Location = new Point(155, 605);
            BtnSisositFile.Name = "BtnSisositFile";
            BtnSisositFile.Size = new Size(239, 23);
            BtnSisositFile.TabIndex = 19;
            BtnSisositFile.Text = "Seleccionar Archivo..";
            BtnSisositFile.UseVisualStyleBackColor = true;
            BtnSisositFile.Click += BtnSisositFile_Click;
            // 
            // LblSisositFileName
            // 
            LblSisositFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblSisositFileName.AutoSize = true;
            LblSisositFileName.Location = new Point(155, 648);
            LblSisositFileName.Name = "LblSisositFileName";
            LblSisositFileName.Size = new Size(239, 15);
            LblSisositFileName.TabIndex = 20;
            LblSisositFileName.Text = "Ningun archivo seleccionado...";
            LblSisositFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnViewLabs
            // 
            BtnViewLabs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnViewLabs.Enabled = false;
            BtnViewLabs.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewLabs.Location = new Point(400, 562);
            BtnViewLabs.Name = "BtnViewLabs";
            BtnViewLabs.Size = new Size(41, 30);
            BtnViewLabs.TabIndex = 21;
            BtnViewLabs.UseVisualStyleBackColor = true;
            BtnViewLabs.Click += BtnViewLabs_Click;
            // 
            // BtnViewSisosit
            // 
            BtnViewSisosit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnViewSisosit.Enabled = false;
            BtnViewSisosit.Image = Properties.Resources.Lupa_Icon__2_;
            BtnViewSisosit.Location = new Point(400, 641);
            BtnViewSisosit.Name = "BtnViewSisosit";
            BtnViewSisosit.Size = new Size(41, 30);
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
            CancelButton = BtnCancel;
            ClientSize = new Size(444, 729);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Empleado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmpPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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