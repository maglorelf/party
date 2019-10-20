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
                  "Nombre NVARCHAR(2048) NULL," +
                  "Apellido NVARCHAR(2048) NULL," +
                  "Email NVARCHAR(2048) NULL," +
                  "Dni NVARCHAR(2048) NULL," +
                  "QR NVARCHAR(2048) NULL)";

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
            insertCommand.CommandText = "INSERT INTO Invitados VALUES (null,@Nombre,@Apellido,@Email,@Dni,@QR);";

            insertCommand.Parameters.AddWithValue("@Nombre", invitado.Nombre);
            insertCommand.Parameters.AddWithValue("@Apellido", invitado.Apellidos);
            insertCommand.Parameters.AddWithValue("@Email", invitado.Email);
            insertCommand.Parameters.AddWithValue("@Dni", invitado.DNI);
            insertCommand.Parameters.AddWithValue("@QR", invitado.QR);

            insertCommand.ExecuteReader();
        }
        public Invitado GetInvitadoByQR(string qr)
        {
            Invitado invitado = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT Id, Nombre, Apellido, Email, Dni, QR from Invitados where QR=@QR", db);
                selectCommand.Parameters.AddWithValue("@QR", qr);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    invitado = new Invitado
                    {
                        Id = query.GetInt32(0),
                        Nombre = query.GetString(1),
                        Apellidos = query.GetString(2),
                        Email = query.GetString(3),
                        DNI = query.GetString(4),
                        QR = query.GetString(5)
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

                SqliteCommand selectCommand = new SqliteCommand("SELECT a.Id, a.Entrada, i.Nombre, i.Apellido, i.Email, i.Dni, i.QR from Asistencia a inner join Invitados i on i.Id = a.InvitadoId ", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                   Asistente asistente= new Asistente 
                    {
                        Id = query.GetInt32(0),
                        Entrada = query.GetDateTime(1),
                        Nombre = query.GetString(2),
                        Apellidos = query.GetString(3),
                        Email = query.GetString(4),
                        DNI = query.GetString(5),
                        QRLeido = query.GetString(6)
                    };
                    asistentes.Add(asistente);
                }
                db.Close();
            }
            return asistentes;
        }
    }
}
