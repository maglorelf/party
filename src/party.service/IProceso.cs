using party.core.enums;
using party.core.model;

namespace party.service
{
    public interface IProceso
    {
        void AceptarInvitado(Invitado invitado);
        void BorrarAsistente(Asistente asistente);
        (ResultadoCheck, Invitado, Asistente) CheckQR(string qr);
    }
}