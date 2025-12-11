using Common.Utility;
using Common.Utility.Models;
using System.Diagnostics;

namespace FrontOffice.Forms.Ordini {
    public partial class ControlArticolo : DevExpress.XtraEditors.XtraUserControl {
        public ControlArticolo() {
            InitializeComponent();

            lookupFornitore.Properties.DataSource = ordiniHandler.GetFornitori().GetAwaiter().GetResult();
            lookupFornitore.Properties.DisplayMember = "Nome";
            lookupFornitore.Properties.ValueMember = "ID";
            lookupFornitore.EditValue = null;

            lookupFornitore.Properties.Columns.Clear();
            lookupFornitore.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome"));
        }

        // ATTRIBUTI
        public int NumArticolo {
            set {
                this.labelNumArticolo.Text = $"Articolo #{value}";
            }
        }

        public string CodValue = "";
        public string NomeValue = "";
        public int QuantValue = 1;
        public int? IDFornitore = null;
        public string NoteValue = "";

        private OrdiniHandler ordiniHandler = new OrdiniHandler();

        // EVENTI
        private void textCod_EditValueChanged(object sender, EventArgs e) {
            this.CodValue = textCod.Text;
        }

        private void textNome_EditValueChanged(object sender, EventArgs e) {
            this.NomeValue = textNome.Text;
        }

        private void spinQuant_EditValueChanged(object sender, EventArgs e) {
            this.QuantValue = Convert.ToInt32(spinQuant.Text);
        }

        private void txtNote_EditValueChanged(object sender, EventArgs e) {
            this.NoteValue = textNote.Text;
        }

        private void lookupFornitore_EditValueChanged(object sender, EventArgs e) {
            this.IDFornitore = (int)lookupFornitore.EditValue;
        }

        private async void lookupFornitore_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e) {
            Debug.WriteLine(e.DisplayValue.ToString());

            if (e.DisplayValue != null) {
                List<Fornitore> fornitori = (List<Fornitore>)lookupFornitore.Properties.DataSource;

                // Divido il nome dall'URL (separati dal carattere "|")
                string[] insertedString = (e.DisplayValue.ToString() ?? "").Split('|');
                string nomeFornitore;
                string? urlFornitore = null;

                if (insertedString.Length > 1) {
                    nomeFornitore = insertedString[0];
                    urlFornitore = insertedString[1];
                } else {
                    nomeFornitore = insertedString[0];
                }

                // Inserisco il fornitore a DB e ricarico la lista
                Fornitore newFornitore = new Fornitore(0, nomeFornitore, urlFornitore);
                int idNewFornitore = await ordiniHandler.AddFornitore(newFornitore);
                newFornitore.ID = idNewFornitore;
                fornitori.Add(newFornitore);
                lookupFornitore.EditValue = idNewFornitore;
            }
        }
    }
}
