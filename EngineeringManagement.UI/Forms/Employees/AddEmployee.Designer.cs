namespace EngineeringManagement.UI.Forms.Employees
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
            btnOk = new Button();
            btnCancel = new Button();
            label4 = new Label();
            cmbEmployeeType = new ComboBox();
            errors = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.2337646F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.7662354F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPosition, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCurp, 1, 2);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(cmbEmployeeType, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.727272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.818182F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(342, 193);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(70, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(78, 44);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Puesto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(84, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "CURP:";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(130, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 5;
            txtName.Validating += txtName_Validating;
            // 
            // txtPosition
            // 
            txtPosition.Dock = DockStyle.Fill;
            txtPosition.Location = new Point(130, 38);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(175, 23);
            txtPosition.TabIndex = 6;
            txtPosition.Validating += txtPosition_Validating;
            // 
            // txtCurp
            // 
            txtCurp.Dock = DockStyle.Fill;
            txtCurp.Location = new Point(130, 72);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(175, 23);
            txtCurp.TabIndex = 7;
            txtCurp.Validating += txtCurp_Validating;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOk.Location = new Point(49, 146);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(130, 146);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(19, 117);
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
            cmbEmployeeType.Location = new Point(130, 110);
            cmbEmployeeType.Name = "cmbEmployeeType";
            cmbEmployeeType.Size = new Size(175, 23);
            cmbEmployeeType.TabIndex = 9;
            cmbEmployeeType.Validating += cmbEmployeeType_Validating;
            // 
            // errors
            // 
            errors.ContainerControl = this;
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
    }
}