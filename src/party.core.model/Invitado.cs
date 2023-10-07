namespace party.core.model
{
    using System;
    using party.core.attributes;
    public class Invitado
    {
        public Invitado()
        {
            Notas = string.Empty;
            Nombre = string.Empty;
            EventoLocal = string.Empty;
            Evento = string.Empty;
            Extra = string.Empty;
            DNI = string.Empty;
            Email = string.Empty;
            Oficina = string.Empty;
            QRLeido = string.Empty;
            Asistencia = string.Empty;
            Registrado = string.Empty;
        }
        public int Id { get; set; }
        public int Codigo { get; set; }

        [VisibleGrid("Nombre", 0)]
        public string Nombre { get; set; }
        public string Evento { get; set; }

        [VisibleGrid("Local", 3)]
        public string EventoLocal { get; set; }
        public string Extra { get; set; }

        [VisibleGrid("DNI", 1)]
        public string DNI { get; set; }
        public string Email { get; set; }

        [VisibleGrid("Oficina Empleado", 2)]
        public string Oficina { get; set; }
        public string QRLeido { get; set; }

        [VisibleGrid("Confirmado", 4)]
        public string Asistencia { get; set; }

        [VisibleGrid("Registrado", 5)]
        public string Registrado { get; set; }

        [VisibleGrid("Notas", 6)]
        public string Notas { get; set; }
        public bool IsRegistrado => Registrado == "Sí";
        public bool IsConfirmado => Asistencia == "Sí";
        public Guid EventId { get; set; }
        public Guid RouteId { get; set; }

        public bool HasValuesMinimos()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(DNI) && !string.IsNullOrEmpty(Notas);
        }
    }
}
