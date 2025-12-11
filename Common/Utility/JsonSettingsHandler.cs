using System.IO;
using System.Text.Json;

namespace Common.Utility {
    public class JsonSettingsHandler {
        private static string settingsFilepath = Path.Combine(
            "C:",
            Properties.Settings.Default.CompanyName,
            Properties.Settings.Default.AppName,
            Properties.Settings.Default.SettingsFileName
        );

        private static Settings defaultSettings = new Settings {
            DatiAzienda = new DatiAzienda {
                AziendaNome = null,
                AziendaPIva = null,
                AziendaCodFis = null,
                AziendaIndirizzo = null,
                AziendaCell = null,
                AziendaTel = null,
                AziendaEMail = null,
                AziendaPec = null,
                AziendaIban = null,
                AziendaNomeBanca = null
            },
            UpdateSettings = new UpdateSettings { AutoUpdate = true }
        };

        public Settings settings = FetchSettings() ?? defaultSettings;

        public static Settings? FetchSettings() {
            // Se il file esiste leggo le impostazioni, sennò lo creo senza contenuto
            if (File.Exists(settingsFilepath)) {
                string jsonString = File.ReadAllText(settingsFilepath);
                Settings? fetchedSettings = JsonSerializer.Deserialize<Settings>(jsonString);

                return fetchedSettings;
            } else {
                File.Create(settingsFilepath).Close();

                string jsonString = JsonSerializer.Serialize(defaultSettings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(settingsFilepath, jsonString);

                return null;
            }
        }

        public void SaveSettings(Settings settings) {
            this.settings = settings;
            string jsonString = JsonSerializer.Serialize(this.settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsFilepath, jsonString);

            Console.WriteLine(File.ReadAllText(settingsFilepath));
        }
    }

    public class Settings {
        public DatiAzienda? DatiAzienda { get; set; }
        public required UpdateSettings UpdateSettings { get; set; }
    }

    public class DatiAzienda {
        public string? AziendaNome { get; set; }
        public string? AziendaPIva { get; set; }
        public string? AziendaCodFis {  get; set; }
        public string? AziendaIndirizzo { get; set; }
        public string? AziendaCell {  get; set; }
        public string? AziendaTel {  get; set; }
        public string? AziendaEMail { get; set; }
        public string? AziendaPec {  get; set; }
        public string? AziendaIban { get; set; }
        public string? AziendaNomeBanca { get; set; }
    }

    public class UpdateSettings {
        public required bool AutoUpdate { get; set; }
    }
}
