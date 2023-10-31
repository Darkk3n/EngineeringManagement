namespace EngineeringManagement.UI.Forms.Employees
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
            errors = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.1279449F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.8720551F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(CmbEmployees, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(TxtName, 1, 1);
            tableLayoutPanel1.Controls.Add(TxtPosition, 1, 2);
            tableLayoutPanel1.Controls.Add(TxtCurp, 1, 3);
            tableLayoutPanel1.Controls.Add(BtnOk, 0, 5);
            tableLayoutPanel1.Controls.Add(BtnCancel, 1, 5);
            tableLayoutPanel1.Controls.Add(CmbEmployeeType, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.71901F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.28099F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(407, 349);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CmbEmployees
            // 
            CmbEmployees.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployees.FormattingEnabled = true;
            CmbEmployees.Location = new Point(181, 19);
            CmbEmployees.Name = "CmbEmployees";
            CmbEmployees.Size = new Size(202, 23);
            CmbEmployees.TabIndex = 0;
            CmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(121, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(129, 139);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Puesto:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(135, 200);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "CURP:";
            // 
            // TxtName
            // 
            TxtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtName.Enabled = false;
            TxtName.Location = new Point(181, 75);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(202, 23);
            TxtName.TabIndex = 7;
            TxtName.Validating += TxtName_Validating;
            // 
            // TxtPosition
            // 
            TxtPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPosition.Enabled = false;
            TxtPosition.Location = new Point(181, 135);
            TxtPosition.Name = "TxtPosition";
            TxtPosition.Size = new Size(202, 23);
            TxtPosition.TabIndex = 8;
            TxtPosition.Validating += TxtPosition_Validating;
            // 
            // TxtCurp
            // 
            TxtCurp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCurp.Enabled = false;
            TxtCurp.Location = new Point(181, 196);
            TxtCurp.Name = "TxtCurp";
            TxtCurp.Size = new Size(202, 23);
            TxtCurp.TabIndex = 9;
            TxtCurp.Validating += TxtCurp_Validating;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Right;
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(100, 310);
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
            BtnCancel.Location = new Point(181, 310);
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
            CmbEmployeeType.Location = new Point(181, 253);
            CmbEmployeeType.Name = "CmbEmployeeType";
            CmbEmployeeType.Size = new Size(202, 23);
            CmbEmployeeType.TabIndex = 10;
            CmbEmployeeType.Validating += CmbEmployeeType_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(70, 257);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo de Empleado:";
            // 
            // errors
            // 
            errors.ContainerControl = this;
            // 
            // EditEmployee
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(407, 349);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Empleado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
    }
}