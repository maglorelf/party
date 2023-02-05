namespace party.test.unittest.service
{
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.model;
    using party.service;
    using party.service.data;
    using Xunit;

    public class ManagementServiceTests
    {
        [Fact]
        public void GenerateEmptyEventTest()
        {
            string eventPath = @"C:\TEMP\EVENT1";
            IOptionsSnapshot<Configuracion> options = Mock.Of<IOptionsSnapshot<Configuracion>>();
            options.Value.EventPath = eventPath;
            IDataService dataService = Mock.Of<IDataService>();
            IManagementService service = new ManagementService(dataService);
            service.GenerateEvent();
        }
    }
}
