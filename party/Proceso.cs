using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class Proceso
    {

        public (ResultadoCheck, Asistente) GetQR(string qr)
        {
            int result = new Random().Next(0, 4);
            Asistente asistente = new Asistente { Nombre = "Nombre" };
            (ResultadoCheck, Asistente) resultComplete = ((ResultadoCheck)result, asistente);
            return resultComplete;
        }
    }
}
