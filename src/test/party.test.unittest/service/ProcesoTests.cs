namespace party.test.unittest.service
{
    using Microsoft.Extensions.Options;
    using Moq;
    using party.core.model;
    using party.service;
    using party.service.data;

    public class ProcesoTests
    {
        [Fact]
        public void AceptarInvitado_ExistingGuest_Accepted()
        {
            Invitado invitado = new() { Id = 1, QRLeido = "QR" };

            IDataService dataService = Mock.Of<IDataService>();
            IOptionsSnapshot<Configuracion> options = Mock.Of<IOptionsSnapshot<Configuracion>>();
            IProceso proceso = new Proceso(options, dataService);
            proceso.AceptarInvitado(invitado);
        }
    }
}
