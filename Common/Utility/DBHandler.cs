using DevExpress.Xpo.DB;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Common.Utility {
    public static class DBConfig {
        public static string ConnectionString {
            get {
                return $"Data Source={
                    Path.Combine(
                        "C:",
                        Properties.Settings.Default.CompanyName,
                        Properties.Settings.Default.AppName,
                        Properties.Settings.Default.DBFileName
                    )
                }";
            }
        }
    }

    public class Cliente {
        [SetsRequiredMembers]
        public Cliente (string Nome, string? PIva, string? Cell, string? Tel, string? EMail, string? Pec, bool IsFornitore) { 
            this.Nome = Nome;
            this.PIva = PIva;
            this.Cell = Cell;
            this.Tel = Tel;
            this.EMail = EMail;
            this.Pec = Pec;
            this.IsFornitore = IsFornitore;
        }

        public required string Nome { get; set; }
        public string? PIva { get; set; }
        public string? Cell { get; set; }
        public string? Tel { get; set; }
        public string? EMail { get; set; }
        public string? Pec { get; set; }
        public bool IsFornitore { get; set; }
    }

    public class Movimento {
        public Movimento (float Importo, float? ImportoPagato, string RifDoc, DateOnly? DataCreato, DateOnly? DataChiuso) {
            this.Importo = Importo;
            this.ImportoPagato = ImportoPagato;
            this.RifDoc = RifDoc;
            this.DataCreato = DataCreato;
            this.DataChiuso = DataChiuso;
        }

        public float Importo { get; set; }
        public float? ImportoPagato { get; set; }
        public string RifDoc { get; set; }
        public DateOnly? DataCreato { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public DateOnly? DataChiuso { get; set; }
    }

    public class DBHandler {
        public void TestInsert () {
            string addClienteQuery = @"
                INSERT INTO Clienti (Nome, PIva, Cell, Tel, EMail, Pec)
                VALUES ('Filippo', '11111111111', '3311529671', NULL, 'filippobat04@hotmail.com', NULL);
            ";

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                Debug.WriteLine(DBConfig.ConnectionString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = addClienteQuery;
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateTables() {
            string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS Clienti (
	                ID	INTEGER NOT NULL,
	                Nome	varchar(255) NOT NULL,
	                PIva	varchar(11),
	                Cell	varchar(13),
	                Tel	varchar(13),
	                EMail	varchar(255),
	                Pec	varchar(255),
	                IsFornitore	boolean NOT NULL DEFAULT 0,
	                PRIMARY KEY(ID AUTOINCREMENT)
                );

                CREATE TABLE IF NOT EXISTS Movimenti (
	                ID	INTEGER NOT NULL,
	                IDCliente	INTEGER NOT NULL,
	                Importo	float,
	                ImportoPagato	float,
	                RifDoc	varchar(20),
	                DataCreato	date DEFAULT current_date,
	                DataChiuso	date,
	                IsChiuso	boolean DEFAULT 0,
	                PRIMARY KEY(ID AUTOINCREMENT),
	                FOREIGN KEY(IDCliente) REFERENCES Clienti(ID) ON DELETE CASCADE
                )
            ";

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = createTablesQuery;
                cmd.ExecuteNonQuery();
            }
        }

        // CLIENTI
        public int AddCliente (Cliente cliente) {
            int IDNuovoCliente;

            string addClienteQuery = @"
                INSERT INTO Clienti (Nome, PIva, Cell, Tel, EMail, Pec, IsFornitore)
                VALUES ($NomePar, $PIvaPar, $CellPar, $TelPar, $EMailPar, $PecPar, $IsFornitorePar)
            ";

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = addClienteQuery;
                cmd.Parameters.AddWithValue("$NomePar", cliente.Nome);
                cmd.Parameters.AddWithValue("$PIvaPar", string.IsNullOrWhiteSpace(cliente.PIva) ? DBNull.Value : cliente.PIva);
                cmd.Parameters.AddWithValue("$CellPar", string.IsNullOrWhiteSpace(cliente.Cell) ? DBNull.Value : cliente.Cell);
                cmd.Parameters.AddWithValue("$TelPar", string.IsNullOrWhiteSpace(cliente.Tel) ? DBNull.Value : cliente.Tel);
                cmd.Parameters.AddWithValue("$EMailPar", string.IsNullOrWhiteSpace(cliente.EMail) ? DBNull.Value : cliente.EMail);
                cmd.Parameters.AddWithValue("$PecPar", string.IsNullOrWhiteSpace(cliente.Pec) ? DBNull.Value : cliente.Pec);
                cmd.Parameters.AddWithValue("$IsFornitorePar", cliente.IsFornitore ? "1" : "0");

                // Esegue la query di inserimento
                cmd.ExecuteNonQuery();

                // Recupera l'ID appena inserito
                cmd.CommandText = "SELECT last_insert_rowid();";
                IDNuovoCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return IDNuovoCliente;
        }

        public void RemoveCliente(int idCliente) {
            string deleteClienteQuery = $"DELETE FROM Clienti WHERE ID={idCliente}";
            Debug.WriteLine(deleteClienteQuery);

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = deleteClienteQuery;
                cmd.ExecuteNonQuery();
            }
        }

        public bool ClientePIvaExists(string pIva) {
            string checkPIvaQuery = $"SELECT COUNT(*) FROM Clienti WHERE PIva = '{pIva}'";
            bool esito = false;

            Debug.WriteLine(checkPIvaQuery);

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = checkPIvaQuery;

                esito = Convert.ToInt16(cmd.ExecuteScalar()) != 0;
                Debug.WriteLine($"{esito} - {cmd.ExecuteScalar()}");
            }

            return esito;
        }

        // MOVIMENTI
        public void RemoveMovimento(int idMovimento) {
            string deleteMovimentoQuery = $"DELETE FROM Movimenti WHERE ID={idMovimento}";
            Debug.WriteLine(deleteMovimentoQuery);

            using (var conn = new SqliteConnection(DBConfig.ConnectionString)) {
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = deleteMovimentoQuery;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
