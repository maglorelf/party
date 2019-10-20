using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class Asistente
    {
        public int Id;
        public DateTime Entrada { get; set; }
        public int InvitadoId{ get; set; }
        public string QRLeido { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
    }
}
