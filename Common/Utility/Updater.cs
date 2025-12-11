using DevExpress.XtraEditors;   // RELEASE
using Velopack;                 // RELEASE

namespace Common.Utility {
    public class Updater {
        public static async Task CheckUpdate(string updatePath) {
#if !DEBUG
            UpdateManager mgr = new UpdateManager(updatePath);
            UpdateInfo? nuovaVersione;

            // Controllo se è disponibile una nuova versione
            nuovaVersione = await mgr.CheckForUpdatesAsync();
            if (nuovaVersione == null) {
                XtraMessageBox.Show("Nessun aggiornamento disponibile.", "Aggiornamento App", MessageBoxButtons.OK);
                return;     // Nessun aggiornamento disponibile
            }

            if (XtraMessageBox.Show("Nuova versione disponibile.\nDesideri aggiornare?", "Aggiornamento App", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // Scarico l'aggiornamento
                await mgr.DownloadUpdatesAsync(nuovaVersione!);

                // Installi l'aggiornamento
                mgr.ApplyUpdatesAndRestart(nuovaVersione!);
            } else return;
#endif
        }
    }
}