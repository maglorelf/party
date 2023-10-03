namespace party.core.model
{
    using System;
    using party.core.attributes;

    public class Route
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        [VisibleGrid("Nombre", 0)]
        public string Name { get; set; }
        [VisibleGrid("Localización", 2)]
        public string Location { get; set; }
        [VisibleGrid("Descripción", 1)]
        public string Description { get; set; }
        public Route()
        {
            Id = Guid.NewGuid();
        }
    }
}
