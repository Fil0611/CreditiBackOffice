using System.Reflection;
using Velopack;

namespace Common.Forms {
    public partial class AppInfo : Form {
        public AppInfo() {
            InitializeComponent();

            // Imposto il numero di versione (url hard-coded perché le versioni di FO e BO coincidono sempre)
            string version = new UpdateManager("https://github.com/Fil0611/CreditiBO/releases/latest/download").CurrentVersion?.ToString() ?? Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "";
            labelAppVersion.Text = $"Versione {version}";
        }
    }
}
