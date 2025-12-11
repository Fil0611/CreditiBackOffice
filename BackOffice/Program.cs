using BackOffice.Forms;
using Common.Utility;
using System.Diagnostics;
#if !DEBUG
using System.IO;
using Velopack;
#endif

namespace Crediti {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main () {
#if !DEBUG
            VelopackApp.Build().Run();
#endif

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Controllo che le cartelle in AppData\Local\ siano presenti sennò vengono create
            /*System.IO.Directory.CreateDirectory(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    Properties.Settings.Default.CompanyName,
                    Properties.Settings.Default.AppName
                )
            );*/

            // Controllo l'esistenza della chiave dell'utente in ENV
            string userID = UserIdRegistryHandler.GetOrCreateUserId().GetAwaiter().GetResult();

            // Apro la connessione così che il database si crei se non esiste e creo anche le tabelle se non esistono
            new DBHandler().CreateTables();

            Application.Run(new StartingPage());
            //Application.Run(new ListaClienti());

            Debug.WriteLine($"ID Utente: {userID}");
        }
    }
}