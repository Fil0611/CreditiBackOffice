using Microsoft.Win32;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Common.Utility {
    public static class UserIdRegistryHandler {
        private const string RegistryPath = @"Software\FilBatta\Crediti\Ordini";
        private const string ValueName = "UserID";

        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetOrCreateUserId() {
            using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(RegistryPath, true)) {
                if (key != null) {
                    // La chiave esiste
                    object? value = key.GetValue(ValueName);

                    if (value != null && Guid.TryParse(value.ToString(), out Guid exsistingGuid)) {
                        // Chiave valida
                        Debug.WriteLine("ID Utente trovato nel registro!");
                        return exsistingGuid.ToString();
                    }
                    else {
                        // Chiave corrotta, invalida o ha valore mancante
                        return await CreateAndSaveUserId(key);
                    }
                }
                else {
                    // La chiave non esiste
                    Debug.WriteLine("Chiave non trovata, creazione in corso...");

                    // Creo chiave e la apro
                    using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(RegistryPath)) {
                        return await CreateAndSaveUserId(newKey);
                    }
                }
            }
        }

        private static async Task<string> CreateAndSaveUserId(RegistryKey key) {
            Guid userId = Guid.NewGuid();

            // Salvo lo userId nel registro
            key.SetValue(ValueName, userId, RegistryValueKind.String);

            Debug.WriteLine($"ID Utente creato: {userId}");

            //Richiesta POST per la registrazione dell'utente a DB
            await RegistraUtente(userId.ToString());

            return userId.ToString();
        }

        private static async Task RegistraUtente(string userId) {
            string url = $"{Properties.Settings.Default.APIOrdini}/register?Chiave={userId}";

            // Aggiungo 'accept' header
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Invio richiesta POST
            HttpResponseMessage response = await client.PostAsync(url, null);

            // Gestisco risposta
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Debug.WriteLine($"Response: {responseBody}");
        }
    }
}
