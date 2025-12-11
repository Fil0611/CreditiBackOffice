namespace BackOffice.Forms.Crediti {
    public partial class DebitiCompleti : Form {
        public DebitiCompleti() {
            InitializeComponent();
            UpdateGrid();
        }

        // METODI
        private void UpdateGrid() {
            sqlDataSourceDebitiCompleti.Fill();
        }

        private void DebitiCompleti_FormClosing(object sender, FormClosingEventArgs e) {
            this.DialogResult = DialogResult.OK;
        }

        private void gridViewDebitiCompleti_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            int rowHandle = e.RowHandle;

            if (e.Clicks == 2 && e.Button == MouseButtons.Left) {
                int selectedIDFornitore = (int)(long)gridViewDebitiCompleti.GetRowCellValue(rowHandle, "ID");
                string selectedNome = (string)gridViewDebitiCompleti.GetRowCellValue(rowHandle, "Nome");
                string? selectedPIva = gridViewDebitiCompleti.GetRowCellValue(rowHandle, "PIva") == DBNull.Value ? null : (string)gridViewDebitiCompleti.GetRowCellValue(rowHandle, "PIva");
                string? selectedCell = gridViewDebitiCompleti.GetRowCellValue(rowHandle, "Cell") == DBNull.Value ? null : (string)gridViewDebitiCompleti.GetRowCellValue(rowHandle, "Cell");
                string? selectedEMail = gridViewDebitiCompleti.GetRowCellValue(rowHandle, "EMail") == DBNull.Value ? null : (string)gridViewDebitiCompleti.GetRowCellValue(rowHandle, "EMail");

                // Apre la finestra dei movimenti del cliente
                using (var movimentiClienteForm = new MovimentiCliente()) {
                    movimentiClienteForm.Cliente = new MovimentiCliente.ClienteRep(selectedIDFornitore, selectedNome, selectedPIva, selectedCell, selectedEMail, true);
                    if (movimentiClienteForm.ShowDialog() == DialogResult.OK) {
                        UpdateGrid();
                    }
                }
            }
        }
    }
}
