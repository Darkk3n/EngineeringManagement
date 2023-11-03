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
            btnCancel = new Button();
            btnOk = new Button();
            label5 = new Label();
            btnOpenFile = new Button();
            errors = new ErrorProvider(components);
            fileDialog = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.3677826F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.6322174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPosition, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCurp, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(cmbEmployeeType, 1, 3);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 5);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(btnOpenFile, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.727272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.818182F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(342, 193);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(112, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(120, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Puesto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(126, 65);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "CURP:";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(172, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 5;
            txtName.Validating += txtName_Validating;
            // 
            // txtPosition
            // 
            txtPosition.Dock = DockStyle.Fill;
            txtPosition.Location = new Point(172, 32);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(154, 23);
            txtPosition.TabIndex = 6;
            txtPosition.Validating += txtPosition_Validating;
            // 
            // txtCurp
            // 
            txtCurp.Dock = DockStyle.Fill;
            txtCurp.Location = new Point(172, 60);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(154, 23);
            txtCurp.TabIndex = 7;
            txtCurp.Validating += txtCurp_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(61, 98);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 8;
            label4.Text = "Tipo de Empleado:";
            // 
            // cmbEmployeeType
            // 
            cmbEmployeeType.Dock = DockStyle.Fill;
            cmbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployeeType.FormattingEnabled = true;
            cmbEmployeeType.Location = new Point(172, 91);
            cmbEmployeeType.Name = "cmbEmployeeType";
            cmbEmployeeType.Size = new Size(154, 23);
            cmbEmployeeType.TabIndex = 9;
            cmbEmployeeType.Validating += cmbEmployeeType_Validating;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 163);
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
            btnOk.Location = new Point(91, 163);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(90, 134);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "Laboratorios:";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnOpenFile.Location = new Point(172, 130);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(154, 23);
            btnOpenFile.TabIndex = 11;
            btnOpenFile.Text = "Seleccionar Archivo...";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // errors
            // 
            errors.ContainerControl = this;
            // 
            // fileDialog
            // 
            fileDialog.DefaultExt = "txt";
            fileDialog.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.RestoreDirectory = true;
            fileDialog.Tag = "";
            fileDialog.Title = "Seleccionar Laboratorios";
            // 
            // AddEmployee
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(342, 193);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Empleado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
    }
}