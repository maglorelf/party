namespace party.service.data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.Data.Sqlite;
    using Microsoft.Extensions.Options;
    using party.core.infrastructure;
    using party.core.model;
    public class DataService : IDataService
    {
        public const string MessageFileNotExists = "No existe fichero";
        public const string MessageDatabaseNotInitialized = "No está inicializada";
        public const string MessageDatabaseInitialized = "Inicializada";
        public bool DatabaseReady { get; set; }
        private readonly IOptionsMonitor<Configuracion> configuracion;
        protected string DatabaseName => Path.Combine(configuracion.CurrentValue.EventPath, configuracion.CurrentValue.DatabaseName);
        public DataService(IOptionsMonitor<Configuracion> configuracion)
        {
            this.configuracion = configuracion;
            DatabaseReady = false;
        }

        public SqliteConnection CreateConnection()
        {
            SqliteConnection connection = new($"Filename={DatabaseName}");
            return connection;
        }
        public bool ExistDatabaseFile()
        {
            return File.Exists(DatabaseName);
        }
        public void InsertAsistente(Asistente asistente)
        {
            using SqliteConnection db = CreateConnection();
            db.Open();

            SqliteCommand insertCommand = new()
            {
                Connection = db,

                // Use parameterized query to prevent SQL injection attacks
                CommandText = "INSERT INTO Asistencia VALUES (null,@QRLeido,@InvitadoId,@Entrada);"
            };
            insertCommand.Parameters.AddWithValue("@QRLeido", asistente.QRLeido);
            insertCommand.Parameters.AddWithValue("@InvitadoId", asistente.InvitadoId);
            insertCommand.Parameters.AddWithValue("@Entrada", asistente.Entrada);
            insertCommand.ExecuteNonQuery();
            db.Close();
        }

        public Asistente GetAsistenteByIdInvitado(int id)
        {
            Asistente asistente = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new("SELECT a.Id, a.Entrada,i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina, i.Asistencia, i.Id from Asistencia a inner join Invitados i on i.Id = a.InvitadoId where InvitadoId=@Id", db);
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
            DeleteDatabase(DatabaseName);
            using SqliteConnection db = CreateConnection();
            db.Open();
            CreateTables(db);
        }

        public void BorrarAsistente(int id)
        {
            using SqliteConnection db = CreateConnection();
            db.Open();
            BorrarInvitado(db, id);
            db.Close();
        }
        protected static void BorrarInvitado(SqliteConnection db, int id)
        {
            SqliteCommand deleteCommand = new()
            {
                Connection = db,
                CommandText = "DELETE FROM Asistencia WHERE Id=@Id;"
            };
            deleteCommand.Parameters.AddWithValue("@Id", id);
            deleteCommand.ExecuteNonQuery();
        }
        private static void DeleteDatabase(string databaseName)
        {
            if (File.Exists(databaseName))
            {
                SqliteConnection.ClearAllPools();
                File.Delete(databaseName);
            }
        }
        public static void CreateTables(SqliteConnection db)
        {
            foreach (Tables table in Enum.GetValues<Tables>())
            {
                CreateTable(db, table);
            }
        }
        public static void CreateTable(SqliteConnection db, Tables table)
        {
            string command = string.Empty;
            switch (table)
            {
                case Tables.Invitados:
                    command = SqlCommands.TableInvitadosCommand;
                    break;
                case Tables.Asistencia:
                    command = SqlCommands.TableAsistenciaCommand;
                    break;
                case Tables.Event:
                    command = SqlCommands.TableEventCommand;
                    break;
                case Tables.Route:
                    command = SqlCommands.TableRouteCommand;
                    break;
            }
            if (!string.IsNullOrEmpty(command))
            {
                SqliteCommand createTable = new(command, db);
                createTable.ExecuteNonQuery();
            }
        }
        public static void CreateTableInvitados(SqliteConnection db)
        {
            SqliteCommand createTable = new(SqlCommands.TableInvitadosCommand, db);
            createTable.ExecuteNonQuery();
        }
        public static void CreateTableAsistencia(SqliteConnection db)
        {
            SqliteCommand createTable = new(SqlCommands.TableAsistenciaCommand, db);
            createTable.ExecuteNonQuery();
        }
        public static void CreateTableEvent(SqliteConnection db)
        {
            SqliteCommand createTable = new(SqlCommands.TableEventCommand, db);
            createTable.ExecuteNonQuery();
        }
        public static void CreateTableRoute(SqliteConnection db)
        {
            SqliteCommand createTable = new(SqlCommands.TableRouteCommand, db);
            createTable.ExecuteNonQuery();
        }

        public void LoadInvitados(IList<Invitado> invitadosLeidos, IProgress<int> updateProgress)
        {
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                for (int idInvitado = 0; idInvitado < invitadosLeidos.Count; idInvitado++)
                {
                    InsertInvitado(db, invitadosLeidos[idInvitado]);
                    updateProgress.Report((100 * idInvitado) / invitadosLeidos.Count);
                }
                db.Close();
            }
            updateProgress.Report(100);
        }
        public void InsertInvitadoManual(Invitado invitado)
        {
            using SqliteConnection db = CreateConnection();
            db.Open();
            InsertInvitado(db, invitado);
            db.Close();
        }
        protected static void InsertInvitado(SqliteConnection db, Invitado invitado)
        {
            SqliteCommand insertCommand = new()
            {
                Connection = db,

                // Use parameterized query to prevent SQL injection attacks
                CommandText = "INSERT INTO Invitados VALUES (null,@Codigo, @Nombre, @Evento, @EventoLocal, @Extra, @DNI, @Email, @Oficina, @Asistencia, @Notas);"
            };

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
            using SqliteConnection db = CreateConnection();
            db.Open();
            SqliteCommand updateCommand = new()
            {
                Connection = db,

                // Use parameterized query to prevent SQL injection attacks
                CommandText = "UPDATE Invitados SET Notas= @Notas WHERE Id = @Id;"
            };

            updateCommand.Parameters.AddWithValue("@Id", invitado.Id);
            updateCommand.Parameters.AddWithValue("@Notas", invitado.Notas);
            updateCommand.ExecuteNonQuery();
            db.Close();

        }
        public int GetCountAsistentes()
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(" SELECT count(*) FROM asistencia", db);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }

        public int GetCountInvitados()
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(" SELECT count(*) FROM invitados", db);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }
        public int GetCountInvitadosEvento(string eventoLocal)
        {
            int elementos = 0;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(" SELECT count(*) FROM invitados where EventoLocal=@EventoLocal", db);
                selectCommand.Parameters.AddWithValue("@EventoLocal", eventoLocal);
                elementos = Convert.ToInt32(selectCommand.ExecuteScalar());
                db.Close();
            }
            return elementos;
        }
        public ResultValue<string> CheckDatabase()
        {
            ResultValue<string> databaseCheck;
            try
            {
                bool existeFichero = File.Exists(DatabaseName);
                if (existeFichero)
                {
                    bool existeTable = true;
                    foreach (string table in Enum.GetNames<Tables>())
                    {
                        existeTable &= ExisteTable(table);
                    }
                    if (existeTable)
                    {
                        databaseCheck = ResultValue<string>.NewOk(MessageDatabaseInitialized);
                    }
                    else
                    {
                        databaseCheck = ResultValue<string>.NewError(MessageDatabaseNotInitialized);
                    }
                }
                else
                {
                    databaseCheck = ResultValue<string>.NewError(MessageFileNotExists);
                }
            }
            catch (Exception ex)
            {
                databaseCheck = ResultValue<string>.NewError(1);
                databaseCheck.AddError(ex.Message);
            }
            return databaseCheck;
        }
        protected bool ExisteTable(string tablename)
        {
            bool existeTable = false;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(" SELECT name FROM sqlite_master WHERE type = 'table' AND name = @tablenameParam", db);
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

                SqliteCommand selectCommand = new("SELECT Id," +
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

                SqliteCommand selectCommand = new("SELECT a.Id, a.Entrada,i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina, i.Asistencia, i.Id, i.Notas from Asistencia a inner join Invitados i on i.Id = a.InvitadoId ", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Asistente asistente = new()
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
                SqliteCommand selectCommand = new("SELECT Id," +
                 "Codigo, Nombre, Evento, EventoLocal, Extra, DNI, Email, Oficina, Asistencia, Notas FROM Invitados order by Email", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Invitado invitado = new()
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
                SqliteCommand selectCommand = new("SELECT i.Id," +
                 "i.Codigo, i.Nombre, i.Evento, i.EventoLocal, i.Extra, i.DNI, i.Email, i.Oficina,i.Asistencia , a.entrada, i.Notas FROM Invitados i LEFT JOIN Asistencia a  on i.Id = a.InvitadoId order by i.Email", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    Invitado invitado = new()
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
        public Event GetCurrentEvent()
        {
            Guid? eventId = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(SqlCommands.GetFirstEventId, db);

                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    @eventId = query.GetGuid(0);
                }
                db.Close();
            }
            Event @event = Event.GenerateDefault();
            if (eventId.HasValue)
            {
                @event = GetEvent(eventId.Value);
            }
            return @event;
        }
        public Event GetEvent(Guid id)
        {
            Event @event = null;
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(SqlCommands.GetEventById, db);
                selectCommand.Parameters.AddWithValue("@Id", id);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    @event = new Event
                    {
                        Id = query.GetGuid(0),
                        Title = query.GetString(1),
                        Description = query.GetString(2),
                        Start = query.GetDateTime(3),
                        End = query.GetDateTime(4),
                        CheckIn = query.GetDateTime(5)
                    };
                }
                db.Close();
            }
            if (@event != null)
            {
                @event.Routes = GetAllRoutesOfEvent(@event.Id);
            }
            else
            {
                @event = Event.GenerateDefault();
            }
            return @event;
        }
        public List<Route> GetAllRoutesOfEvent(Guid eventId)
        {
            List<Route> routes = new();
            using (SqliteConnection db = CreateConnection())
            {
                db.Open();
                SqliteCommand selectCommand = new(SqlCommands.GetAllRoutesOfEvent, db);
                selectCommand.Parameters.AddWithValue("@EventId", eventId);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Route route = new()
                    {
                        Id = query.GetGuid(0),
                        EventId = query.GetGuid(1),
                        Name = query.GetString(2),
                        Description = query.GetString(3),
                        Location = query.GetString(4),
                    };
                    routes.Add(route);
                }

                db.Close();
                if (routes.Count == 0)
                {
                    routes.Add(new Route { EventId = eventId });
                }
            }
            return routes;
        }

        public void UpdateDataEvent(Event @event)
        {
            using SqliteConnection db = CreateConnection();
            db.Open();
            SqliteCommand updateEventCommand = new(SqlCommands.ReplaceEvent, db);


            updateEventCommand.Parameters.AddWithValue("@Id", @event.Id);
            updateEventCommand.Parameters.AddWithValue("@Title", @event.Title);
            updateEventCommand.Parameters.AddWithValue("@Description", @event.Description);
            updateEventCommand.Parameters.AddWithValue("@Start", @event.Start);
            updateEventCommand.Parameters.AddWithValue("@End", @event.End);
            updateEventCommand.Parameters.AddWithValue("@CheckIn", @event.CheckIn);
            updateEventCommand.ExecuteNonQuery();
            SqliteCommand deleteAllRoutesCommand = new(SqlCommands.DeleteEventRoutes, db);
            deleteAllRoutesCommand.Parameters.AddWithValue("@EventId", @event.Id);

            deleteAllRoutesCommand.ExecuteNonQuery();

            foreach (var route in @event.Routes)
            {
                SqliteCommand updateRouteCommand = new(SqlCommands.InsertEventRoute, db);
                updateRouteCommand.Parameters.AddWithValue("@Id", route.Id);
                updateRouteCommand.Parameters.AddWithValue("@EventId", @event.Id);
                updateRouteCommand.Parameters.AddWithValue("@Name", route.Name);
                updateRouteCommand.Parameters.AddWithValue("@Description", route.Description);
                updateRouteCommand.Parameters.AddWithValue("@Location", route.Location);
                updateRouteCommand.ExecuteNonQuery();
            }
            db.Close();
        }
    }
}
