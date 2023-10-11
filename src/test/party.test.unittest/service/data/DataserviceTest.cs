﻿namespace party.test.unittest.service.data
{
    using System.IO;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.settings;
    using party.service.data;
    using Xunit;

    public class DataserviceTest
    {
        private readonly Mock<ILogger<IDataService>> mockLogger = new();

        [Fact]
        public void ExistDatabaseFile_FailCheckMissingDatabase()
        {
            string filePath = Path.GetTempFileName();
            File.Delete(filePath);

            var options = new SettingsAppData()
            {
                EventPath = Path.GetDirectoryName(filePath),
                DatabaseName = Path.GetFileName(filePath)
            };
            Mock<IOptionsMonitor<SettingsAppData>> configurationMock = new(MockBehavior.Strict);
            configurationMock.Setup(m => m.CurrentValue).Returns(options);
            IDataService dataService = new DataService(configurationMock.Object, mockLogger.Object);
            bool actual = dataService.ExistDatabaseFile();

            Assert.False(actual);
        }
        [Fact]
        public void ExistDatabaseFile_SuccessCheckCreatedFile()
        {
            string filePath = Path.GetTempFileName();
            var options = new SettingsAppData()
            {
                EventPath = Path.GetDirectoryName(filePath),
                DatabaseName = Path.GetFileName(filePath)
            };
            Mock<IOptionsMonitor<SettingsAppData>> configurationMock = new(MockBehavior.Strict);
            configurationMock.Setup(m => m.CurrentValue).Returns(options);
            IDataService dataService = new DataService(configurationMock.Object, mockLogger.Object);
            bool actual = dataService.ExistDatabaseFile();

            Assert.True(actual);
            File.Delete(filePath);
        }
    }
}
