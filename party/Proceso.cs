using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public (ResultadoCheck, Asistente) GetQR(string qr)
        {
            Asistente asistente = null;
            ResultadoCheck result = ResultadoCheck.NoValue;
            if (!string.IsNullOrWhiteSpace(qr))
            {
                result = ResultadoCheck.NoExiste;
                Invitado invitado = dataService.GetInvitadoByQR(qr);
                if (verificarInvitado(invitado))
                {
                    asistente = dataService.GetAsistenteByIdInvitado(invitado.Id);
                    if (verificarAsistente(asistente))
                    {
                        asistente = new Asistente { InvitadoId = invitado.Id, QRLeido = qr, Entrada = DateTime.Now };
                        dataService.InsertAsistente(asistente);
                        result = ResultadoCheck.PuedeEntrar;
                    }
                    else
                    {
                        result = ResultadoCheck.Registrado;
                    }
                }
            }
            (ResultadoCheck, Asistente) resultComplete = ((ResultadoCheck)result, asistente);
            return resultComplete;
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
                if (invitado.Evento == configuracion.Evento)
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

                invitado = dataService.GetInvitadoByQR(qr);
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
            (ResultadoCheck, Invitado, Asistente) resultComplete = ((ResultadoCheck)result, invitado, asistente);
            return resultComplete;
        }

        internal void AceptarInvitado(Invitado invitado)
        {

            Asistente asistente = new Asistente { InvitadoId = invitado.Id, QRLeido = string.Empty, Entrada = DateTime.Now };
            dataService.InsertAsistente(asistente);
        }
    }
}
