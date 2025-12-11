using Common.Utility;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace BackOffice.Forms.Crediti {
    public partial class ModificaCliente : Form {
        public ModificaCliente() {
            InitializeComponent();
        }

        [method: SetsRequiredMembers]
        public class ClienteMod(int IDCliente, string Nome, string? PIva, string? Cell, string? Tel, string? EMail, string? Pec) {
            public required int IDCliente { get; set; } = IDCliente;
            public required string Nome { get; set; } = Nome;
            public string? PIva { get; set; } = PIva;
            public string? Cell { get; set; } = Cell;
            public string? Tel { get; set; } = Tel;
            public string? EMail { get; set; } = EMail;
            public string? Pec { get; set; } = Pec;
        }

        // ATTRIBUTI
        private ClienteMod? _cliente;
        public ClienteMod Cliente {
            get => _cliente ?? new ClienteMod(0, "", null, null, null, null, null);
            set {
                _cliente = value;

                textModificaClienteNome.Text = _cliente.Nome;
                textModificaClientePIva.Text = _cliente.PIva;
                textModificaClienteCell.Text = _cliente.Cell;
                textModificaClienteTel.Text = _cliente.Tel;
                textModificaClienteEMail.Text = _cliente.EMail;
                textModificaClientePec.Text = _cliente.Pec;
            }
        }
        

        // EVENTI
        private void buttonModificaClienteModifica_Click(object sender, EventArgs e) {
            // Controllo quali valori sono stati cambiati
            List<string> consideredChangedValues = [];

            if (textModificaClienteNome.Text != _cliente!.Nome) consideredChangedValues.Add($"Nome=\"{textModificaClienteNome.Text}\"");
            if (textModificaClientePIva.Text != _cliente!.PIva) consideredChangedValues.Add($"PIva=\"{textModificaClientePIva.Text}\"");
            if (textModificaClienteCell.Text != _cliente!.Cell) consideredChangedValues.Add($"Cell=\"{textModificaClienteCell.Text}\"");
            if (textModificaClienteTel.Text != _cliente!.Tel) consideredChangedValues.Add($"Tel=\"{textModificaClienteTel.Text}\"");
            if (textModificaClienteEMail.Text != _cliente!.EMail) consideredChangedValues.Add($"EMail=\"{textModificaClienteEMail.Text}\"");
            if (textModificaClientePec.Text != _cliente!.Pec) consideredChangedValues.Add($"Pec=\"{textModificaClientePec.Text}\"");

            // Eseguo la query per la modifica del cliente
            string modClienteQuery = $"UPDATE Clienti SET {string.Join(", ", consideredChangedValues)} WHERE ID = {_cliente.IDCliente}";
            Debug.WriteLine(modClienteQuery);

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = modClienteQuery;
                cmd.ExecuteNonQuery();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonModificaClienteAnnulla_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
