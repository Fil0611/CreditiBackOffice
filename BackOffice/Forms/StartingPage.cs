using BackOffice.Forms.Crediti;
using BackOffice.Forms.Ordini;

namespace BackOffice.Forms {
    public partial class StartingPage : Form {
        public StartingPage() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            using (var FormCrediti = new ListaClienti()) {
                FormCrediti.ShowDialog();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            using (var FormOrdini = new ListaOrdini()) {
                FormOrdini.ShowDialog();
            }
        }
    }
}
