using Common.Utility;
using DevExpress.XtraEditors;
using System.IO;

namespace Common.Forms {
    public partial class AppSettings : Form {
        public AppSettings() {
            InitializeComponent();

            // Carico le impostazioni
            //JsonSettingsHandler settingsHandler = new();
            // - Aggiornamenti
            checkAutoUpdate.Checked = settingsHandler.settings.UpdateSettings.AutoUpdate;

            // - Info Azienda
            textNome.Text = settingsHandler.settings.DatiAzienda.AziendaNome ?? "";
            textIndirizzo.Text = settingsHandler.settings.DatiAzienda.AziendaIndirizzo;
            textPIva.Text = settingsHandler.settings.DatiAzienda.AziendaPIva;
            textCodFis.Text = settingsHandler.settings.DatiAzienda.AziendaCodFis;
            textTel.Text = settingsHandler.settings.DatiAzienda.AziendaTel;
            textCell.Text = settingsHandler.settings.DatiAzienda.AziendaCell;
            textEMail.Text = settingsHandler.settings.DatiAzienda.AziendaEMail;
            textPec.Text = settingsHandler.settings.DatiAzienda.AziendaPec;
            textIban.Text = settingsHandler.settings.DatiAzienda.AziendaIban;
            if (File.Exists(logoFilePath)) pictureLogo.Image = Image.FromFile(logoFilePath);
        }

        // ATTRIBUTI
        private JsonSettingsHandler settingsHandler = new();

        public string updatePath;

        private string logoFilePath = Path.Combine(
            "C:",
            Properties.Settings.Default.CompanyName,
            Properties.Settings.Default.AppName,
            Properties.Settings.Default.AziendaLogoFileName
        );

        // METODI
        private void SalvaImpostazioni() {
            // Salvo le impostazioni
            settingsHandler.SaveSettings(new Settings {
                DatiAzienda = new DatiAzienda {
                    AziendaNome = textNome.Text,
                    AziendaIndirizzo = textIndirizzo.Text,
                    AziendaPIva = textPIva.Text,
                    AziendaCodFis = textCodFis.Text,
                    AziendaTel = textTel.Text,
                    AziendaCell = textCell.Text,
                    AziendaEMail = textEMail.Text,
                    AziendaPec = textPec.Text,
                    AziendaIban = textIban.Text,
                    AziendaNomeBanca = ""
                },
                UpdateSettings = new UpdateSettings {
                    AutoUpdate = checkAutoUpdate.Checked
                }
            });

            // Salvo il logo
            if (pictureLogo.Image != null) {
                pictureLogo.Image.Save(logoFilePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        // EVENTI
        private void buttonSave_Click(object sender, EventArgs e) {
            SalvaImpostazioni();

            if (XtraMessageBox.Show("Impostazioni salvate con successo", "Impostazioni", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
        }

        private async void buttonCheckUpdates_Click(object sender, EventArgs e) {
            SalvaImpostazioni();

            await Updater.CheckUpdate(updatePath);
        }
    }
}
