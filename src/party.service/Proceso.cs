namespace party.service
{
    using System;
    using System.Text.RegularExpressions;
    using Microsoft.Extensions.Options;
    using party.core.enums;
    using party.core.model;
    using party.service.data;
    public class Proceso : IProceso
    {
        protected Configuracion Configuracion { get; set; }
        protected IDataService DataService { get; set; }
        public Proceso(IOptionsSnapshot<Configuracion> configuracion, IDataService dataService)
        {
            this.Configuracion = configuracion.Value;
            this.DataService = dataService;
        }


        public (ResultadoCheck, Invitado, Asistente) CheckQR(string qr)
        {
            Asistente asistente = null;
            Invitado invitado = null;
            ResultadoCheck result = ResultadoCheck.NoValue;
            if (!string.IsNullOrWhiteSpace(qr))
            {
                result = ResultadoCheck.NoExiste;
                string emailInvitado = DesglosaQRGetEmail(qr);
                invitado = DataService.GetInvitadoByEmail(emailInvitado);
                if (invitado != null)
                {
                    result = ResultadoCheck.DatosIncorrectos;
                    if (VerificarInvitado(invitado))
                    {
                        asistente = DataService.GetAsistenteByIdInvitado(invitado.Id);
                        if (VerificarAsistente(asistente))
                        {
                            result = ResultadoCheck.PuedeEntrar;
                        }
                        else
                        {
                            result = ResultadoCheck.Registrado;
                        }
                    }
                }
            }
            (ResultadoCheck, Invitado, Asistente) resultComplete = ((ResultadoCheck)result, invitado, asistente);
            return resultComplete;
        }


        public void AceptarInvitado(Invitado invitado)
        {
            Asistente asistente = new() { InvitadoId = invitado.Id, QRLeido = invitado.QRLeido, Entrada = DateTime.Now };
            DataService.InsertAsistente(asistente);
        }

        public void BorrarAsistente(Asistente asistente)
        {
            DataService.BorrarAsistente(asistente.Id);
        }
        private static bool VerificarAsistente(Asistente asistente)
        {
            return asistente == null;
        }
        private bool VerificarInvitado(Invitado invitado)
        {
            bool verificado = false;
            if (invitado != null)
            {
                if (invitado.EventoLocal == Configuracion.Event && invitado.IsConfirmado)
                {
                    verificado = true;
                }
            }
            return verificado;
        }
        private static string DesglosaQRGetEmail(string qr)
        {
            string emailInvitado = string.Empty;
            var match = Regex.Match(qr, @"(?i)USUARIO DEL INVITADO:\s+(.+?)\s+NOMBRE DEL INVITADO:");
            if (match.Success)
            {
                emailInvitado = match.Groups[1].Value;
            }
            return emailInvitado;
        }
    }
}
