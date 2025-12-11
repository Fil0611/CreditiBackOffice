using Common.Utility;
using Common.Utility.Models;

namespace FrontOffice.Forms.Ordini {
    public partial class NuovoOrdine : Form {
        public NuovoOrdine() {
            InitializeComponent();
        }

        // ATTRIBUTI
        private OrdiniHandler ordiniHandler = new OrdiniHandler();

        private int numArticoli = 1;

        // EVENTI
        private void buttonAddArticolo_Click(object sender, EventArgs e) {
            numArticoli++;

            int numControls = stackPanel1.Controls.Count;

            // Istanzio, configuro e aggiungo allo StackPanel il nuovo ControlArticolo
            var newArticolo = new ControlArticolo();
            newArticolo.NumArticolo = numArticoli;
            stackPanel1.Controls.Add(newArticolo);

            // Lo sposto prima del bottone
            Control addedControl = stackPanel1.Controls[numControls];
            stackPanel1.Controls.SetChildIndex(addedControl, numControls - 1);

            // Scorro fino a vederlo completamente
            stackPanel1.ScrollControlIntoView(addedControl);
        }

        private async void buttonCreateOrdine_Click(object sender, EventArgs e) {
            var ogControls = stackPanel1.Controls;
            ogControls.RemoveAt(ogControls.Count - 1);
            Control.ControlCollection controls = ogControls;

            List<Articolo> articoli = new List<Articolo>();

            foreach (ControlArticolo item in stackPanel1.Controls) {
                // Salto l'iterazione se un articolo non possiede i dettagli fondamentali
                if (
                    item.CodValue == "" &&
                    item.NomeValue == ""
                ) continue;

                // Aggiungo l'articolo alla List
                if (item != null) {
                    //Debug.WriteLine($"Cod: {item.CodValue} - Nome: {item.NomeValue} - Quant: {item.QuantValue} - Note: {item.NoteValue}");
                    articoli.Add(new Articolo(
                        item.CodValue != "" ? item.CodValue : null, 
                        item.NomeValue != "" ? item.NomeValue : null, 
                        item.QuantValue, 
                        item.IDFornitore, 
                        item.NoteValue != "" ? item.NoteValue : null
                    ));
                }
            }

            string? nomeCliente = textNome.Text != "" ? textNome.Text : null;
            string? cellCliente = textCell.Text != "" ? textCell.Text : null;
            string? note = textNote.Text != "" ? textNote.Text : null;
            Ordine ordine = new Ordine(nomeCliente, cellCliente, note);

            // Richiesta POST dell'ordine e dei suoi dettagli
            int? idOrdine = await ordiniHandler.AddOrdine(ordine);

            if (idOrdine != null && articoli.Count > 0) {
                // Richiesta POST degli articoli dell'ordine (se ne esistono)
                await ordiniHandler.AddArticoli(articoli, (int)idOrdine);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
