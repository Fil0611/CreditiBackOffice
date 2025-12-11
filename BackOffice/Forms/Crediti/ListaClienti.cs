using Common.Utility;
using Common.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using System.IO;

namespace BackOffice.Forms.Crediti {
    public partial class ListaClienti : Form {
        public ListaClienti() {
            InitializeComponent();
            UpdateGrid();
        }

        // ATTRIBUTI
        private int? idClienteSelezionato;
        private Cliente? clienteSelezionato;

        private enum SelectedTab {
            Clienti,
            Fornitori
        }
        private SelectedTab selectedTab = SelectedTab.Clienti;

        private JsonSettingsHandler settingsHandler = new();

        // METODI
        private void UpdateGrid() {
            sqlDataSourceListaClienti.Fill();
            sqlDataSourceListaFornitori.Fill();
        }


        // EVENTI
        private void barButtonAggiorna_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateGrid();
        }

        private void barButtonNuovoCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (var nuovoClienteForm = new NuovoCliente()) {

                nuovoClienteForm.IsFornitore = selectedTab == SelectedTab.Fornitori ? true : false;

                if (nuovoClienteForm.ShowDialog() == DialogResult.OK) {
                    int? IDNuovoCliente = nuovoClienteForm.IDNuovoCliente;
                    bool clienteIsFornitore = nuovoClienteForm.Fornitore;
                    //Debug.WriteLine(IDNuovoCliente.ToString());
                    UpdateGrid();

                    // Imposto la selezione e il focus sul nuovo cliente o fornitore
                    if (IDNuovoCliente != null) {
                        if (!clienteIsFornitore) {
                            tabPaneClientiFornitori.SelectedPageIndex = 0;

                            int handleNuovoCliente = gridClienti.LocateByValue("ID", (long)IDNuovoCliente);
                            Debug.WriteLine(handleNuovoCliente.ToString());

                            gridClienti.ClearSelection();
                            gridClienti.SelectRow(handleNuovoCliente);
                            gridClienti.FocusedRowHandle = handleNuovoCliente;
                            gridClienti.MakeRowVisible(handleNuovoCliente);
                        } else {
                            tabPaneClientiFornitori.SelectedPageIndex = 1;

                            int handleNuovoFornitore = gridFornitori.LocateByValue("ID", (long)IDNuovoCliente);
                            Debug.WriteLine(handleNuovoFornitore.ToString());

                            gridFornitori.ClearSelection();
                            gridFornitori.SelectRow(handleNuovoFornitore);
                            gridFornitori.FocusedRowHandle = handleNuovoFornitore;
                            gridFornitori.MakeRowVisible(handleNuovoFornitore);
                        }
                    }
                }
            }
        }

        private void barButtonAddTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DBHandler dbHandler = new DBHandler();
            dbHandler.TestInsert();
            UpdateGrid();
        }

        private void gridClienti_RowCountChanged(object sender, EventArgs e) {
            int rowCountClienti = gridClienti.RowCount;
            int rowCountFornitori = gridFornitori.RowCount;
            statusBarTextNumClienti.Caption = $"{rowCountClienti} Client{(rowCountClienti == 1 ? "e" : "i")}";
            statusBarTextNumFornitori.Caption = $"{rowCountFornitori} Fornitor{(rowCountFornitori == 1 ? "e" : "i")}";
        }

        private void barButtonElimina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            string confirmText = $"Sei sicuro di voler eliminare il cliente \"{clienteSelezionato!.Nome}\"?\nQuesta azione è irreversibile e eliminerà anche tutti i movimenti a esso associati.";
            if (XtraMessageBox.Show(confirmText, "Eliminare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (idClienteSelezionato != null) {
                    new DBHandler().RemoveCliente((int)idClienteSelezionato);
                    UpdateGrid();
                    gridClienti.ClearSelection();
                    gridClienti.SelectRow(0);
                    gridClienti.FocusedRowHandle = 0;
                    gridClienti.MakeRowVisible(0);
                }
                else {
                    // Mostro un dialog box dicente che c'è stato un errore
                }
            }
        }

        private void gridClienti_RowClick(object sender, RowClickEventArgs e) {
            GridView grid = new GridView();
            bool selectedIsFornitore = false;

            switch(selectedTab) {
                case SelectedTab.Clienti:
                    grid = gridClienti;
                    break;
                case SelectedTab.Fornitori:
                    grid = gridFornitori;
                    selectedIsFornitore = true;
                    break;
            }

            int selectedIDCliente = (int)(long)grid.GetRowCellValue(e.RowHandle, "ID");
            string selectedNome = (string)grid.GetRowCellValue(e.RowHandle, "Nome");
            string? selectedPIva = grid.GetRowCellValue(e.RowHandle, "PIva") == DBNull.Value ? null : (string)grid.GetRowCellValue(e.RowHandle, "PIva");
            string? selectedCell = grid.GetRowCellValue(e.RowHandle, "Cell") == DBNull.Value ? null : (string)grid.GetRowCellValue(e.RowHandle, "Cell");
            string? selectedTel = grid.GetRowCellValue(e.RowHandle, "Tel") == DBNull.Value ? null : (string)grid.GetRowCellValue(e.RowHandle, "Tel");
            string? selectedEMail = grid.GetRowCellValue(e.RowHandle, "EMail") == DBNull.Value ? null : (string)grid.GetRowCellValue(e.RowHandle, "EMail");
            string? selectedPec = grid.GetRowCellValue(e.RowHandle, "Pec") == DBNull.Value ? null : (string)grid.GetRowCellValue(e.RowHandle, "Pec");

            if (e.Clicks == 2 && e.Button == MouseButtons.Left) {
                // Apre la finestra dei movimenti del cliente/fornitore
                using (var movimentiClienteForm = new MovimentiCliente()) {
                    movimentiClienteForm.Cliente = new MovimentiCliente.ClienteRep(selectedIDCliente, selectedNome, selectedPIva, selectedCell, selectedEMail, selectedIsFornitore);
                    if (movimentiClienteForm.ShowDialog() == DialogResult.OK) {
                        UpdateGrid();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right) {
                popupMenuRow.ShowPopup(Control.MousePosition);
                switch (selectedTab) {
                    case SelectedTab.Clienti:
                        barButtonModificaCliente.Caption = "Modifica Cliente";
                        break;
                    case SelectedTab.Fornitori:
                        barButtonModificaCliente.Caption = "Modifica Fornitore";
                        break;
                }

                // Imposta il cliente selezionato
                idClienteSelezionato = selectedIDCliente;
                clienteSelezionato = new Cliente(selectedNome, selectedPIva, selectedCell, selectedTel, selectedEMail, selectedPec, selectedIsFornitore);
            }
        }

        private void barMenuButtonCreateBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Copia il database nella cartella C:\FilBatta\Crediti\Backup
            string srcFileName = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                Common.Properties.Settings.Default.DBFileName
            );
            string destFileName = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                "Backup",
                Common.Properties.Settings.Default.DBFileName
            );
            string destFolderName = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                "Backup"
            );

            if (!Directory.Exists(destFolderName)) Directory.CreateDirectory(destFolderName);
            File.Copy(srcFileName, destFileName, true);
            XtraMessageBox.Show("Backup Creato con successo.", "Creazione Backup", MessageBoxButtons.OK);
        }

        private void barMenuButtonRestoreBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            string srcFileName = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                "Backup",
                Common.Properties.Settings.Default.DBFileName
            );
            string destFileName = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                Common.Properties.Settings.Default.DBFileName
            );
            Debug.WriteLineIf(File.Exists(destFileName), "Esiste");
            if (File.Exists(destFileName)) {
                File.Copy(srcFileName, destFileName, true);
                XtraMessageBox.Show("Backup Ripristinato con successo.", "Ripristino Backup", MessageBoxButtons.OK);
            }
            else XtraMessageBox.Show("Il backup non esiste.\nImpossibile ripristinare il backup.", "Ripristino Backup", MessageBoxButtons.OK);
        }

        private void barButtonModificaCliente_ItemClick(object sender, ItemClickEventArgs e) {
            // Apro un form di modifica coi dati del cliente selezionato
            using (var modificaClienteForm = new ModificaCliente()) {
                if (idClienteSelezionato != null) {
                    modificaClienteForm.Cliente = new ModificaCliente.ClienteMod(
                        (int)idClienteSelezionato,
                        clienteSelezionato!.Nome,
                        clienteSelezionato.PIva,
                        clienteSelezionato.Cell,
                        clienteSelezionato.Tel,
                        clienteSelezionato.EMail,
                        clienteSelezionato.Pec
                    );

                    if (modificaClienteForm.ShowDialog() == DialogResult.OK) {
                        UpdateGrid();
                    }
                }
                else {
                    // Mostro un dialog box dicente che c'è stato un errore
                }
            }
        }

        private void barButtonCreditiCompleti_ItemClick(object sender, ItemClickEventArgs e) {
            switch (selectedTab) {
                case SelectedTab.Clienti:
                    using (var creditiCompletiForm = new CreditiCompleti()) {
                        if (creditiCompletiForm.ShowDialog() == DialogResult.OK) UpdateGrid();
                    }
                    break;
                case SelectedTab.Fornitori:
                    using (var debitiCompletiForm = new DebitiCompleti()) {
                        if (debitiCompletiForm.ShowDialog() == DialogResult.OK) UpdateGrid();
                    }
                    break;
            }
        }

        private void barMenuButtonAppInfo_ItemClick(object sender, ItemClickEventArgs e) {
            using (var appInfoForm = new AppInfo()) {
                appInfoForm.UpdatePath = Properties.Settings.Default.UpdatePath;
                appInfoForm.ShowDialog();
            }
        }

        private void barMenuButtonAppSettings_ItemClick(object sender, ItemClickEventArgs e) {
            using (var appSettingsForm = new AppSettings()) {
                appSettingsForm.updatePath = Properties.Settings.Default.UpdatePath;
                appSettingsForm.ShowDialog();
            }
        }

        private async void ListaClienti_Load(object sender, EventArgs e) {
            if (settingsHandler.settings.UpdateSettings.AutoUpdate) await Updater.CheckUpdate(Properties.Settings.Default.UpdatePath);
        }

        private void tabPaneClientiFornitori_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            Debug.WriteLine(e.Page.Caption);

            if (e.Page.Caption == "Clienti") {
                this.selectedTab = SelectedTab.Clienti;

                statusBarTextNumClienti.Visibility = BarItemVisibility.Always;
                statusBarTextNumFornitori.Visibility = BarItemVisibility.Never;

                barButtonNuovoCliente.Caption = "Nuovo Cliente";
                barButtonCreditiCompleti.Caption = "Crediti Completi";
            } else if (e.Page.Caption == "Fornitori") {
                this.selectedTab = SelectedTab.Fornitori;

                statusBarTextNumFornitori.Visibility = BarItemVisibility.Always;
                statusBarTextNumClienti.Visibility = BarItemVisibility.Never;

                barButtonNuovoCliente.Caption = "Nuovo Fornitore";
                barButtonCreditiCompleti.Caption = "Debiti Completi";
            }
        }
    }
}
