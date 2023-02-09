namespace party.test.unittest.service
{
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.infrastructure;
    using party.core.model;
    using party.service;
    using party.service.data;
    using Xunit;

    public class ManagementServiceTests
    {
        [Fact]
        public void GenerateEmptyEventTest()
        {
            var options = new Configuracion()
            {
                Event = @"C:\TEMP\EVENT1",
                DatabaseName = "database.db"
            };
            Mock<IOptionsSnapshot<Configuracion>> configurationMock = new();
            configurationMock.Setup(m => m.Value).Returns(options);

            IDataService dataService = Mock.Of<IDataService>(m => m.CheckDatabase() == ResultValue<string>.NewOk());
            IManagementService service = new ManagementService(dataService);
            ResultValue<string> actual = service.GenerateEvent();
            Assert.True(actual.Success);

        }
    }
}
