namespace party.test.unittest.service.data
{
    using System.IO;
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.model;
    using party.service.data;
    using Xunit;

    public class DataserviceTest
    {
        [Fact]
        public void ExistDatabaseFile_FailCheckMissingDatabase()
        {
            string filePath = Path.GetTempFileName();
            File.Delete(filePath);

            var options = new Configuracion()
            {
                EventPath = Path.GetDirectoryName(filePath),
                DatabaseName = Path.GetFileName(filePath)
            };
            Mock<IOptionsMonitor<Configuracion>> configurationMock = new(MockBehavior.Strict);
            configurationMock.Setup(m => m.CurrentValue).Returns(options);
            IDataService dataService = new DataService(configurationMock.Object);
            bool actual = dataService.ExistDatabaseFile();

            Assert.False(actual);
        }
        [Fact]
        public void ExistDatabaseFile_SuccessCheckCreatedFile()
        {
            string filePath = Path.GetTempFileName();
            var options = new Configuracion()
            {
                EventPath = Path.GetDirectoryName(filePath),
                DatabaseName = Path.GetFileName(filePath)
            };
            Mock<IOptionsMonitor<Configuracion>> configurationMock = new(MockBehavior.Strict);
            configurationMock.Setup(m => m.CurrentValue).Returns(options);
            IDataService dataService = new DataService(configurationMock.Object);
            bool actual = dataService.ExistDatabaseFile();

            Assert.True(actual);
            File.Delete(filePath);
        }
    }
}
