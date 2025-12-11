using Common.Utility;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace BackOffice.Forms.Crediti {
    public partial class NuovoCliente : Form {
        public NuovoCliente() {
            InitializeComponent();
        }

        public int? IDNuovoCliente { get; private set; }
        public bool Fornitore { get; private set; } = false;    // Contiene lo stato effettivo del cliente
        
        public bool IsFornitore {                               // Serve per impostare lo stato inziale del toggle
            private get => IsFornitore;
            set {
                toggleClienteIsFornitore.IsOn = value;
                if (value) this.Text = "Nuovo Fornitore";
            }
        }

        private void buttonNuovoClienteAnnulla_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonNuovoClienteAggiungi_Click(object sender, EventArgs e) {
            // Controllo che i campi obbligatori contengano valori, sennò avviso l'utente
            if (string.IsNullOrWhiteSpace(textNuovoClienteNome.Text)) {
                TextFieldUtilities.FlashBackground(textNuovoClienteNome);
                return;
            }

            var dbHandler = new DBHandler();

            // Controllo che la P. IVA non esista già in DB
            if (dbHandler.ClientePIvaExists(textNuovoClientePIva.Text)) {
                XtraMessageBox.Show("Il cliente con la P. IVA specificata esiste già.", "Nuovo Cliente", MessageBoxButtons.OK);
                TextFieldUtilities.FlashBackground(textNuovoClientePIva);
                return;
            }

            // Inizializzo il nuovo cliente
            Cliente nuovoCliente = new(
                textNuovoClienteNome.Text,
                textNuovoClientePIva.Text,
                textNuovoClienteCell.Text,
                textNuovoClienteTel.Text,
                textNuovoClienteEMail.Text,
                textNuovoClientePec.Text,
                Fornitore
            );

            this.IDNuovoCliente = dbHandler.AddCliente(nuovoCliente);
            Debug.WriteLine($"IDNuovoCliente: {IDNuovoCliente} - Fornitore?: {Fornitore}");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toggleClienteIsFornitore_Toggled(object sender, EventArgs e) {
            if (toggleClienteIsFornitore.IsOn) {
                this.Text = "Nuovo Fornitore";
            } else {
                this.Text = "Nuovo Cliente";
            }

            Fornitore = toggleClienteIsFornitore.IsOn;
        }
    }
}
