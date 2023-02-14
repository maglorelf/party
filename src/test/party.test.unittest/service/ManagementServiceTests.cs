namespace party.test.unittest.service
{
    using Moq;
    using party.core.infrastructure;
    using party.service;
    using party.service.data;
    using Xunit;

    public class ManagementServiceTests
    {
        [Fact]
        public void GenerateEmptyEventTest()
        {
            Mock<IDataService> dataServiceMock = new(MockBehavior.Strict);
            dataServiceMock.Setup(m => m.CheckDatabase()).Returns(ResultValue<string>.NewOk());
            dataServiceMock.Setup(m => m.InitializeDatabase());
            IManagementService service = new ManagementService(dataServiceMock.Object);

            ResultValue<string> actual = service.GenerateEvent();

            dataServiceMock.Verify(m => m.CheckDatabase(), Times.Once);
            dataServiceMock.Verify(m => m.InitializeDatabase(), Times.Once);
            Assert.True(actual.Success);
        }
    }
}
