using Common.Utility;
using FrontOffice.Forms.Ordini;
using System.IO;    // RELEASE
using Velopack;     // RELEASE

namespace FrontOffice {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if !DEBUG
            VelopackApp.Build().Run();
#endif

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Controllo l'esistenza della chiave dell'utente in ENV
            string userID = UserIdRegistryHandler.GetOrCreateUserId().GetAwaiter().GetResult();

            Application.Run(new NuovoOrdine());
        }
    }
}