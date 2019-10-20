using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class Proceso
    {
        public DataService DataService { get; set; }
        public (ResultadoCheck, Asistente) GetQR(string qr)
        {
            Asistente asistente = null;
            ResultadoCheck result = ResultadoCheck.NoValue;
            if (!string.IsNullOrWhiteSpace(qr))
            {
                result = ResultadoCheck.NoExiste;
                Invitado invitado = DataService.GetInvitadoByQR(qr);
                if (invitado != null)
                {
                    asistente = DataService.GetAsistenteByIdInvitado(invitado.Id);
                    if (asistente == null)
                    {
                        asistente = new Asistente { InvitadoId = invitado.Id, QRLeido = qr, Entrada = DateTime.Now };
                        DataService.InsertAsistente(asistente);
                        result = ResultadoCheck.Correcto;
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

        internal Configuracion LeerConfiguracion()
        {
            Configuracion configuracion = new Configuracion
            {

                DatabaseName = party.Properties.Settings.Default.DatabaseName,
                CSVSeparationLetter = party.Properties.Settings.Default.CSVSeparationLetter
            };
            return configuracion;
        }
    }
}
