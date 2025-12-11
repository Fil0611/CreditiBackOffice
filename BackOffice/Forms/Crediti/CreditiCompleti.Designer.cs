namespace BackOffice.Forms.Crediti {
    partial class CreditiCompleti {
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
            DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters sqLiteConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditiCompleti));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            sqlDataSourceCreditiCompleti = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            gridViewCreditiCompleti = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)gridViewCreditiCompleti).BeginInit();
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
            // gridControl1
            // 
            gridControl1.DataMember = "Clienti";
            gridControl1.DataSource = sqlDataSourceCreditiCompleti;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 20);
            gridControl1.MainView = gridViewCreditiCompleti;
            gridControl1.MenuManager = barManager1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1550, 659);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCreditiCompleti });
            // 
            // sqlDataSourceCreditiCompleti
            // 
            sqlDataSourceCreditiCompleti.ConnectionName = "database";
            sqLiteConnectionParameters1.FileName = "C:\\FilBatta\\Crediti\\database.db";
            sqlDataSourceCreditiCompleti.ConnectionParameters = sqLiteConnectionParameters1;
            sqlDataSourceCreditiCompleti.Name = "sqlDataSourceCreditiCompleti";
            columnExpression1.ColumnName = "ID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"238\" />";
            table1.Name = "Clienti";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Nome";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "IDMovimento";
            columnExpression3.ColumnName = "ID";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"238\" />";
            table2.Name = "Movimenti";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Importo";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "ImportoPagato";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "RifDoc";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "DataCreato";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "PIva";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Cell";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "EMail";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "IsFornitore";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.FilterString = "[Movimenti.IsChiuso] = False And [Clienti.IsFornitore] = False";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "Clienti";
            relationColumnInfo1.NestedKeyColumn = "IDCliente";
            relationColumnInfo1.ParentKeyColumn = "ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            sqlDataSourceCreditiCompleti.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { selectQuery1 });
            sqlDataSourceCreditiCompleti.ResultSchemaSerializable = resources.GetString("sqlDataSourceCreditiCompleti.ResultSchemaSerializable");
            // 
            // gridViewCreditiCompleti
            // 
            gridViewCreditiCompleti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colNome, colIDMovimento, colImporto, colImportoPagato, colSaldo, colRifDoc, colDataCreato, colPIva, colCell, colEMail, colIsFornitore });
            gridViewCreditiCompleti.GridControl = gridControl1;
            gridViewCreditiCompleti.GroupPanelText = "Premere sulla Lente di Ingrandimento per cercare un Cliente →";
            gridViewCreditiCompleti.Name = "gridViewCreditiCompleti";
            gridViewCreditiCompleti.OptionsBehavior.Editable = false;
            gridViewCreditiCompleti.OptionsView.ShowFooter = true;
            gridViewCreditiCompleti.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colNome, DevExpress.Data.ColumnSortOrder.Ascending) });
            gridViewCreditiCompleti.RowClick += gridViewCreditiCompleti_RowClick;
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
            // CreditiCompleti
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
            Name = "CreditiCompleti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crediti Completi";
            FormClosing += CreditiCompleti_FormClosing;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCreditiCompleti).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCreditiCompleti;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceCreditiCompleti;
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