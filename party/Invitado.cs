﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class Invitado
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Evento { get; set; }
        public string EventoLocal { get; set; }
        public string Extra { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Oficina { get; set; }
        public string Asistencia { get; set; }
    }
}
