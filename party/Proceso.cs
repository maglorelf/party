using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace party
{
    public class Proceso
    {
        protected Configuracion configuracion { get; set; }
        protected DataService dataService { get; set; }
        public Proceso(Configuracion configuracion, DataService dataService)
        {
            this.configuracion = configuracion;
            this.dataService = dataService;
        }

        private bool verificarAsistente(Asistente asistente)
        {
            return asistente == null;
        }
        private bool verificarInvitado(Invitado invitado)
        {
            bool verificado = false;
            if (invitado != null)
            {
                if (invitado.EventoLocal == configuracion.Evento && invitado.IsConfirmado)
                {
                    verificado = true;
                }
            }
            return verificado;
        }


        public (ResultadoCheck, Invitado, Asistente) CheckQR(string qr)
        {
            Asistente asistente = null;
            Invitado invitado = null;
            ResultadoCheck result = ResultadoCheck.NoValue;
            if (!string.IsNullOrWhiteSpace(qr))
            {
                result = ResultadoCheck.NoExiste;
                string emailInvitado = desglosaQRGetEmail(qr);               
                invitado = dataService.GetInvitadoByEmail(emailInvitado);
                if (invitado != null)
                {
                    result = ResultadoCheck.DatosIncorrectos;
                    if (verificarInvitado(invitado))
                    {
                        asistente = dataService.GetAsistenteByIdInvitado(invitado.Id);
                        if (verificarAsistente(asistente))
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

        private string desglosaQRGetEmail(string qr)
        {
            string emailInvitado = string.Empty;
            var match = Regex.Match(qr, @"(?i)USUARIO DEL INVITADO:\s+(.+?)\s+NOMBRE DEL INVITADO:");
            if (match.Success)
            {
                emailInvitado = match.Groups[1].Value;
            }
            return emailInvitado;
        }

        internal void AceptarInvitado(Invitado invitado)
        {
            Asistente asistente = new Asistente { InvitadoId = invitado.Id, QRLeido = invitado.QRLeido, Entrada = DateTime.Now };
            dataService.InsertAsistente(asistente);
        }

        internal void BorrarAsistente(Asistente asistente)
        {
            dataService.BorrarAsistente(asistente.Id);
        }
    }
}