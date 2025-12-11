using System.ComponentModel;
using System.IO;

namespace Crediti.Reports {
    public partial class ReportCliente : DevExpress.XtraReports.UI.XtraReport {
        public ReportCliente() {
            InitializeComponent();
        }

        // ATTRIBUTI
        public bool IsReportFornitore { get; set; } = false;

        // EVENTI
        private void pictureAziendaLogo_BeforePrint(object sender, CancelEventArgs e) {
            string logoPath = Path.Combine(
                "C:",
                Common.Properties.Settings.Default.CompanyName,
                Common.Properties.Settings.Default.AppName,
                Common.Properties.Settings.Default.AziendaLogoFileName
            );
            pictureAziendaLogo.ImageUrl = logoPath;
        }

        private void rtfFooter_BeforePrint(object sender, CancelEventArgs e) {
            if (IsReportFornitore) rtfFooter.Visible = false;
        }
    }
}
