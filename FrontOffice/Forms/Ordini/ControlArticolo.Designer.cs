namespace FrontOffice.Forms.Ordini {
    partial class ControlArticolo {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlArticolo));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textNote = new DevExpress.XtraEditors.TextEdit();
            lookupFornitore = new DevExpress.XtraEditors.LookUpEdit();
            textNome = new DevExpress.XtraEditors.TextEdit();
            labelNumArticolo = new DevExpress.XtraEditors.LabelControl();
            textCod = new DevExpress.XtraEditors.TextEdit();
            spinQuant = new DevExpress.XtraEditors.SpinEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookupFornitore.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textNome.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textCod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinQuant.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textNote);
            layoutControl1.Controls.Add(lookupFornitore);
            layoutControl1.Controls.Add(textNome);
            layoutControl1.Controls.Add(labelNumArticolo);
            layoutControl1.Controls.Add(textCod);
            layoutControl1.Controls.Add(spinQuant);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1410, 0, 1300, 800);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1100, 220);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textNote
            // 
            textNote.Location = new Point(139, 151);
            textNote.Name = "textNote";
            textNote.Size = new Size(937, 40);
            textNote.StyleController = layoutControl1;
            textNote.TabIndex = 9;
            textNote.EditValueChanged += txtNote_EditValueChanged;
            // 
            // lookupFornitore
            // 
            lookupFornitore.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            lookupFornitore.Location = new Point(669, 103);
            lookupFornitore.Name = "lookupFornitore";
            lookupFornitore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookupFornitore.Properties.ImmediatePopup = true;
            lookupFornitore.Properties.NullText = "[Nessun Fornitore Selezionato]";
            lookupFornitore.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookupFornitore.Properties.PopupSizeable = false;
            lookupFornitore.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookupFornitore.Size = new Size(407, 40);
            lookupFornitore.StyleController = layoutControl1;
            lookupFornitore.TabIndex = 8;
            lookupFornitore.ToolTip = resources.GetString("lookupFornitore.ToolTip");
            lookupFornitore.ToolTipTitle = "Come creare un fornitore";
            lookupFornitore.ProcessNewValue += lookupFornitore_ProcessNewValue;
            lookupFornitore.EditValueChanged += lookupFornitore_EditValueChanged;
            // 
            // textNome
            // 
            textNome.Location = new Point(669, 55);
            textNome.Name = "textNome";
            textNome.Size = new Size(407, 40);
            textNome.StyleController = layoutControl1;
            textNome.TabIndex = 6;
            textNome.EditValueChanged += textNome_EditValueChanged;
            // 
            // labelNumArticolo
            // 
            labelNumArticolo.Appearance.Font = new Font("Tahoma", 7F, FontStyle.Bold);
            labelNumArticolo.Appearance.Options.UseFont = true;
            labelNumArticolo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelNumArticolo.Location = new Point(24, 24);
            labelNumArticolo.Name = "labelNumArticolo";
            labelNumArticolo.Size = new Size(1052, 23);
            labelNumArticolo.StyleController = layoutControl1;
            labelNumArticolo.TabIndex = 5;
            labelNumArticolo.Text = "Articolo #1";
            // 
            // textCod
            // 
            textCod.Location = new Point(139, 55);
            textCod.Name = "textCod";
            textCod.Size = new Size(407, 40);
            textCod.StyleController = layoutControl1;
            textCod.TabIndex = 4;
            textCod.EditValueChanged += textCod_EditValueChanged;
            // 
            // spinQuant
            // 
            spinQuant.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuant.Location = new Point(139, 103);
            spinQuant.Name = "spinQuant";
            spinQuant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuant.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            spinQuant.Properties.IsFloatValue = false;
            spinQuant.Properties.MaskSettings.Set("mask", "d");
            spinQuant.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            spinQuant.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            spinQuant.Properties.MaskSettings.Set("culture", "it-IT");
            spinQuant.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            spinQuant.Properties.MaxValue = new decimal(new int[] { 9999, 0, 0, 0 });
            spinQuant.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuant.Properties.UseMaskAsDisplayFormat = true;
            spinQuant.Size = new Size(407, 40);
            spinQuant.StyleController = layoutControl1;
            spinQuant.TabIndex = 7;
            spinQuant.EditValueChanged += spinQuant_EditValueChanged;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new Size(1100, 220);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textCod;
            layoutControlItem1.Location = new Point(0, 31);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(530, 48);
            layoutControlItem1.Text = "Codice:";
            layoutControlItem1.TextSize = new Size(91, 25);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = labelNumArticolo;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(1060, 31);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textNome;
            layoutControlItem3.Location = new Point(530, 31);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(530, 48);
            layoutControlItem3.Text = "Nome:";
            layoutControlItem3.TextSize = new Size(91, 25);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = spinQuant;
            layoutControlItem4.Location = new Point(0, 79);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(530, 48);
            layoutControlItem4.Text = "Quantità:";
            layoutControlItem4.TextSize = new Size(91, 25);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = lookupFornitore;
            layoutControlItem5.Location = new Point(530, 79);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(530, 48);
            layoutControlItem5.Text = "Fornitore:";
            layoutControlItem5.TextSize = new Size(91, 25);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = textNote;
            layoutControlItem6.Location = new Point(0, 127);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(1060, 53);
            layoutControlItem6.Text = "Note:";
            layoutControlItem6.TextSize = new Size(91, 25);
            // 
            // ControlArticolo
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.BorderColor = Color.Silver;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseBorderColor = true;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(layoutControl1);
            Name = "ControlArticolo";
            Size = new Size(1100, 220);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookupFornitore.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textNome.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textCod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinQuant.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textNome;
        private DevExpress.XtraEditors.LabelControl labelNumArticolo;
        private DevExpress.XtraEditors.TextEdit textCod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit textNote;
        private DevExpress.XtraEditors.LookUpEdit lookupFornitore;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SpinEdit spinQuant;
    }
}
