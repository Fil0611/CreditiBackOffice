using Common.Utility.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Common.Utility {
    public class OrdiniHandler {
        private enum OrdiniEndpoint {
            Fornitori,
            Ordini,
            Articoli
        }

        private HttpClient SetupHttpClient(OrdiniEndpoint endpoint) {
            string url = $"{Properties.Settings.Default.APIOrdini}";

            switch (endpoint) {
                case OrdiniEndpoint.Fornitori:
                    url += "/fornitori";
                    break;
                case OrdiniEndpoint.Ordini:
                    url += "/ordini";
                    break;
                case OrdiniEndpoint.Articoli:
                    url += "/articoli/";
                    break;
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        // ORDINI
        public async Task<int?> AddOrdine(Ordine ordine) {
            int? idOrdine = null;

            string parameters = $"?chiave_utente={await UserIdRegistryHandler.GetOrCreateUserId()}";
            var body = new StringContent(JsonSerializer.Serialize(ordine), Encoding.UTF8, "application/json");

            HttpClient client = SetupHttpClient(OrdiniEndpoint.Ordini);
            HttpResponseMessage response = await client.PostAsync(parameters, body);

            if (response.IsSuccessStatusCode) {
                // Estrapolo l'ID dell'ordine appena inserito e lo ritorno
                string responseJson = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<OrdineResponse>(responseJson);
                if (result != null) idOrdine = result.IDOrdine;
                Debug.WriteLine($"Ordine inserito: {idOrdine}");
            }

            return idOrdine;
        }

        public async Task GetOrdini() {
            List<Ordine> ordini = [];

            string parameters = $"?chiave_utente={await UserIdRegistryHandler.GetOrCreateUserId()}";

            HttpClient client = SetupHttpClient(OrdiniEndpoint.Ordini);

            HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);

            if (response.IsSuccessStatusCode) {
                var jsonString = await response.Content.ReadAsStringAsync();
                var listaOrdini = JsonSerializer.Deserialize<List<Ordine>>(
                    JsonSerializer.Deserialize<JsonObject>(jsonString)?["Ordini"]    
                );

                if (listaOrdini != null) {
                    ordini.AddRange(listaOrdini);
                }
            }

            Debug.WriteLine(ordini[0].NomeCliente);
        }

        // ARTICOLI
        public async Task AddArticoli(List<Articolo> articoli, int idOrdine) {
            string parameters = $"{idOrdine}?chiave_utente={await UserIdRegistryHandler.GetOrCreateUserId()}";

            HttpClient client = SetupHttpClient(OrdiniEndpoint.Articoli);

            Debug.WriteLine($"{client.BaseAddress}{parameters}");

            foreach (Articolo articolo in articoli) {
                var body = new StringContent(JsonSerializer.Serialize(articolo), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(parameters, body);

                if (response.IsSuccessStatusCode) Debug.WriteLine("Inserito articolo.");
            }
        }

        // FORNITORI
        public async Task<int> AddFornitore(Fornitore fornitore) {
            int idFornitore = 0;

            var payload = new { Nome = fornitore.Nome, Url = fornitore.Url };

            string parameters = $"?chiave_utente={await UserIdRegistryHandler.GetOrCreateUserId()}";
            var body = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            Debug.WriteLine(JsonSerializer.Serialize(payload));

            HttpClient client = SetupHttpClient(OrdiniEndpoint.Fornitori);
            HttpResponseMessage response = await client.PostAsync(parameters, body);

            if (response.IsSuccessStatusCode) {
                // Estrapolo l'ID del fornitore appena inserito e lo ritorno
                string responseJson = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<FornitoreResponse>(responseJson);
                if (result != null) idFornitore = result.IDFornitore;
                Debug.WriteLine($"Fornitore inserito: {idFornitore}");
            }

            return idFornitore;
        }

        public async Task<List<Fornitore>> GetFornitori() {
            List<Fornitore> fornitori = [];

            string parameters = $"?chiave_utente={await UserIdRegistryHandler.GetOrCreateUserId()}";

            HttpClient client = SetupHttpClient(OrdiniEndpoint.Fornitori);

            HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);

            // Nell'else inserire gli altri codici di risposta (se non ci sono elementi, se l'utente non esiste...)
            if (response.IsSuccessStatusCode) {
                var jsonString = await response.Content.ReadAsStringAsync();
                var listaFornitori = JsonSerializer.Deserialize<List<Fornitore>>(
                    JsonSerializer.Deserialize<JsonObject>(jsonString)?["Fornitori"]
                );

                if (listaFornitori != null) {
                    fornitori.AddRange(listaFornitori);
                }
            }

            return fornitori;
        }
    }
}
