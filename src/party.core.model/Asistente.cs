namespace party.core.model
{
    using System;
    using party.core.attributes;
    public class Asistente
    {
        public int Id;
        [VisibleGrid("Hora de entrada", 0)]
        public DateTime Entrada { get; set; }
        public int InvitadoId { get; set; }
        public string QRLeido { get; set; }
        [VisibleGrid("Nombre", 1)]
        public string Nombre { get; set; }
        [VisibleGrid("DNI", 2)]
        public string DNI { get; set; }
        [VisibleGrid("Email", 0)]
        public string Email { get; set; }
        [VisibleGrid("Local", 0)]
        public string Evento { get; set; }
        [VisibleGrid("Notas", 3)]
        public string Notas { get; set; }
    }
}
