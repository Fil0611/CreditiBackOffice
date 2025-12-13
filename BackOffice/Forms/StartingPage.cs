using BackOffice.Forms.Crediti;
using BackOffice.Forms.Ordini;
using Common.Utility;

namespace BackOffice.Forms {
    public partial class StartingPage : Form {
        public StartingPage() {
            InitializeComponent();
        }

        // ATTRIBUTI
        private JsonSettingsHandler settingsHandler = new();

        // EVENTI
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

        private async void StartingPage_Load(object sender, EventArgs e) {
            if (settingsHandler.settings.UpdateSettings.AutoUpdate) await Updater.CheckUpdate(Properties.Settings.Default.UpdatePath);
        }
    }
}
