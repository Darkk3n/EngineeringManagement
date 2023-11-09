namespace EngineeringManagement.UI.Forms
{
    partial class AddCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCertification));
            BtnRemove = new Button();
            BtnOk = new Button();
            BtnCancel = new Button();
            lbAssignedFacilities = new ListBox();
            lbAllFacilities = new ListBox();
            label3 = new Label();
            TxtCertDesc = new TextBox();
            TxtCertName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnRemoveAll = new Button();
            BtnAdd = new Button();
            BtnAddAll = new Button();
            SuspendLayout();
            // 
            // BtnRemove
            // 
            BtnRemove.Enabled = false;
            BtnRemove.Location = new Point(216, 158);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(38, 23);
            BtnRemove.TabIndex = 10;
            BtnRemove.Text = "<";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(135, 314);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Guardar";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(260, 314);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // lbAssignedFacilities
            // 
            lbAssignedFacilities.FormattingEnabled = true;
            lbAssignedFacilities.ItemHeight = 15;
            lbAssignedFacilities.Location = new Point(260, 159);
            lbAssignedFacilities.Name = "lbAssignedFacilities";
            lbAssignedFacilities.Size = new Size(121, 109);
            lbAssignedFacilities.TabIndex = 8;
            // 
            // lbAllFacilities
            // 
            lbAllFacilities.FormattingEnabled = true;
            lbAllFacilities.ItemHeight = 15;
            lbAllFacilities.Location = new Point(95, 159);
            lbAllFacilities.Name = "lbAllFacilities";
            lbAllFacilities.SelectionMode = SelectionMode.MultiSimple;
            lbAllFacilities.Size = new Size(115, 109);
            lbAllFacilities.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 187);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Planta(s):";
            // 
            // TxtCertDesc
            // 
            TxtCertDesc.Location = new Point(95, 56);
            TxtCertDesc.Multiline = true;
            TxtCertDesc.Name = "TxtCertDesc";
            TxtCertDesc.Size = new Size(286, 78);
            TxtCertDesc.TabIndex = 3;
            // 
            // TxtCertName
            // 
            TxtCertName.Location = new Point(95, 12);
            TxtCertName.Name = "TxtCertName";
            TxtCertName.Size = new Size(286, 23);
            TxtCertName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // BtnRemoveAll
            // 
            BtnRemoveAll.Enabled = false;
            BtnRemoveAll.Location = new Point(216, 186);
            BtnRemoveAll.Name = "BtnRemoveAll";
            BtnRemoveAll.Size = new Size(38, 23);
            BtnRemoveAll.TabIndex = 11;
            BtnRemoveAll.Text = "<<";
            BtnRemoveAll.UseVisualStyleBackColor = true;
            BtnRemoveAll.Click += BtnRemoveAll_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(216, 216);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(38, 23);
            BtnAdd.TabIndex = 12;
            BtnAdd.Text = ">";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnAddAll
            // 
            BtnAddAll.Location = new Point(216, 245);
            BtnAddAll.Name = "BtnAddAll";
            BtnAddAll.Size = new Size(38, 23);
            BtnAddAll.TabIndex = 13;
            BtnAddAll.Text = ">>";
            BtnAddAll.UseVisualStyleBackColor = true;
            BtnAddAll.Click += BtnAddAll_Click;
            // 
            // AddCertification
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(415, 358);
            Controls.Add(BtnAddAll);
            Controls.Add(BtnAdd);
            Controls.Add(BtnRemoveAll);
            Controls.Add(label1);
            Controls.Add(TxtCertName);
            Controls.Add(label2);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            Controls.Add(TxtCertDesc);
            Controls.Add(label3);
            Controls.Add(lbAssignedFacilities);
            Controls.Add(lbAllFacilities);
            Controls.Add(BtnRemove);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCertification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar DC-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRemove;
        private Button BtnOk;
        private Button BtnCancel;
        private ListBox lbAssignedFacilities;
        private ListBox lbAllFacilities;
        private Label label3;
        private TextBox TxtCertDesc;
        private TextBox TxtCertName;
        private Label label2;
        private Label label1;
        private Button BtnRemoveAll;
        private Button BtnAdd;
        private Button BtnAddAll;
    }
}