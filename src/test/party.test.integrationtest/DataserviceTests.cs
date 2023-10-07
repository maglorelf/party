namespace party.test.integrationtest
{
    using System.IO;
    using Microsoft.Data.Sqlite;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.infrastructure;
    using party.core.model;
    using party.service.data;
    using party.test.integrationtest.setup;
    using party.test.tools.Extensions;
    using Xunit;

    public class DataserviceTests
    {
        private readonly Mock<ILogger<IDataService>> mockLogger = new();
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
            IDataService dataService = new DataService(options, mockLogger.Object);

            using SqliteConnection connection = dataService.CreateConnection();
            connection.Open();
            Assert.NotNull(connection);
            Assert.True(File.Exists(Path.Combine(currentDirectory, defaultDatabaseName)));
        }
        [Fact]
        public void CheckDatabase_NoExistFile_ReturnMissingDatabaseMessage()
        {
            string testFile = "testdata.db".ShallowFileInUniqueFolder();

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options, mockLogger.Object);
            ResultValue<string> checkMessage = dataService.CheckDatabase();

            Assert.False(checkMessage.Success);
            Assert.Equal(DataService.MessageFileNotExists, checkMessage.Result);
        }
        [Fact]
        public void CheckDatabase_CreateConnectionNotInitialization_ReturnNotInitizedDatabaseMessage()
        {
            string testFile = "testdata.db".ShallowFileInUniqueFolder();

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options, mockLogger.Object);
            using SqliteConnection connection = dataService.CreateConnection();
            connection.Open();
            ResultValue<string> checkMessage = dataService.CheckDatabase();

            Assert.False(checkMessage.Success);
            Assert.Equal(DataService.MessageDatabaseNotInitialized, checkMessage.Result);
        }
        [Fact]
        public void CheckDatabase_CreateConnectionAndInitialization_ReturnInitializedDatabaseMessage()
        {
            string testFile = "testdata.db".ShallowFileInUniqueFolder();

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options, mockLogger.Object);
            dataService.InitializeDatabase();
            ResultValue<string> checkMessage = dataService.CheckDatabase();

            Assert.True(checkMessage.Success);
            Assert.Equal(DataService.MessageDatabaseInitialized, checkMessage.Result);
        }
        [Fact]
        public void CheckDatabase_CreateConnectionAndInitializationToAExistingConnection_ReturnInitializedDatabaseMessage()
        {
            string testFile = "testdata.db".ShallowFileInUniqueFolder();

            IOptionsMonitor<Configuracion> options = new TestOptionsMonitor<Configuracion>(new Configuracion
            {
                DatabaseName = Path.GetFileName(testFile),
                EventPath = Path.GetDirectoryName(testFile)
            }); ;
            IDataService dataService = new DataService(options, mockLogger.Object);
            dataService.InitializeDatabase();
            ResultValue<string> checkMessageFirstTime = dataService.CheckDatabase();

            dataService.InitializeDatabase();
            ResultValue<string> checkMessageSecondTime = dataService.CheckDatabase();

            Assert.True(checkMessageFirstTime.Success);
            Assert.Equal(DataService.MessageDatabaseInitialized, checkMessageFirstTime.Result);
            Assert.True(checkMessageSecondTime.Success);
            Assert.Equal(DataService.MessageDatabaseInitialized, checkMessageSecondTime.Result);
        }
    }
}
