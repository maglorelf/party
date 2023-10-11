namespace party.test.unittest.service
{
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.model;
    using party.core.settings;
    using party.service;
    using party.service.data;
    using Xunit;

    public class ProcesoTests
    {
        [Fact]
        public void AceptarInvitado_ExistingGuest_Accepted()
        {
            Invitado invitado = new() { Id = 1, QRLeido = "QR" };

            Mock<IDataService> dataServiceMock = new(MockBehavior.Strict);
            dataServiceMock.Setup(service => service.InsertAsistente(It.IsAny<Asistente>()));
            Mock<IOptionsSnapshot<SettingsAppData>> options = new(MockBehavior.Strict);
            options.Setup(option => option.Value).Returns(new SettingsAppData()); ;
            IProceso proceso = new Proceso(options.Object, dataServiceMock.Object);
            proceso.AceptarInvitado(invitado);
        }
    }
}
