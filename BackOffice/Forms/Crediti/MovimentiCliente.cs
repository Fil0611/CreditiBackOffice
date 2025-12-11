using Crediti.Reports;
using Common.Utility;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace BackOffice.Forms.Crediti {
    public partial class MovimentiCliente : Form {
        public MovimentiCliente() {
            InitializeComponent();
        }

        [method: SetsRequiredMembers]
        public class ClienteRep(int IDCliente, string Nome, string? PIva, string? Cell, string? EMail, bool IsFornitore) {
            public required int IDCliente { get; set; } = IDCliente;
            public required string Nome { get; set; } = Nome;
            public string? PIva { get; set; } = PIva;
            public string? Cell { get; set; } = Cell;
            public string? EMail { get; set; } = EMail;
            public bool IsFornitore { get; set; } = IsFornitore;
        }

        // ATTRIBUTI
        private ClienteRep? _cliente;
        public ClienteRep Cliente {
            get => _cliente ?? new ClienteRep(0, "", null, null, null, false);
            set {
                _cliente = value;
                sqlDataSourceMovimentiCliente.Queries[0].Parameters["IDClienteSelezionato"].Value = (int)_cliente.IDCliente;
                sqlDataSourceMovimentiCliente.Queries[0].Validate();
                LinkDB();

                labelNomeCliente.Text = _cliente.Nome;
                labelPIvaCliente.Text = $"P. IVA: {_cliente.PIva}";
                labelEMailCliente.Text = $"E-Mail: {_cliente.EMail}";
                labelCellCliente.Text = $"Cell: {_cliente.Cell}";

                if (_cliente.IsFornitore) {
                    this.Text = "Movimenti Fornitore";
                    barButtonReportCliente.Caption = "Report Fornitore";
                }
            }
        }

        private DataTable dtMovimenti = new DataTable();

        private int? idMovimentoSelezionato;

        private int closedRows = 0;
        private int rowCount = 0;

        private JsonSettingsHandler settingsHandler = new();

        // METODI
        private void LinkDB() {
            dtMovimenti.Columns.Add("ID", typeof(int));
            dtMovimenti.Columns.Add("IDCliente", typeof(int));
            dtMovimenti.Columns.Add("Importo", typeof(float));
            dtMovimenti.Columns.Add("ImportoPagato", typeof(float));
            dtMovimenti.Columns.Add("RifDoc", typeof(string));
            dtMovimenti.Columns.Add("DataCreato", typeof(DateOnly));
            dtMovimenti.Columns.Add("DataChiuso", typeof(DateOnly));
            dtMovimenti.Columns.Add("IsChiuso", typeof(bool));

            UpdateDataTable();

            gridControl1.DataSource = dtMovimenti;
        }

        private void UpdateDataTable() {
            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM Movimenti WHERE IDCliente = {_cliente!.IDCliente}";

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        int id = reader.GetInt32(0);
                        int idC = reader.GetInt32(1);
                        float? importo = reader.IsDBNull(2) ? null : reader.GetFloat(2);
                        float? importoPagato = reader.IsDBNull(3) ? null : reader.GetFloat(3);
                        string? rifDoc = reader.IsDBNull(4) ? null : reader.GetString(4);
                        DateOnly dataCreato = DateOnly.FromDateTime(reader.GetDateTime(5));
                        DateOnly? dataChiuso = reader.IsDBNull(6) ? null : DateOnly.FromDateTime(reader.GetDateTime(6));
                        bool isChiuso = reader.GetBoolean(7);
                        dtMovimenti.Rows.Add(id, idC, importo, importoPagato, rifDoc, dataCreato, dataChiuso, isChiuso);

                    }
                    dtMovimenti.AcceptChanges();

                }
            }
        }

        private void SaveChanges() {
            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                //conn.DefaultTimeout = 30;
                conn.Open();

                foreach (DataRow row in dtMovimenti.Rows) {
                    // Recupero dei dati della riga
                    List<string> consideredUpdateColsValues = [];
                    List<string> consideredAddCols = [];
                    List<string> consideredAddValues = [];

                    foreach (DataColumn col in row.Table.Columns) {
                        if (col.ColumnName == "ID" || col.ColumnName == "IDCliente") continue;       // Salto la colonna dell'ID e dell'IDCliente

                        // Cella modificata - SI POTREBBE RISCRIVERE PER RENDERE IL CODICE PIU' EFFICIENTE
                        if (row.RowState == DataRowState.Modified && (col.ColumnName == "IsChiuso" || !Equals(row[col], row[col, DataRowVersion.Original]))) {
                            if (col.ColumnName == "DataCreato" || col.ColumnName == "DataChiuso") {
                                if (row[col] != DBNull.Value) {
                                    DateOnly date = (DateOnly)row[col];
                                    consideredUpdateColsValues.Add($"{col.ColumnName}={string.Concat("\"", date.ToString("o", CultureInfo.InvariantCulture), "\"")}");
                                }
                                else consideredUpdateColsValues.Add($"{col.ColumnName}=NULL");
                            }
                            else if (col.ColumnName == "Importo" || col.ColumnName == "ImportoPagato") {
                                if (row[col] != DBNull.Value) {
                                    float value = (float)row[col];
                                    consideredUpdateColsValues.Add($"{col.ColumnName}={value.ToString("0.00", CultureInfo.InvariantCulture)}");
                                }
                                else consideredUpdateColsValues.Add($"{col.ColumnName}=NULL");
                            }
                            else if (col.ColumnName == "RifDoc") consideredUpdateColsValues.Add($"{col.ColumnName}=\"{row[col]}\"");
                            else if (col.ColumnName == "IsChiuso") consideredUpdateColsValues.Add($"{col.ColumnName}={((bool)row[col] ? 1 : 0)}");
                            else consideredUpdateColsValues.Add($"{col.ColumnName}={row[col].ToString()}");
                        }

                        // Riga aggiunta, controllo se il valore non è aggiunto così che il database assegni i valori default
                        if (row[col] != DBNull.Value) {
                            consideredAddCols.Add(col.ColumnName);

                            if (col.ColumnName == "Importo" || col.ColumnName == "ImportoPagato") {
                                float value = (float)row[col];
                                consideredAddValues.Add(value.ToString("0.00", CultureInfo.InvariantCulture));
                            }
                            else if (col.ColumnName == "DataCreato" || col.ColumnName == "DataChiuso") {
                                DateOnly date = (DateOnly)row[col];
                                consideredAddValues.Add($"\"{date.ToString("o", CultureInfo.InvariantCulture)}\"");
                            }
                            else if (col.ColumnName == "RifDoc") consideredAddValues.Add($"\"{row[col]}\"");
                            else if (col.ColumnName == "IsChiuso") consideredAddValues.Add($"{((bool)row[col] ? 1 : 0)}");
                            else consideredAddValues.Add(row[col].ToString() ?? "NULL");
                        }
                    }

                    using var cmd = conn.CreateCommand();

                    switch (row.RowState) {
                        case DataRowState.Added:
                            string addQuery = $"INSERT INTO Movimenti (IDCliente, {string.Join(", ", consideredAddCols)}) VALUES ({_cliente.IDCliente}, {string.Join(", ", consideredAddValues)})";
                            Debug.WriteLine($"QUERY -> {addQuery}");

                            // Aggiungo la riga
                            cmd.CommandText = addQuery;
                            cmd.ExecuteNonQuery();

                            break;
                        case DataRowState.Modified:
                            string updateQuery = $"UPDATE Movimenti SET {string.Join(", ", consideredUpdateColsValues)} WHERE ID = {row["ID"]}";
                            Debug.WriteLine($"QUERY -> {updateQuery}");

                            // Modifico la riga
                            if (consideredUpdateColsValues.Count != 0) {
                                cmd.CommandText = updateQuery;
                                cmd.ExecuteNonQuery();
                            }

                            break;
                        case DataRowState.Deleted:
                            string deleteQuery = $"DELETE FROM Movimenti WHERE ID = {row["ID"]}";
                            Debug.WriteLine($"QUERY -> {deleteQuery}");

                            // Elimino la riga
                            cmd.CommandText = deleteQuery;
                            cmd.ExecuteNonQuery();

                            break;
                    }

                    Debug.WriteLine($"ID: {row["ID"]}\tState: {row.RowState}");
                }

                dtMovimenti.AcceptChanges();
            }
        }

        private DataTable GetMovimentiByCliente(int idCliente) {
            var movimentiTable = new DataTable("Movimenti");

            movimentiTable.Columns.Add("Importo", typeof(float));
            movimentiTable.Columns.Add("ImportoPagato", typeof(float));
            movimentiTable.Columns.Add("RifDoc", typeof(string));
            movimentiTable.Columns.Add("DataCreato", typeof(DateOnly));
            movimentiTable.Columns.Add("DataChiuso", typeof(DateOnly));
            movimentiTable.Columns.Add("IsChiuso", typeof(bool));

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT Importo, ImportoPagato, RifDoc, DataCreato, DataChiuso, IsChiuso
                    FROM Movimenti
                    WHERE IDCliente = @idCliente
                ";
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        movimentiTable.Rows.Add(
                            reader.IsDBNull(0) ? 0.0 : reader.GetFloat(0),                              // Importo
                            reader.IsDBNull(1) ? 0.0 : reader.GetFloat(1),                              // ImportoPagato
                            reader.IsDBNull(2) ? null : reader.GetString(2),                            // RifDoc
                            reader.IsDBNull(3) ? null : DateOnly.FromDateTime(reader.GetDateTime(3)),   // DataCreato
                            reader.IsDBNull(4) ? null : DateOnly.FromDateTime(reader.GetDateTime(4)),   // DataChiuso
                            reader.IsDBNull(5) ? false : reader.GetBoolean(5)                           // IsChiuso
                        );
                    }
                }
            }

            return movimentiTable;
        }

        private void PresentReportCliente() {
            var report = new ReportCliente();

            report.IsReportFornitore = _cliente.IsFornitore;

            // Imposto i valori di esportazione del report
            report.DisplayName = $"Report{_cliente!.Nome.Trim().Replace(" ", "").ToLower()}";
            report.ExportOptions.Email.RecipientName = _cliente.Nome;
            if (_cliente.EMail != null) report.ExportOptions.Email.RecipientAddress = _cliente.EMail;
            report.ExportOptions.Email.Subject = "Estratto Conto";
            report.ExportOptions.Email.Body = $"Allegato estratto conto.\n\nCordiali saluti.\n\n{settingsHandler.settings.DatiAzienda.AziendaNome}";

            // Imposto i parametri manualmente
            // - Azienda
            report.Parameters["AziendaNome"].Value = settingsHandler.settings.DatiAzienda.AziendaNome;
            report.Parameters["AziendaIndirizzo"].Value = settingsHandler.settings.DatiAzienda.AziendaIndirizzo;
            report.Parameters["AziendaPIva"].Value = settingsHandler.settings.DatiAzienda.AziendaPIva;
            report.Parameters["AziendaCodFis"].Value = settingsHandler.settings.DatiAzienda.AziendaCodFis;
            report.Parameters["AziendaIban"].Value = settingsHandler.settings.DatiAzienda.AziendaIban;
            report.Parameters["AziendaTel"].Value = settingsHandler.settings.DatiAzienda.AziendaTel;
            report.Parameters["AziendaCell"].Value = settingsHandler.settings.DatiAzienda.AziendaCell;
            report.Parameters["AziendaEMail"].Value = settingsHandler.settings.DatiAzienda.AziendaEMail;

            // - Cliente
            report.Parameters["Nome"].Value = _cliente.Nome;
            report.Parameters["PIva"].Value = _cliente.PIva;
            report.Parameters["Cell"].Value = _cliente.Cell;
            report.Parameters["EMail"].Value = _cliente.EMail;

            // Nascondo i parametri
            // - Azienda
            report.Parameters["AziendaNome"].Visible = false;
            report.Parameters["AziendaIndirizzo"].Visible = false;
            report.Parameters["AziendaPIva"].Visible = false;
            report.Parameters["AziendaCodFis"].Visible = false;
            report.Parameters["AziendaIban"].Visible = false;
            report.Parameters["AziendaTel"].Visible = false;
            report.Parameters["AziendaCell"].Visible = false;
            report.Parameters["AziendaEMail"].Visible = false;

            // - Cliente
            report.Parameters["Nome"].Visible = false;
            report.Parameters["PIva"].Visible = false;
            report.Parameters["Cell"].Visible = false;
            report.Parameters["EMail"].Visible = false;

            // Imposto la tabella movimenti come DataSource
            var movimentiTable = GetMovimentiByCliente(_cliente.IDCliente);
            report.DataSource = movimentiTable;

            // Disattivo la finestra dei parametri
            report.RequestParameters = false;

            // Mostro il report
            var printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreviewDialog();
        }

        private void UpdateStatusBarTexts() {
            closedRows = rowCount = 0;
            foreach (DataRow row in dtMovimenti.Rows) if (row["IsChiuso"] != DBNull.Value && (bool)row["IsChiuso"]) closedRows++;
            rowCount = dtMovimenti.Rows.Count;
            statusBarTextNumMovimenti.Caption = $"{rowCount} Moviment{(rowCount == 1 ? "o" : "i")}";
            statusBarTextNumMovimentiChiusi.Caption = $"{closedRows} Chius{(closedRows == 1 ? "o" : "i")}";
        }

        //EVENTI
        private void MovimentiCliente_FormClosing(object sender, FormClosingEventArgs e) {
            SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void gridTest_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            Debug.WriteLine("--- VALIDATE ROWS ---");

            // L'utente ha confermato la riga quindi imposto DataCreato al giorno odierno
            DataRow row = gridMovimenti.GetDataRow(e.RowHandle);
            if (row["DataCreato"] == DBNull.Value) row["DataCreato"] = DateOnly.FromDateTime(DateTime.Now);

            UpdateStatusBarTexts();
        }

        private void gridMovimenti_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            Debug.WriteLine("--- CELL VALUE CHANGING ---");

            // Controllo se il valore cambiato è quello della colonna IsChiuso, nel caso imposto la data di chiusura (solo se la data di chiusura non è già presente)
            //var gridRow = gridMovimenti.GetRow(e.RowHandle);
            DataRow row = gridMovimenti.GetDataRow(e.RowHandle);

            if (e.Column.Name == "colIsChiuso") {
                if((bool)e.Value) {
                    if (row["DataChiuso"] == DBNull.Value) row["DataChiuso"] = DateOnly.FromDateTime(DateTime.Now);
                    row["ImportoPagato"] = row["Importo"];
                } else {
                    row["ImportoPagato"] = DBNull.Value;
                }

                row["IsChiuso"] = e.Value;
            }

            UpdateStatusBarTexts();
        }

        private void gridMovimenti_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e) {
            object rowCellValue = gridMovimenti.GetRowCellValue(e.RowHandle, "IsChiuso");

            if (rowCellValue != DBNull.Value && Convert.ToBoolean(rowCellValue)) {
                //Colore testo attenuato
                e.Appearance.ForeColor = Color.Gray;

                // Testo in corsivo
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic);
            }
        }

        private void barButtonReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SaveChanges();

            if (dtMovimenti.Rows.Count > 0) {
                if (!String.IsNullOrWhiteSpace(settingsHandler.settings.DatiAzienda.AziendaNome)) PresentReportCliente();
                else XtraMessageBox.Show("Non è possibile generare il report.\nNon sono stati specificati i dati aziendali.\nRecarsi nelle Impostazioni e poi riprovare.", $"Report {(_cliente.IsFornitore ? "Fornitore" : "Cliente")}", MessageBoxButtons.OK);
            } else XtraMessageBox.Show($"Non è possibile generare il report.\nIl {(_cliente.IsFornitore ? "fornitore" : "cliente")} non possiede movimenti a suo nome.", $"Report {(_cliente.IsFornitore ? "Fornitore" : "Cliente")}", MessageBoxButtons.OK);
        }

        private void gridMovimenti_RowCountChanged(object sender, EventArgs e) {
            UpdateStatusBarTexts();
        }

        private void gridMovimenti_KeyDown(object sender, KeyEventArgs e) {
            // Valida la riga premendo invio
            if (e.KeyCode == Keys.Enter) {
                gridMovimenti.CloseEditor();
                gridMovimenti.UpdateCurrentRow();
                e.Handled = true;
            }
        }

        private void gridMovimenti_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            int selectedIDMovimento = (int)gridMovimenti.GetRowCellValue(e.RowHandle, "ID");
            if (e.Button == MouseButtons.Right) {
                popupMenuRow.ShowPopup(Control.MousePosition);
                idMovimentoSelezionato = selectedIDMovimento;
            }
        }

        private void barButtonDeleteMovimento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            string confirmText = $"Sei sicuro di voler eliminare il movimento?\nQuesta azione è irreversibile.";
            if (XtraMessageBox.Show(confirmText, "Eliminare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (idMovimentoSelezionato != null) {
                    new DBHandler().RemoveMovimento((int)idMovimentoSelezionato);

                    dtMovimenti = new DataTable();
                    LinkDB();
                }
                else {
                    // Mostro un dialog box dicente che c'è stato un errore
                }
            }
        }
    }
}
