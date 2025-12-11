namespace BackOffice.Forms.Crediti {
    partial class DebitiCompleti {
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
            DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters sqLiteConnectionParameters2 = new DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitiCompleti));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            sqlDataSourceDebitiCompleti = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridViewDebitiCompleti = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            colIDMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporto = new DevExpress.XtraGrid.Columns.GridColumn();
            colImportoPagato = new DevExpress.XtraGrid.Columns.GridColumn();
            colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            colRifDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataCreato = new DevExpress.XtraGrid.Columns.GridColumn();
            colPIva = new DevExpress.XtraGrid.Columns.GridColumn();
            colCell = new DevExpress.XtraGrid.Columns.GridColumn();
            colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsFornitore = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDebitiCompleti).BeginInit();
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
            barManager1.MainMenu = bar2;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.OptionsBar.AllowQuickCustomization = false;
            bar2.OptionsBar.DisableCustomization = true;
            bar2.OptionsBar.DrawDragBorder = false;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1550, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 679);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1550, 22);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 20);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 659);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1550, 20);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 659);
            // 
            // sqlDataSourceDebitiCompleti
            // 
            sqlDataSourceDebitiCompleti.ConnectionName = "database";
            sqLiteConnectionParameters2.FileName = "C:\\FilBatta\\Crediti\\database.db";
            sqlDataSourceDebitiCompleti.ConnectionParameters = sqLiteConnectionParameters2;
            sqlDataSourceDebitiCompleti.Name = "sqlDataSourceDebitiCompleti";
            columnExpression13.ColumnName = "ID";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"238\" />";
            table3.Name = "Clienti";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Nome";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "PIva";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Cell";
            columnExpression16.Table = table3;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "EMail";
            columnExpression17.Table = table3;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "IsFornitore";
            columnExpression18.Table = table3;
            column18.Expression = columnExpression18;
            column19.Alias = "IDMovimento";
            columnExpression19.ColumnName = "ID";
            table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"238\" />";
            table4.Name = "Movimenti";
            columnExpression19.Table = table4;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "Importo";
            columnExpression20.Table = table4;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "ImportoPagato";
            columnExpression21.Table = table4;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "RifDoc";
            columnExpression22.Table = table4;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "DataCreato";
            columnExpression23.Table = table4;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "IsChiuso";
            columnExpression24.Table = table4;
            column24.Expression = columnExpression24;
            selectQuery2.Columns.Add(column13);
            selectQuery2.Columns.Add(column14);
            selectQuery2.Columns.Add(column15);
            selectQuery2.Columns.Add(column16);
            selectQuery2.Columns.Add(column17);
            selectQuery2.Columns.Add(column18);
            selectQuery2.Columns.Add(column19);
            selectQuery2.Columns.Add(column20);
            selectQuery2.Columns.Add(column21);
            selectQuery2.Columns.Add(column22);
            selectQuery2.Columns.Add(column23);
            selectQuery2.Columns.Add(column24);
            selectQuery2.FilterString = "[Movimenti.IsChiuso] = False And [Clienti.IsFornitore] = True";
            selectQuery2.GroupFilterString = "";
            selectQuery2.Name = "Clienti";
            relationColumnInfo2.NestedKeyColumn = "IDCliente";
            relationColumnInfo2.ParentKeyColumn = "ID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table4;
            join2.Parent = table3;
            selectQuery2.Relations.Add(join2);
            selectQuery2.Tables.Add(table3);
            selectQuery2.Tables.Add(table4);
            sqlDataSourceDebitiCompleti.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { selectQuery2 });
            sqlDataSourceDebitiCompleti.ResultSchemaSerializable = resources.GetString("sqlDataSourceDebitiCompleti.ResultSchemaSerializable");
            // 
            // gridControl1
            // 
            gridControl1.DataMember = "Clienti";
            gridControl1.DataSource = sqlDataSourceDebitiCompleti;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 20);
            gridControl1.MainView = gridViewDebitiCompleti;
            gridControl1.MenuManager = barManager1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1550, 659);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewDebitiCompleti });
            // 
            // gridViewDebitiCompleti
            // 
            gridViewDebitiCompleti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colNome, colIDMovimento, colImporto, colImportoPagato, colSaldo, colRifDoc, colDataCreato, colPIva, colCell, colEMail, colIsFornitore });
            gridViewDebitiCompleti.GridControl = gridControl1;
            gridViewDebitiCompleti.GroupPanelText = "Premere sulla Lente di Ingrandimento per cercare un Cliente →";
            gridViewDebitiCompleti.Name = "gridViewDebitiCompleti";
            gridViewDebitiCompleti.OptionsBehavior.Editable = false;
            gridViewDebitiCompleti.OptionsView.ShowFooter = true;
            gridViewDebitiCompleti.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colNome, DevExpress.Data.ColumnSortOrder.Ascending) });
            gridViewDebitiCompleti.RowClick += gridViewDebitiCompleti_RowClick;
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.MinWidth = 40;
            colID.Name = "colID";
            colID.Width = 150;
            // 
            // colNome
            // 
            colNome.FieldName = "Nome";
            colNome.MinWidth = 40;
            colNome.Name = "colNome";
            colNome.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            colNome.Visible = true;
            colNome.VisibleIndex = 0;
            colNome.Width = 477;
            // 
            // colIDMovimento
            // 
            colIDMovimento.FieldName = "IDMovimento";
            colIDMovimento.MinWidth = 40;
            colIDMovimento.Name = "colIDMovimento";
            colIDMovimento.Width = 150;
            // 
            // colImporto
            // 
            colImporto.DisplayFormat.FormatString = "c2";
            colImporto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colImporto.FieldName = "Importo";
            colImporto.MinWidth = 40;
            colImporto.Name = "colImporto";
            colImporto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importo", "{0:c2}") });
            colImporto.Visible = true;
            colImporto.VisibleIndex = 3;
            colImporto.Width = 243;
            // 
            // colImportoPagato
            // 
            colImportoPagato.DisplayFormat.FormatString = "c2";
            colImportoPagato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colImportoPagato.FieldName = "ImportoPagato";
            colImportoPagato.MinWidth = 40;
            colImportoPagato.Name = "colImportoPagato";
            colImportoPagato.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportoPagato", "{0:c2}") });
            colImportoPagato.Visible = true;
            colImportoPagato.VisibleIndex = 4;
            colImportoPagato.Width = 243;
            // 
            // colSaldo
            // 
            colSaldo.Caption = "Saldo";
            colSaldo.DisplayFormat.FormatString = "c2";
            colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colSaldo.FieldName = "Saldo";
            colSaldo.MinWidth = 40;
            colSaldo.Name = "colSaldo";
            colSaldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:c2}") });
            colSaldo.UnboundDataType = typeof(float);
            colSaldo.UnboundExpression = "Iif(IsNullOrEmpty([ImportoPagato]), [Importo], [Importo] - [ImportoPagato])";
            colSaldo.Visible = true;
            colSaldo.VisibleIndex = 5;
            colSaldo.Width = 248;
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
            colRifDoc.VisibleIndex = 2;
            colRifDoc.Width = 178;
            // 
            // colDataCreato
            // 
            colDataCreato.Caption = "Data";
            colDataCreato.DisplayFormat.FormatString = "d";
            colDataCreato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDataCreato.FieldName = "DataCreato";
            colDataCreato.MinWidth = 40;
            colDataCreato.Name = "colDataCreato";
            colDataCreato.Visible = true;
            colDataCreato.VisibleIndex = 1;
            colDataCreato.Width = 223;
            // 
            // colPIva
            // 
            colPIva.FieldName = "PIva";
            colPIva.MinWidth = 40;
            colPIva.Name = "colPIva";
            colPIva.Width = 150;
            // 
            // colCell
            // 
            colCell.FieldName = "Cell";
            colCell.MinWidth = 40;
            colCell.Name = "colCell";
            colCell.Width = 150;
            // 
            // colEMail
            // 
            colEMail.FieldName = "EMail";
            colEMail.MinWidth = 40;
            colEMail.Name = "colEMail";
            colEMail.Width = 150;
            // 
            // colIsFornitore
            // 
            colIsFornitore.FieldName = "IsFornitore";
            colIsFornitore.MinWidth = 40;
            colIsFornitore.Name = "colIsFornitore";
            colIsFornitore.Width = 150;
            // 
            // DebitiCompleti
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 701);
            Controls.Add(gridControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DebitiCompleti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Debiti Completi";
            FormClosing += DebitiCompleti_FormClosing;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDebitiCompleti).EndInit();
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceDebitiCompleti;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDebitiCompleti;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colImporto;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoPagato;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colRifDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCreato;
        private DevExpress.XtraGrid.Columns.GridColumn colPIva;
        private DevExpress.XtraGrid.Columns.GridColumn colCell;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFornitore;
    }
}