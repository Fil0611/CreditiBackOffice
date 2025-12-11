namespace FrontOffice.Forms.Ordini {
    partial class NuovoOrdine {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuovoOrdine));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            buttonCreateOrdine = new DevExpress.XtraEditors.SimpleButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            controlArticolo1 = new ControlArticolo();
            buttonAddArticolo = new DevExpress.XtraEditors.SimpleButton();
            textNote = new DevExpress.XtraEditors.TextEdit();
            textCell = new DevExpress.XtraEditors.TextEdit();
            textNome = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textCell.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textNome.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(buttonCancel);
            layoutControl1.Controls.Add(buttonCreateOrdine);
            layoutControl1.Controls.Add(groupControl1);
            layoutControl1.Controls.Add(textNote);
            layoutControl1.Controls.Add(textCell);
            layoutControl1.Controls.Add(textNome);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1724, 160, 1300, 800);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1234, 629);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // buttonCancel
            // 
            buttonCancel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCancel.ImageOptions.SvgImage");
            buttonCancel.ImageOptions.SvgImageSize = new Size(15, 15);
            buttonCancel.Location = new Point(621, 561);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(290, 44);
            buttonCancel.StyleController = layoutControl1;
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Annulla";
            // 
            // buttonCreateOrdine
            // 
            buttonCreateOrdine.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCreateOrdine.ImageOptions.SvgImage");
            buttonCreateOrdine.ImageOptions.SvgImageSize = new Size(15, 15);
            buttonCreateOrdine.Location = new Point(919, 561);
            buttonCreateOrdine.Name = "buttonCreateOrdine";
            buttonCreateOrdine.Size = new Size(291, 44);
            buttonCreateOrdine.StyleController = layoutControl1;
            buttonCreateOrdine.TabIndex = 6;
            buttonCreateOrdine.Text = "Crea Ordine";
            buttonCreateOrdine.Click += buttonCreateOrdine_Click;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(stackPanel1);
            groupControl1.Location = new Point(24, 168);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1186, 385);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Articoli";
            // 
            // stackPanel1
            // 
            stackPanel1.AutoScroll = true;
            stackPanel1.Controls.Add(controlArticolo1);
            stackPanel1.Controls.Add(buttonAddArticolo);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            stackPanel1.Location = new Point(3, 45);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(1180, 337);
            stackPanel1.TabIndex = 0;
            stackPanel1.UseSkinIndents = true;
            // 
            // controlArticolo1
            // 
            controlArticolo1.Appearance.BackColor = Color.WhiteSmoke;
            controlArticolo1.Appearance.BorderColor = Color.Silver;
            controlArticolo1.Appearance.Options.UseBackColor = true;
            controlArticolo1.Appearance.Options.UseBorderColor = true;
            controlArticolo1.BorderStyle = BorderStyle.FixedSingle;
            controlArticolo1.Location = new Point(40, 24);
            controlArticolo1.Name = "controlArticolo1";
            controlArticolo1.Size = new Size(1100, 220);
            controlArticolo1.TabIndex = 2;
            // 
            // buttonAddArticolo
            // 
            buttonAddArticolo.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAddArticolo.ImageOptions.SvgImage");
            buttonAddArticolo.ImageOptions.SvgImageSize = new Size(15, 15);
            buttonAddArticolo.Location = new Point(484, 252);
            buttonAddArticolo.Name = "buttonAddArticolo";
            buttonAddArticolo.Size = new Size(212, 44);
            buttonAddArticolo.TabIndex = 1;
            buttonAddArticolo.Text = "Aggiungi Articolo";
            buttonAddArticolo.Click += buttonAddArticolo_Click;
            // 
            // textNote
            // 
            textNote.Location = new Point(168, 120);
            textNote.Name = "textNote";
            textNote.Size = new Size(1042, 40);
            textNote.StyleController = layoutControl1;
            textNote.TabIndex = 3;
            // 
            // textCell
            // 
            textCell.Location = new Point(168, 72);
            textCell.Name = "textCell";
            textCell.Size = new Size(1042, 40);
            textCell.StyleController = layoutControl1;
            textCell.TabIndex = 2;
            // 
            // textNome
            // 
            textNome.Location = new Point(168, 24);
            textNome.Name = "textNome";
            textNome.Size = new Size(1042, 40);
            textNome.StyleController = layoutControl1;
            textNome.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem2, emptySpaceItem2, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new Size(1234, 629);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textNome;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1194, 48);
            layoutControlItem1.Text = "Nome:";
            layoutControlItem1.TextSize = new Size(120, 25);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textCell;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(1194, 48);
            layoutControlItem3.Text = "Cell / Tel:";
            layoutControlItem3.TextSize = new Size(120, 25);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textNote;
            layoutControlItem4.Location = new Point(0, 96);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(1194, 48);
            layoutControlItem4.Text = "Note Ordine:";
            layoutControlItem4.TextSize = new Size(120, 25);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = groupControl1;
            layoutControlItem5.Location = new Point(0, 144);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(1194, 393);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = buttonCreateOrdine;
            layoutControlItem2.Location = new Point(895, 537);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(299, 52);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new Point(0, 537);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(597, 52);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = buttonCancel;
            layoutControlItem6.Location = new Point(597, 537);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(298, 52);
            layoutControlItem6.TextVisible = false;
            // 
            // NuovoOrdine
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 629);
            Controls.Add(layoutControl1);
            MinimumSize = new Size(1260, 700);
            Name = "NuovoOrdine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuovo Ordine";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textCell.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textNome.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textNome;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit textNote;
        private DevExpress.XtraEditors.TextEdit textCell;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton buttonAddArticolo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonCreateOrdine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private ControlArticolo controlArticolo1;
    }
}