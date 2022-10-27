namespace party.service
{
    using party.core.enums;
    using party.core.model;
    public interface IProceso
    {
        void AceptarInvitado(Invitado invitado);
        void BorrarAsistente(Asistente asistente);
        (ResultadoCheck, Invitado, Asistente) CheckQR(string qr);
    }
}
