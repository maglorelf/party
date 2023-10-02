namespace party.core.model
{
    using System;
    using System.Collections.Generic;

    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CheckIn { get; set; }

        public List<Route> Routes { get; set; }
        public Event()
        {
            Routes = new List<Route>();
        }
    }
}
