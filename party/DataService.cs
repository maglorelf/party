using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class DataService
    {
        public bool DatabaseReady { get; set; }
        protected string databaseName { get; set; }
        public DataService(string databaseName)
        {
            this.databaseName = databaseName;
            DatabaseReady = false;
        }

        public SqliteConnection CreateConnection()
        {
            SqliteConnection connection = new SqliteConnection($"Filename={databaseName}");
            return connection;
        }

        public void InsertAsistente(Asistente asistente)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Asistencia VALUES (null,@QRLeido,@InvitadoId,@Entrada);";
                insertCommand.Parameters.AddWithValue("@QRLeido", asistente.QRLeido);
                insertCommand.Parameters.AddWithValue("@InvitadoId", asistente.InvitadoId);
                insertCommand.Parameters.AddWithValue("@Entrada", asistente.Entrada);
                insertCommand.ExecuteReader();
                db.Close();
            }
        }

        public Asistente GetAsistenteByIdInvitado(int id)
        {
            Asistente asistente = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT Id, QRLeido, InvitadoId, Entrada from Asistencia where InvitadoId=@Id", db);
                selectCommand.Parameters.AddWithValue("@Id", id);

                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    asistente = new Asistente
                    {
                        Id = query.GetInt32(0),
                        QRLeido = query.GetString(1),
                        InvitadoId = query.GetInt32(2),
                        Entrada = query.GetDateTime(3)
                    };
                }
                db.Close();
            }

            return asistente;
        }

        public void InitializeDatabase()
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                CreateTableInvitados(db);
                CreateTableAsistencia(db);
            }
        }

        public void CreateTableInvitados(SqliteConnection db)
        {
            String tableCommand = "CREATE TABLE IF NOT " +
                  "EXISTS Invitados (Id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                    "Codigo INTEGER NULL," +
                    "Nombre NVARCHAR(2048) NULL," +
                    "Evento NVARCHAR(2048) NULL," +
                    "EventoLocal NVARCHAR(2048) NULL," +
                    "Extra NVARCHAR(2048) NULL," +
                    "DNI NVARCHAR(2048) NULL," +
                    "Email NVARCHAR(2048) COLLATE NOCASE NULL," +
                    "Oficina NVARCHAR(2048) NULL," +
                    "Asistencia NVARCHAR(2048) NULL)";

        SqliteCommand createTable = new SqliteCommand(tableCommand, db);

            createTable.ExecuteReader();
        }
        public void CreateTableAsistencia(SqliteConnection db)
        {
            String tableCommand = "CREATE TABLE IF NOT " +
                  "EXISTS Asistencia (Id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                  "QRLeido NVARCHAR(2048) NOT NULL," +
                  "InvitadoId integer NOT NULL," +
                  "Entrada integer NOT NULL)";

            SqliteCommand createTable = new SqliteCommand(tableCommand, db);

            createTable.ExecuteReader();
        }

        public void LoadInvitados(IList<Invitado> invitadosLeidos)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                for (int idInvitado = 0; idInvitado < invitadosLeidos.Count(); idInvitado++)
                {
                    insertInvitado(db, invitadosLeidos[idInvitado]);
                }
                db.Close();
            }

        }
        protected void insertInvitado(SqliteConnection db, Invitado invitado)
        {
            SqliteCommand insertCommand = new SqliteCommand();
            insertCommand.Connection = db;

            // Use parameterized query to prevent SQL injection attacks
            insertCommand.CommandText = "INSERT INTO Invitados VALUES (null,@Codigo, @Nombre, @Evento, @EventoLocal, @Extra, @DNI, @Email, @Oficina, @Asistencia);";

            insertCommand.Parameters.AddWithValue("@Codigo", invitado.Codigo);
            insertCommand.Parameters.AddWithValue("@Nombre", invitado.Nombre);
            insertCommand.Parameters.AddWithValue("@Evento", invitado.Evento);
            insertCommand.Parameters.AddWithValue("@EventoLocal", invitado.EventoLocal);
            insertCommand.Parameters.AddWithValue("@Extra", invitado.Extra);
            insertCommand.Parameters.AddWithValue("@DNI", invitado.DNI);
            insertCommand.Parameters.AddWithValue("@Email", invitado.Email);
            insertCommand.Parameters.AddWithValue("@Oficina", invitado.Oficina);
            insertCommand.Parameters.AddWithValue("@Asistencia", invitado.Asistencia);

            insertCommand.ExecuteReader();
        }
     
        public Invitado GetInvitadoByEmail(string email)
        {
            Invitado invitado = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT Id," +
                    "Codigo, Nombre, Evento, EventoLocal, Extra, DNI, Email, Oficina, Asistencia FROM Invitados where Email=@EmailParam", db);
                selectCommand.Parameters.AddWithValue("@EmailParam", email);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    invitado = new Invitado
                    {
                        Id = query.GetInt32(0),
                        Codigo = query.GetInt32(1),
                        Nombre = query.GetString(2),
                        Evento = query.GetString(3),
                        EventoLocal = query.GetString(4),
                        Extra = query.GetString(5),
                        DNI = query.GetString(6),
                        Email = query.GetString(7),
                        Oficina = query.GetString(8),
                        Asistencia = query.GetString(9)
                    };
                }
                db.Close();
            }
            return invitado;
        }
        public IList<Asistente> GetAllAsistentes()
        {
            IList<Asistente> asistentes = new List<Asistente>();
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT a.Id, a.Entrada,i.Evento, i.Nombre, i.Apellido, i.Email, i.Dni, i.QR from Asistencia a inner join Invitados i on i.Id = a.InvitadoId ", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                   Asistente asistente= new Asistente 
                    {
                        Id = query.GetInt32(0),
                        Entrada = query.GetDateTime(1),
                        Evento = query.GetString(2),
                        Nombre = query.GetString(3),
                        Apellidos = query.GetString(4),
                        Email = query.GetString(5),
                        DNI = query.GetString(6),
                        QRLeido = query.GetString(7)
                    };
                    asistentes.Add(asistente);
                }
                db.Close();
            }
            return asistentes;
        }
    }
}
