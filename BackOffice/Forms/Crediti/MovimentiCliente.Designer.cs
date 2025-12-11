namespace BackOffice.Forms.Crediti {
    partial class MovimentiCliente {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimentiCliente));
            DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters sqLiteConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonReportCliente = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            statusBarTextNumMovimenti = new DevExpress.XtraBars.BarStaticItem();
            statusBarTextNumMovimentiChiusi = new DevExpress.XtraBars.BarStaticItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonDeleteMovimento = new DevExpress.XtraBars.BarButtonItem();
            sqlDataSourceMovimentiCliente = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridMovimenti = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colIDCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporto = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            colImportoPagato = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataCreato = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            colDataChiuso = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            colRifDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsChiuso = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            labelNomeCliente = new DevExpress.XtraEditors.LabelControl();
            labelEMailCliente = new DevExpress.XtraEditors.LabelControl();
            labelCellCliente = new DevExpress.XtraEditors.LabelControl();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            labelPIvaCliente = new DevExpress.XtraEditors.LabelControl();
            popupMenuRow = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMovimenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCalcEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCalcEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popupMenuRow).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { statusBarTextNumMovimenti, statusBarTextNumMovimentiChiusi, barButtonReportCliente, barButtonDeleteMovimento });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 5;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonReportCliente) });
            bar2.OptionsBar.AllowQuickCustomization = false;
            bar2.OptionsBar.DrawDragBorder = false;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barButtonReportCliente
            // 
            barButtonReportCliente.Caption = "Report Cliente";
            barButtonReportCliente.Id = 3;
            barButtonReportCliente.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonReportCliente.ImageOptions.SvgImage");
            barButtonReportCliente.ImageOptions.SvgImageSize = new Size(15, 15);
            barButtonReportCliente.Name = "barButtonReportCliente";
            barButtonReportCliente.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonReportCliente.ItemClick += barButtonReport_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(statusBarTextNumMovimenti), new DevExpress.XtraBars.LinkPersistInfo(statusBarTextNumMovimentiChiusi) });
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // statusBarTextNumMovimenti
            // 
            statusBarTextNumMovimenti.Caption = "0 Movimenti";
            statusBarTextNumMovimenti.Id = 1;
            statusBarTextNumMovimenti.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("statusBarTextNumMovimenti.ImageOptions.SvgImage");
            statusBarTextNumMovimenti.ImageOptions.SvgImageSize = new Size(15, 15);
            statusBarTextNumMovimenti.Name = "statusBarTextNumMovimenti";
            statusBarTextNumMovimenti.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // statusBarTextNumMovimentiChiusi
            // 
            statusBarTextNumMovimentiChiusi.Caption = "0 Chiusi";
            statusBarTextNumMovimentiChiusi.Id = 2;
            statusBarTextNumMovimentiChiusi.ItemAppearance.Normal.ForeColor = Color.Gray;
            statusBarTextNumMovimentiChiusi.ItemAppearance.Normal.Options.UseForeColor = true;
            statusBarTextNumMovimentiChiusi.Name = "statusBarTextNumMovimentiChiusi";
            statusBarTextNumMovimentiChiusi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1630, 45);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 881);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1630, 49);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 45);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 836);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1630, 45);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 836);
            // 
            // barButtonDeleteMovimento
            // 
            barButtonDeleteMovimento.Caption = "Elimina";
            barButtonDeleteMovimento.Id = 4;
            barButtonDeleteMovimento.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonDeleteMovimento.ImageOptions.SvgImage");
            barButtonDeleteMovimento.ImageOptions.SvgImageSize = new Size(15, 15);
            barButtonDeleteMovimento.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Delete);
            barButtonDeleteMovimento.Name = "barButtonDeleteMovimento";
            barButtonDeleteMovimento.ShortcutKeyDisplayString = "CANC";
            barButtonDeleteMovimento.ItemClick += barButtonDeleteMovimento_ItemClick;
            // 
            // sqlDataSourceMovimentiCliente
            // 
            sqlDataSourceMovimentiCliente.ConnectionName = "database";
            sqLiteConnectionParameters1.FileName = "C:\\FilBatta\\Crediti\\database.db";
            sqlDataSourceMovimentiCliente.ConnectionParameters = sqLiteConnectionParameters1;
            sqlDataSourceMovimentiCliente.Name = "sqlDataSourceMovimentiCliente";
            columnExpression1.ColumnName = "ID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"218\" />";
            table1.Name = "Movimenti";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "IDCliente";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Importo";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "ImportoPagato";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "RifDoc";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "DataCreato";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "DataChiuso";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.FilterString = "[Movimenti.IDCliente] = ?IDClienteSelezionato";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "Movimenti";
            queryParameter1.Name = "IDClienteSelezionato";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "41";
            selectQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] { queryParameter1 });
            selectQuery1.Tables.Add(table1);
            sqlDataSourceMovimentiCliente.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { selectQuery1 });
            sqlDataSourceMovimentiCliente.ResultSchemaSerializable = resources.GetString("sqlDataSourceMovimentiCliente.ResultSchemaSerializable");
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.Location = new Point(0, 188);
            gridControl1.MainView = gridMovimenti;
            gridControl1.MenuManager = barManager1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCalcEdit1, repositoryItemDateEdit3, repositoryItemDateEdit1, repositoryItemCalcEdit2, repositoryItemCheckEdit1 });
            gridControl1.Size = new Size(1630, 693);
            gridControl1.TabIndex = 24;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridMovimenti });
            // 
            // gridMovimenti
            // 
            gridMovimenti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colIDCliente, colImporto, colImportoPagato, colSaldo, colDataCreato, colDataChiuso, colRifDoc, colIsChiuso });
            gridMovimenti.GridControl = gridControl1;
            gridMovimenti.GroupPanelText = "Premere sulla Lente di Ingrandimento per cercare un Movimento →";
            gridMovimenti.Name = "gridMovimenti";
            gridMovimenti.NewItemRowText = "Clicca qui per inserire un nuovo movimento";
            gridMovimenti.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gridMovimenti.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridMovimenti.OptionsView.ShowFooter = true;
            gridMovimenti.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colDataCreato, DevExpress.Data.ColumnSortOrder.Descending) });
            gridMovimenti.RowClick += gridMovimenti_RowClick;
            gridMovimenti.RowStyle += gridMovimenti_RowStyle;
            gridMovimenti.CellValueChanging += gridMovimenti_CellValueChanging;
            gridMovimenti.ValidateRow += gridTest_ValidateRow;
            gridMovimenti.KeyDown += gridMovimenti_KeyDown;
            gridMovimenti.RowCountChanged += gridMovimenti_RowCountChanged;
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "ID";
            colID.MinWidth = 40;
            colID.Name = "colID";
            colID.Width = 150;
            // 
            // colIDCliente
            // 
            colIDCliente.Caption = "ID Cliente";
            colIDCliente.FieldName = "IDCliente";
            colIDCliente.MinWidth = 40;
            colIDCliente.Name = "colIDCliente";
            colIDCliente.Width = 150;
            // 
            // colImporto
            // 
            colImporto.Caption = "Importo";
            colImporto.ColumnEdit = repositoryItemCalcEdit1;
            colImporto.DisplayFormat.FormatString = "c2";
            colImporto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colImporto.FieldName = "Importo";
            colImporto.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colImporto.ImageOptions.SvgImage");
            colImporto.ImageOptions.SvgImageSize = new Size(15, 15);
            colImporto.MinWidth = 40;
            colImporto.Name = "colImporto";
            colImporto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importo", "{0:c2}") });
            colImporto.Visible = true;
            colImporto.VisibleIndex = 2;
            colImporto.Width = 230;
            // 
            // repositoryItemCalcEdit1
            // 
            repositoryItemCalcEdit1.AutoHeight = false;
            repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemCalcEdit1.MaskSettings.Set("mask", "c");
            repositoryItemCalcEdit1.MaskSettings.Set("culture", "it-IT");
            repositoryItemCalcEdit1.MaskSettings.Set("valueType", typeof(float));
            repositoryItemCalcEdit1.MaskSettings.Set("hideInsignificantZeros", null);
            repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            repositoryItemCalcEdit1.UseMaskAsDisplayFormat = true;
            // 
            // colImportoPagato
            // 
            colImportoPagato.Caption = "Importo Pagato";
            colImportoPagato.ColumnEdit = repositoryItemCalcEdit2;
            colImportoPagato.DisplayFormat.FormatString = "c2";
            colImportoPagato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colImportoPagato.FieldName = "ImportoPagato";
            colImportoPagato.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colImportoPagato.ImageOptions.SvgImage");
            colImportoPagato.ImageOptions.SvgImageSize = new Size(15, 15);
            colImportoPagato.MinWidth = 40;
            colImportoPagato.Name = "colImportoPagato";
            colImportoPagato.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportoPagato", "{0:c2}") });
            colImportoPagato.Visible = true;
            colImportoPagato.VisibleIndex = 3;
            colImportoPagato.Width = 222;
            // 
            // repositoryItemCalcEdit2
            // 
            repositoryItemCalcEdit2.AutoHeight = false;
            repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemCalcEdit2.MaskSettings.Set("mask", "c");
            repositoryItemCalcEdit2.MaskSettings.Set("culture", "it-IT");
            repositoryItemCalcEdit2.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            repositoryItemCalcEdit2.MaskSettings.Set("valueType", typeof(float));
            repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            repositoryItemCalcEdit2.UseMaskAsDisplayFormat = true;
            // 
            // colSaldo
            // 
            colSaldo.Caption = "Saldo";
            colSaldo.DisplayFormat.FormatString = "c2";
            colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colSaldo.FieldName = "Saldo";
            colSaldo.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colSaldo.ImageOptions.SvgImage");
            colSaldo.ImageOptions.SvgImageSize = new Size(15, 15);
            colSaldo.MinWidth = 40;
            colSaldo.Name = "colSaldo";
            colSaldo.OptionsColumn.AllowEdit = false;
            colSaldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:c2}") });
            colSaldo.UnboundDataType = typeof(float);
            colSaldo.UnboundExpression = "Iif(IsNullOrEmpty([ImportoPagato]), [Importo], [Importo] - [ImportoPagato])";
            colSaldo.Visible = true;
            colSaldo.VisibleIndex = 4;
            colSaldo.Width = 170;
            // 
            // colDataCreato
            // 
            colDataCreato.Caption = "Data";
            colDataCreato.ColumnEdit = repositoryItemDateEdit3;
            colDataCreato.DisplayFormat.FormatString = "d";
            colDataCreato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDataCreato.FieldName = "DataCreato";
            colDataCreato.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colDataCreato.ImageOptions.SvgImage");
            colDataCreato.ImageOptions.SvgImageSize = new Size(15, 15);
            colDataCreato.MinWidth = 40;
            colDataCreato.Name = "colDataCreato";
            colDataCreato.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            colDataCreato.Visible = true;
            colDataCreato.VisibleIndex = 0;
            colDataCreato.Width = 211;
            // 
            // repositoryItemDateEdit3
            // 
            repositoryItemDateEdit3.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit3.AutoHeight = false;
            repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit3.CalendarTimeProperties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit3.CalendarTimeProperties.MaskSettings.Set("useAdvancingCaret", true);
            repositoryItemDateEdit3.CalendarTimeProperties.MaskSettings.Set("mask", "d");
            repositoryItemDateEdit3.CalendarTimeProperties.MaskSettings.Set("culture", "it-IT");
            repositoryItemDateEdit3.CalendarTimeProperties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit3.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            repositoryItemDateEdit3.MaskSettings.Set("mask", "d");
            repositoryItemDateEdit3.MaskSettings.Set("culture", "it-IT");
            repositoryItemDateEdit3.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            repositoryItemDateEdit3.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            repositoryItemDateEdit3.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit3.UseMaskAsDisplayFormat = true;
            // 
            // colDataChiuso
            // 
            colDataChiuso.Caption = "Data Pagamento";
            colDataChiuso.ColumnEdit = repositoryItemDateEdit1;
            colDataChiuso.DisplayFormat.FormatString = "d";
            colDataChiuso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDataChiuso.FieldName = "DataChiuso";
            colDataChiuso.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colDataChiuso.ImageOptions.SvgImage");
            colDataChiuso.ImageOptions.SvgImageSize = new Size(15, 15);
            colDataChiuso.MinWidth = 40;
            colDataChiuso.Name = "colDataChiuso";
            colDataChiuso.Visible = true;
            colDataChiuso.VisibleIndex = 5;
            colDataChiuso.Width = 224;
            // 
            // repositoryItemDateEdit1
            // 
            repositoryItemDateEdit1.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit1.MaskSettings.Set("mask", "d");
            repositoryItemDateEdit1.MaskSettings.Set("culture", "it-IT");
            repositoryItemDateEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            repositoryItemDateEdit1.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            repositoryItemDateEdit1.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            repositoryItemDateEdit1.UseMaskAsDisplayFormat = true;
            // 
            // colRifDoc
            // 
            colRifDoc.Caption = "Rif. Doc.";
            colRifDoc.FieldName = "RifDoc";
            colRifDoc.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("colRifDoc.ImageOptions.SvgImage");
            colRifDoc.ImageOptions.SvgImageSize = new Size(15, 15);
            colRifDoc.MinWidth = 40;
            colRifDoc.Name = "colRifDoc";
            colRifDoc.Visible = true;
            colRifDoc.VisibleIndex = 1;
            colRifDoc.Width = 200;
            // 
            // colIsChiuso
            // 
            colIsChiuso.Caption = "Chiuso?";
            colIsChiuso.ColumnEdit = repositoryItemCheckEdit1;
            colIsChiuso.FieldName = "IsChiuso";
            colIsChiuso.MinWidth = 40;
            colIsChiuso.Name = "colIsChiuso";
            colIsChiuso.Tag = false;
            colIsChiuso.Visible = true;
            colIsChiuso.VisibleIndex = 6;
            colIsChiuso.Width = 167;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.Appearance.Font = new Font("Tahoma", 15F);
            labelNomeCliente.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(labelNomeCliente, 0);
            tablePanel1.SetColumnSpan(labelNomeCliente, 3);
            labelNomeCliente.Location = new Point(26, 24);
            labelNomeCliente.Name = "labelNomeCliente";
            tablePanel1.SetRow(labelNomeCliente, 0);
            labelNomeCliente.Size = new Size(236, 48);
            labelNomeCliente.TabIndex = 29;
            labelNomeCliente.Text = "Nome Cliente";
            // 
            // labelEMailCliente
            // 
            tablePanel1.SetColumn(labelEMailCliente, 1);
            labelEMailCliente.Location = new Point(612, 80);
            labelEMailCliente.Name = "labelEMailCliente";
            tablePanel1.SetRow(labelEMailCliente, 1);
            labelEMailCliente.Size = new Size(128, 25);
            labelEMailCliente.TabIndex = 32;
            labelEMailCliente.Text = "E-Mail Cliente";
            // 
            // labelCellCliente
            // 
            tablePanel1.SetColumn(labelCellCliente, 2);
            labelCellCliente.Location = new Point(1198, 80);
            labelCellCliente.Name = "labelCellCliente";
            tablePanel1.SetRow(labelCellCliente, 1);
            labelCellCliente.Size = new Size(111, 25);
            labelCellCliente.TabIndex = 31;
            labelCellCliente.Text = "Cell. Cliente";
            // 
            // tablePanel1
            // 
            tablePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tablePanel1.AutoSize = true;
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F) });
            tablePanel1.Controls.Add(labelPIvaCliente);
            tablePanel1.Controls.Add(labelCellCliente);
            tablePanel1.Controls.Add(labelNomeCliente);
            tablePanel1.Controls.Add(labelEMailCliente);
            tablePanel1.Location = new Point(12, 51);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 48F) });
            tablePanel1.Size = new Size(1606, 131);
            tablePanel1.TabIndex = 33;
            tablePanel1.UseSkinIndents = true;
            // 
            // labelPIvaCliente
            // 
            tablePanel1.SetColumn(labelPIvaCliente, 0);
            labelPIvaCliente.Location = new Point(26, 80);
            labelPIvaCliente.Name = "labelPIvaCliente";
            tablePanel1.SetRow(labelPIvaCliente, 1);
            labelPIvaCliente.Size = new Size(130, 25);
            labelPIvaCliente.TabIndex = 33;
            labelPIvaCliente.Text = "P. IVA Cliente";
            // 
            // popupMenuRow
            // 
            popupMenuRow.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonDeleteMovimento) });
            popupMenuRow.Manager = barManager1;
            popupMenuRow.Name = "popupMenuRow";
            // 
            // MovimentiCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 930);
            Controls.Add(tablePanel1);
            Controls.Add(gridControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            MinimumSize = new Size(1500, 900);
            Name = "MovimentiCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimenti Cliente";
            FormClosing += MovimentiCliente_FormClosing;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMovimenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCalcEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCalcEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)popupMenuRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceMovimentiCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colImporto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCreato;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMovimenti;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoPagato;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDataChiuso;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colRifDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colIsChiuso;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarStaticItem statusBarTextNumMovimenti;
        private DevExpress.XtraBars.BarStaticItem statusBarTextNumMovimentiChiusi;
        private DevExpress.XtraBars.BarButtonItem barButtonReportCliente;
        private DevExpress.XtraEditors.LabelControl labelNomeCliente;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelCellCliente;
        private DevExpress.XtraEditors.LabelControl labelEMailCliente;
        private DevExpress.XtraEditors.LabelControl labelPIvaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraBars.BarButtonItem barButtonDeleteMovimento;
        private DevExpress.XtraBars.PopupMenu popupMenuRow;
    }
}