namespace EngineeringManagement.UI.Forms.Certifications
{
    partial class EditCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCertification));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CmbCertifications = new ComboBox();
            TxtCertName = new TextBox();
            TxtCertDesc = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            label4 = new Label();
            lbAllFacilities = new ListBox();
            lbAssignedFacilities = new ListBox();
            BtnRemove = new Button();
            BtnRemoveAll = new Button();
            BtnAdd = new Button();
            BtnAddAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "DC-3:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 148);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // CmbCertifications
            // 
            CmbCertifications.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCertifications.FormattingEnabled = true;
            CmbCertifications.Location = new Point(97, 19);
            CmbCertifications.Margin = new Padding(3, 4, 3, 4);
            CmbCertifications.Name = "CmbCertifications";
            CmbCertifications.Size = new Size(329, 28);
            CmbCertifications.TabIndex = 3;
            CmbCertifications.SelectedIndexChanged += CmbCertifications_SelectedIndexChanged;
            // 
            // TxtCertName
            // 
            TxtCertName.Enabled = false;
            TxtCertName.Location = new Point(97, 61);
            TxtCertName.Margin = new Padding(3, 4, 3, 4);
            TxtCertName.Name = "TxtCertName";
            TxtCertName.Size = new Size(329, 27);
            TxtCertName.TabIndex = 4;
            // 
            // TxtCertDesc
            // 
            TxtCertDesc.Enabled = false;
            TxtCertDesc.Location = new Point(97, 107);
            TxtCertDesc.Margin = new Padding(3, 4, 3, 4);
            TxtCertDesc.Multiline = true;
            TxtCertDesc.Name = "TxtCertDesc";
            TxtCertDesc.Size = new Size(329, 103);
            TxtCertDesc.TabIndex = 5;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(146, 395);
            BtnOk.Margin = new Padding(3, 4, 3, 4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(86, 31);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(239, 395);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(86, 31);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 236);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Planta(s):";
            // 
            // lbAllFacilities
            // 
            lbAllFacilities.Enabled = false;
            lbAllFacilities.FormattingEnabled = true;
            lbAllFacilities.ItemHeight = 20;
            lbAllFacilities.Location = new Point(97, 224);
            lbAllFacilities.Margin = new Padding(3, 4, 3, 4);
            lbAllFacilities.Name = "lbAllFacilities";
            lbAllFacilities.Size = new Size(137, 144);
            lbAllFacilities.TabIndex = 9;
            // 
            // lbAssignedFacilities
            // 
            lbAssignedFacilities.Enabled = false;
            lbAssignedFacilities.FormattingEnabled = true;
            lbAssignedFacilities.ItemHeight = 20;
            lbAssignedFacilities.Location = new Point(289, 224);
            lbAssignedFacilities.Margin = new Padding(3, 4, 3, 4);
            lbAssignedFacilities.Name = "lbAssignedFacilities";
            lbAssignedFacilities.Size = new Size(137, 144);
            lbAssignedFacilities.TabIndex = 10;
            // 
            // BtnRemove
            // 
            BtnRemove.Enabled = false;
            BtnRemove.Location = new Point(239, 225);
            BtnRemove.Margin = new Padding(3, 4, 3, 4);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(43, 31);
            BtnRemove.TabIndex = 11;
            BtnRemove.Text = "<";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnRemoveAll
            // 
            BtnRemoveAll.Enabled = false;
            BtnRemoveAll.Location = new Point(239, 264);
            BtnRemoveAll.Margin = new Padding(3, 4, 3, 4);
            BtnRemoveAll.Name = "BtnRemoveAll";
            BtnRemoveAll.Size = new Size(43, 31);
            BtnRemoveAll.TabIndex = 12;
            BtnRemoveAll.Text = "<<";
            BtnRemoveAll.UseVisualStyleBackColor = true;
            BtnRemoveAll.Click += BtnRemoveAll_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Enabled = false;
            BtnAdd.Location = new Point(241, 303);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(43, 31);
            BtnAdd.TabIndex = 13;
            BtnAdd.Text = ">";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnAddAll
            // 
            BtnAddAll.Enabled = false;
            BtnAddAll.Location = new Point(241, 341);
            BtnAddAll.Margin = new Padding(3, 4, 3, 4);
            BtnAddAll.Name = "BtnAddAll";
            BtnAddAll.Size = new Size(43, 31);
            BtnAddAll.TabIndex = 14;
            BtnAddAll.Text = ">>";
            BtnAddAll.UseVisualStyleBackColor = true;
            BtnAddAll.Click += BtnAddAll_Click;
            // 
            // EditCertification
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(453, 444);
            Controls.Add(BtnAddAll);
            Controls.Add(BtnAdd);
            Controls.Add(BtnRemoveAll);
            Controls.Add(BtnRemove);
            Controls.Add(lbAssignedFacilities);
            Controls.Add(lbAllFacilities);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(BtnCancel);
            Controls.Add(label3);
            Controls.Add(BtnOk);
            Controls.Add(CmbCertifications);
            Controls.Add(TxtCertDesc);
            Controls.Add(TxtCertName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditCertification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar DC-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CmbCertifications;
        private TextBox TxtCertName;
        private TextBox TxtCertDesc;
        private Button BtnOk;
        private Button BtnCancel;
        private Label label4;
        private ListBox lbAllFacilities;
        private ListBox lbAssignedFacilities;
        private Button BtnRemove;
        private Button BtnRemoveAll;
        private Button BtnAdd;
        private Button BtnAddAll;
    }
}