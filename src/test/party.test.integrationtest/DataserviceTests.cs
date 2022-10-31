namespace party.test.integrationtest
{
    using System.IO;
    using Microsoft.Data.Sqlite;
    using Microsoft.Extensions.Options;
    using party.core.model;
    using party.service.data;
    using party.test.integrationtest.setup;
    using Xunit;

    public class DataserviceTests
    {
        [Fact]
        public void CreateConnectionAndOpenConnection_CheckDatabaseCreation()
        {
            string defaultDatabaseName = "databaseName.db";
            string currentDirectory = System.AppContext.BaseDirectory;
            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = defaultDatabaseName,
                EventPath = currentDirectory
            });
            IDataService dataService = new DataService(options);
            using SqliteConnection connection = dataService.CreateConnection();
            connection.Open();
            Assert.NotNull(connection);
            Assert.True(File.Exists(Path.Combine(currentDirectory, defaultDatabaseName)));
        }
    }
}
