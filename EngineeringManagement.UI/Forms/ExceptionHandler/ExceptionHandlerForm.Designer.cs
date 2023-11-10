namespace EngineeringManagement.UI.Forms.ExceptionHandler
{
    partial class ExceptionHandlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionHandlerForm));
            label1 = new Label();
            BtnClose = new Button();
            txtEx = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(645, 90);
            label1.TabIndex = 0;
            label1.Text = "Chale... Ocurrio un error... Pero la aplicacion no se cerrara!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(694, 531);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 29);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "Cerrar";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // txtEx
            // 
            txtEx.Location = new Point(12, 235);
            txtEx.Multiline = true;
            txtEx.Name = "txtEx";
            txtEx.ReadOnly = true;
            txtEx.Size = new Size(776, 273);
            txtEx.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(776, 90);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Error;
            pictureBox1.Location = new Point(663, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ExceptionHandlerForm
            // 
            AcceptButton = BtnClose;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnClose;
            ClientSize = new Size(800, 572);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtEx);
            Controls.Add(BtnClose);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExceptionHandlerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control Total Ingenieria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnClose;
        private TextBox txtEx;
        private Label label2;
        private PictureBox pictureBox1;
    }
}