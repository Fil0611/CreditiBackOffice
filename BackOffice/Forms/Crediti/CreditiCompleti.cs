namespace BackOffice.Forms.Crediti {
    public partial class CreditiCompleti : Form {
        public CreditiCompleti() {
            InitializeComponent();
            UpdateGrid();
        }

        // METODI
        private void UpdateGrid() {
            sqlDataSourceCreditiCompleti.Fill();
        }

        // EVENTI
        private void gridViewCreditiCompleti_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            int rowHandle = e.RowHandle;

            if (e.Clicks == 2 && e.Button == MouseButtons.Left) {
                int selectedIDCliente = (int)(long)gridViewCreditiCompleti.GetRowCellValue(rowHandle, "ID");
                string selectedNome = (string)gridViewCreditiCompleti.GetRowCellValue(rowHandle, "Nome");
                string? selectedPIva = gridViewCreditiCompleti.GetRowCellValue(rowHandle, "PIva") == DBNull.Value ? null : (string)gridViewCreditiCompleti.GetRowCellValue(rowHandle, "PIva");
                string? selectedCell = gridViewCreditiCompleti.GetRowCellValue(rowHandle, "Cell") == DBNull.Value ? null : (string)gridViewCreditiCompleti.GetRowCellValue(rowHandle, "Cell");
                string? selectedEMail = gridViewCreditiCompleti.GetRowCellValue(rowHandle, "EMail") == DBNull.Value ? null : (string)gridViewCreditiCompleti.GetRowCellValue(rowHandle, "EMail");

                // Apre la finestra dei movimenti del cliente
                using (var movimentiClienteForm = new MovimentiCliente()) {
                    movimentiClienteForm.Cliente = new MovimentiCliente.ClienteRep(selectedIDCliente, selectedNome, selectedPIva, selectedCell, selectedEMail, false);
                    if (movimentiClienteForm.ShowDialog() == DialogResult.OK) {
                        UpdateGrid();
                    }
                }
            }
        }

        private void CreditiCompleti_FormClosing(object sender, FormClosingEventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
    }
}
