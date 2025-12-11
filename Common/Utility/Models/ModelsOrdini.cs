using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Common.Utility.Models {
    [Serializable]
    [method: SetsRequiredMembers]
    public class Ordine(string? NomeCliente, string? CellCliente, string? Note) {
        [JsonPropertyName("NomeCliente")]
        public string? NomeCliente { get; set; } = NomeCliente;

        [JsonPropertyName("CellCliente")]
        public string? CellCliente { get; set; } = CellCliente;

        [JsonPropertyName("DataOrdine")]
        public string DataOrdine { get; private set; } = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");

        [JsonPropertyName("Note")]
        public string? Note { get; set; } = Note;
    }
    public class OrdineResponse(string Esito, int IDOrdine) {
        public string Esito { get; set; } = Esito;
        public int IDOrdine { get; set; } = IDOrdine;
    }

    [Serializable]
    [method: SetsRequiredMembers]
    public class Articolo(string? CodArticolo, string? NomeArticolo, int Quant, int? IDFornitore, string? Note) {
        [JsonPropertyName("CodArticolo")]
        public string? CodArticolo { get; set; } = CodArticolo;

        [JsonPropertyName("NomeArticolo")]
        public string? NomeArticolo { get; set; } = NomeArticolo;

        [JsonPropertyName("Quant")]
        public int Quant { get; set; } = Quant;

        [JsonPropertyName("IDFornitore")]
        public int? IDFornitore { get; set; } = IDFornitore;

        [JsonPropertyName("Note")]
        public string? Note { get; set; } = Note;
    }

    [Serializable]
    [method: SetsRequiredMembers]
    public class Fornitore(int ID, string Nome, string? Url) {
        [JsonPropertyName("ID")]
        public int ID { get; set; } = ID;

        [JsonPropertyName("Nome")]
        public string Nome { get; set; } = Nome;

        [JsonPropertyName("Url")]
        public string? Url { get; set; } = Url;
    }
    public class FornitoreResponse(string Esito, int IDFornitore) {
        public string Esito { get; set; } = Esito;
        public int IDFornitore { get; set; } = IDFornitore;
    }
}
