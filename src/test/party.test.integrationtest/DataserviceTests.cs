namespace party.test.integrationtest
{
    using System;
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
        [Fact]
        public void CheckDatabase_NoExistFile_ReturnMissingDatabaseMessage()
        {
            string testFile = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".db";

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options);
            string checkMessage = dataService.CheckDatabase();

            Assert.Equal("No existe fichero", checkMessage);
        }
        [Fact]
        public void CheckDatabase_CreateConnectionNotInitialization_ReturnNotInitizedDatabaseMessage()
        {
            string testFile = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".db";

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options);
            using SqliteConnection connection = dataService.CreateConnection();
            connection.Open();
            string checkMessage = dataService.CheckDatabase();

            Assert.Equal("No está inicializada", checkMessage);
        }
        [Fact]
        public void CheckDatabase_CreateConnectionAndInitialization_ReturnInitizedDatabaseMessage()
        {
            string testFile = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".db";

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options);
            dataService.InitializeDatabase();
            string checkMessage = dataService.CheckDatabase();

            Assert.Equal("Inicializada", checkMessage);
        }
    }
}
