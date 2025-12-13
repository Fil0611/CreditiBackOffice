namespace BackOffice.Forms {
    partial class StartingPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingPage));
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(38, 68, 112);
            simpleButton1.Appearance.Font = new Font("Tahoma", 7.875F, FontStyle.Bold);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(12, 182);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(275, 100);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Crediti";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = Color.FromArgb(38, 68, 112);
            simpleButton2.Appearance.Font = new Font("Tahoma", 7.875F, FontStyle.Bold);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(325, 182);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(275, 100);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "Ordini";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // StartingPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 128, 194);
            ClientSize = new Size(612, 294);
            Controls.Add(pictureBox1);
            Controls.Add(simpleButton1);
            Controls.Add(simpleButton2);
            Name = "StartingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += StartingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private PictureBox pictureBox1;
    }
}