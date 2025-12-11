namespace Common.Forms {
    partial class AppInfo {
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            labelAppVersion = new DevExpress.XtraEditors.LabelControl();
            labelAppAuthor = new DevExpress.XtraEditors.LabelControl();
            pictureBoxAppIcon = new PictureBox();
            labelAppName = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceBottom = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceTop = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceTop).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(labelAppVersion);
            layoutControl1.Controls.Add(labelAppAuthor);
            layoutControl1.Controls.Add(pictureBoxAppIcon);
            layoutControl1.Controls.Add(labelAppName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(705, 508, 1731, 800);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(605, 483);
            layoutControl1.TabIndex = 1;
            // 
            // labelAppVersion
            // 
            labelAppVersion.Appearance.Font = new Font("Tahoma", 7F);
            labelAppVersion.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelAppVersion.Appearance.Options.UseFont = true;
            labelAppVersion.Appearance.Options.UseForeColor = true;
            labelAppVersion.Appearance.Options.UseTextOptions = true;
            labelAppVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelAppVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            labelAppVersion.Location = new Point(24, 325);
            labelAppVersion.Name = "labelAppVersion";
            labelAppVersion.Size = new Size(557, 80);
            labelAppVersion.StyleController = layoutControl1;
            labelAppVersion.TabIndex = 7;
            labelAppVersion.Text = "Versione 1.0.5";
            // 
            // labelAppAuthor
            // 
            labelAppAuthor.Appearance.Font = new Font("Tahoma", 9F);
            labelAppAuthor.Appearance.Options.UseFont = true;
            labelAppAuthor.Appearance.Options.UseTextOptions = true;
            labelAppAuthor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelAppAuthor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            labelAppAuthor.Location = new Point(24, 264);
            labelAppAuthor.Name = "labelAppAuthor";
            labelAppAuthor.Size = new Size(557, 53);
            labelAppAuthor.StyleController = layoutControl1;
            labelAppAuthor.TabIndex = 6;
            labelAppAuthor.Text = "di Batta";
            // 
            // pictureBoxAppIcon
            // 
            pictureBoxAppIcon.Image = Properties.Resources.crediti_icon;
            pictureBoxAppIcon.Location = new Point(24, 88);
            pictureBoxAppIcon.Name = "pictureBoxAppIcon";
            pictureBoxAppIcon.Size = new Size(557, 107);
            pictureBoxAppIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAppIcon.TabIndex = 5;
            pictureBoxAppIcon.TabStop = false;
            // 
            // labelAppName
            // 
            labelAppName.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelAppName.Appearance.Options.UseFont = true;
            labelAppName.Appearance.Options.UseTextOptions = true;
            labelAppName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelAppName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            labelAppName.Location = new Point(24, 203);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(557, 53);
            labelAppName.StyleController = layoutControl1;
            labelAppName.TabIndex = 4;
            labelAppName.Text = "Crediti";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem1, layoutControlItem3, layoutControlItem4, emptySpaceBottom, emptySpaceTop });
            Root.Name = "Root";
            Root.Size = new Size(605, 483);
            Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = labelAppName;
            layoutControlItem2.Location = new Point(0, 179);
            layoutControlItem2.MinSize = new Size(40, 46);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(565, 61);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = pictureBoxAppIcon;
            layoutControlItem1.Location = new Point(0, 64);
            layoutControlItem1.MinSize = new Size(108, 28);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(565, 115);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = labelAppAuthor;
            layoutControlItem3.Location = new Point(0, 240);
            layoutControlItem3.MinSize = new Size(30, 36);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(565, 61);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = labelAppVersion;
            layoutControlItem4.Location = new Point(0, 301);
            layoutControlItem4.MinSize = new Size(24, 30);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(565, 88);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceBottom
            // 
            emptySpaceBottom.Location = new Point(0, 389);
            emptySpaceBottom.Name = "emptySpaceBottom";
            emptySpaceBottom.Size = new Size(565, 54);
            // 
            // emptySpaceTop
            // 
            emptySpaceTop.Location = new Point(0, 0);
            emptySpaceTop.Name = "emptySpaceTop";
            emptySpaceTop.Size = new Size(565, 64);
            // 
            // AppInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 483);
            Controls.Add(layoutControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AppInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazioni";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceTop).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelAppName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private PictureBox pictureBoxAppIcon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelAppVersion;
        private DevExpress.XtraEditors.LabelControl labelAppAuthor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceBottom;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceTop;
    }
}