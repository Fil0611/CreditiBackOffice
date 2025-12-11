using System.Reflection;
using Velopack;

namespace Common.Forms {
    public partial class AppInfo : Form {
        public AppInfo() {
            InitializeComponent();

            // Imposto il numero di versione
            /*string version = new UpdateManager(UpdatePath).CurrentVersion?.ToString() ?? Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "";
            labelAppVersion.Text = $"Versione {version}";*/
        }

        public string UpdatePath { set {
                // Imposto il numero di versione
                string version = new UpdateManager(value).CurrentVersion?.ToString() ?? Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "";
                labelAppVersion.Text = $"Versione {version}";
            }
        }
    }
}
