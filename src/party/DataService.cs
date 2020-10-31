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
                insertCommand.ExecuteNonQuery();
                db.Close();
            }
        }

        public Asistente GetAsistenteByIdInvitado(int id)
        {
            Asistente asistente = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT a.Id, a.Entrada,i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina, i.Asistencia, i.Id from Asistencia a inner join Invitados i on i.Id = a.InvitadoId where InvitadoId=@Id", db);
                selectCommand.Parameters.AddWithValue("@Id", id);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    asistente = new Asistente
                    {
                        Id = query.GetInt32(0),
                        InvitadoId = query.GetInt32(11),
                        Entrada = query.GetDateTime(1),
                        Evento = query.GetString(5),
                        Nombre = query.GetString(3),
                        Email = query.GetString(8),
                        DNI = query.GetString(7)
                    };
                }
                db.Close();
            }
            return asistente;
        }

        public void InitializeDatabase()
        {
            deleteDatabase(databaseName);
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                CreateTableInvitados(db);
                CreateTableAsistencia(db);
            }
        }

        internal void BorrarAsistente(int id)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                borrarInvitado(db, id);
                db.Close();
            }
        }
        protected void borrarInvitado(SqliteConnection db, int id)
        {
            SqliteCommand deleteCommand = new SqliteCommand();
            deleteCommand.Connection = db;
            deleteCommand.CommandText = "DELETE FROM Asistencia WHERE Id=@Id;";
            deleteCommand.Parameters.AddWithValue("@Id", id);
            deleteCommand.ExecuteNonQuery();
        }
        private void deleteDatabase(string databaseName)
        {
            System.IO.File.Delete(databaseName);
            System.Threading.Thread.Sleep(5000);
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
                    "Asistencia NVARCHAR(2048) NULL," +
                    "Notas NVARCHAR(2048) NULL)";

            SqliteCommand createTable = new SqliteCommand(tableCommand, db);

            createTable.ExecuteNonQuery();
        }
        public void CreateTableAsistencia(SqliteConnection db)
        {
            String tableCommand = "CREATE TABLE IF NOT " +
                  "EXISTS Asistencia (Id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                  "QRLeido NVARCHAR(2048) NOT NULL," +
                  "InvitadoId integer NOT NULL," +
                  "Entrada integer NOT NULL)";

            SqliteCommand createTable = new SqliteCommand(tableCommand, db);

            createTable.ExecuteNonQuery();
        }

        public void LoadInvitados(IList<Invitado> invitadosLeidos, System.Windows.Forms.ToolStripProgressBar updateProgress)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                for (int idInvitado = 0; idInvitado < invitadosLeidos.Count(); idInvitado++)
                {
                    insertInvitado(db, invitadosLeidos[idInvitado]);
                    updateProgress.Value = (100 * idInvitado) / invitadosLeidos.Count();
                }
                db.Close();
            }
            updateProgress.Value = 100;
        }
        public void InsertInvitadoManual(Invitado invitado)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                insertInvitado(db, invitado);
                db.Close();
            }
        }
        protected void insertInvitado(SqliteConnection db, Invitado invitado)
        {
            SqliteCommand insertCommand = new SqliteCommand();
            insertCommand.Connection = db;

            // Use parameterized query to prevent SQL injection attacks
            insertCommand.CommandText = "INSERT INTO Invitados VALUES (null,@Codigo, @Nombre, @Evento, @EventoLocal, @Extra, @DNI, @Email, @Oficina, @Asistencia, @Notas);";

            insertCommand.Parameters.AddWithValue("@Codigo", invitado.Codigo);
            insertCommand.Parameters.AddWithValue("@Nombre", invitado.Nombre);
            insertCommand.Parameters.AddWithValue("@Evento", invitado.Evento);
            insertCommand.Parameters.AddWithValue("@EventoLocal", invitado.EventoLocal);
            insertCommand.Parameters.AddWithValue("@Extra", invitado.Extra);
            insertCommand.Parameters.AddWithValue("@DNI", invitado.DNI);
            insertCommand.Parameters.AddWithValue("@Email", invitado.Email);
            insertCommand.Parameters.AddWithValue("@Oficina", invitado.Oficina);
            insertCommand.Parameters.AddWithValue("@Asistencia", invitado.Asistencia);
            insertCommand.Parameters.AddWithValue("@Notas", invitado.Notas);

            insertCommand.ExecuteNonQuery();
        }
        public void ActualizarNotasInvitado(Invitado invitado)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand updateCommand = new SqliteCommand();
                updateCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                updateCommand.CommandText = "UPDATE Invitados SET Notas= @Notas WHERE Id = @Id;";

                updateCommand.Parameters.AddWithValue("@Id", invitado.Id);
                updateCommand.Parameters.AddWithValue("@Notas", invitado.Notas);
                updateCommand.ExecuteNonQuery();
                db.Close();
            }

        }
        internal int GetCountAsistentes()
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(" SELECT count(*) FROM asistencia", db);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }

        internal int GetCountInvitados()
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(" SELECT count(*) FROM invitados", db);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }
        internal int GetCountInvitadosEvento(string eventoLocal)
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(" SELECT count(*) FROM invitados where EventoLocal=@EventoLocal", db);
                selectCommand.Parameters.AddWithValue("@EventoLocal", eventoLocal);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }
        internal string CheckDatabase()
        {
            string databaseOk = string.Empty;
            try
            {
                databaseOk = "No existe fichero";
                bool existeFichero = System.IO.File.Exists(databaseName);
                if (existeFichero)
                {
                    databaseOk = "No está inicializada";
                    bool existeTableInvitados = existeTable("Invitados");
                    bool existeTableAsistente = existeTable("Asistencia");
                    if (existeTableInvitados && existeTableAsistente)
                    {
                        databaseOk = "Inicializada";
                    }
                }
            }
            catch { }
            return databaseOk;
        }
        protected bool existeTable(string tablename)
        {
            bool existeTable = false;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(" SELECT name FROM sqlite_master WHERE type = 'table' AND name = @tablenameParam", db);
                selectCommand.Parameters.AddWithValue("@tablenameParam", tablename);

                string newTablename = (string)selectCommand.ExecuteScalar();
                existeTable = tablename.Equals(newTablename);
                db.Close();
            }
            return existeTable;
        }
        public Invitado GetInvitadoByEmail(string email)
        {
            Invitado invitado = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT Id," +
                    "Codigo, Nombre, Evento, EventoLocal, Extra, DNI, Email, Oficina, Asistencia, Notas FROM Invitados where Email=@EmailParam", db);
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
                        Asistencia = query.GetString(9),
                        Notas = query.GetString(10)
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

                SqliteCommand selectCommand = new SqliteCommand("SELECT a.Id, a.Entrada,i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina, i.Asistencia, i.Id, i.Notas from Asistencia a inner join Invitados i on i.Id = a.InvitadoId ", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Asistente asistente = new Asistente
                    {
                        Id = query.GetInt32(0),
                        InvitadoId = query.GetInt32(11),
                        Entrada = query.GetDateTime(1),
                        Evento = query.GetString(5),
                        Nombre = query.GetString(3),
                        Email = query.GetString(8),
                        DNI = query.GetString(7),
                        Notas = query.GetString(12)

                    };
                    asistentes.Add(asistente);
                }
                db.Close();
            }
            return asistentes;
        }
        public IList<Invitado> GetAllInvitados()
        {
            IList<Invitado> invitados = new List<Invitado>();
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT Id," +
                 "Codigo, Nombre, Evento, EventoLocal, Extra, DNI, Email, Oficina, Asistencia, Notas FROM Invitados order by Email", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Invitado invitado = new Invitado
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
                        Asistencia = query.GetString(9),
                        Notas = query.GetString(10)
                    };
                    invitados.Add(invitado);
                }
                db.Close();
            }
            return invitados;
        }
        public IList<Invitado> GetAllInvitadosView()
        {
            IList<Invitado> invitados = new List<Invitado>();
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT i.Id," +
                 "i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina,i.Asistencia , a.entrada, i.Notas FROM Invitados i LEFT JOIN Asistencia a  on i.Id = a.InvitadoId order by i.Email", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    Invitado invitado = new Invitado
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
                        Asistencia = query.GetString(9),
                        Notas = query.GetString(11)

                    };
                    if (!query.IsDBNull(10))
                    {
                        invitado.Registrado = "Sí";
                    }
                    else
                    {
                        invitado.Registrado = "No";
                    }
                    invitados.Add(invitado);
                }
                db.Close();
            }
            return invitados;
        }
    }
}
