namespace party.service.data
{
    public static class SqlCommands
    {
        public const string TableInvitadosCommand = "CREATE TABLE IF NOT " +
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
        public const string TableAsistenciaCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Asistencia (Id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                    "QRLeido NVARCHAR(2048) NOT NULL," +
                    "InvitadoId integer NOT NULL," +
                    "Entrada integer NOT NULL)";
        public const string TableEventCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Event (Id NVARCHAR(36) PRIMARY KEY, " +
                    "Title NVARCHAR(2048) NOT NULL," +
                    "Description NVARCHAR(2048) NULL," +
                    "InvitadoId integer NOT NULL," +
                    "Start integer NOT NULL," +
                    "End integer NOT NULL," +
                    "CheckIn integer NOT NULL)";
        public const string TableRouteCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Route (Id NVARCHAR(36) PRIMARY KEY, " +
                    "EventId NVARCHAR(36) NOT NULL," +
                    "Name NVARCHAR(2048) NOT NULL," +
                    "Description NVARCHAR(2048) NULL," +
                    "Location NVARCHAR(2048) NULL)";
    }
}
