using System;

namespace CalendarApplication.View
{
    class EventForm
    {
        public string Name { get; set; }
        public string Color{ get; set; }
        public DateTime StartDateTime{ get; set; }
        public DateTime EndDateTime{ get; set; }
        public Alarm Alarm{ get; set; }
        public string Place{ get; set; }
        public string Description{ get; set; }

        public EventForm(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public EventForm(string Name, string Color, string Description)
        {
            this.Name = Name;
            this.Color = Color;
            this.Description = Description;
        }

        public EventForm(string Name, string Color, string Place)
        {
            this.Name = Name;
            this.Color = Color;
            this.Place = Place;
        }

        public EventForm(string Name, string Color, string Description, string Place)
        {
            this.Name = Name;
            this.Color = Color;
            this.Description = Description;
            this.Place = Place;
        }

        public EventForm(string Name, string Color, DateTime StartDateTime, DateTime EndDateTime )
        {
            this.Name = Name;
            this.Color = Color;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
        }

        public EventForm(string Name, string Color, string Description, string Place, DateTime StartDateTime, DateTime EndDateTime)
        {
            this.Name = Name;
            this.Color = Color;
            this.Description = Description;
            this.Place = Place;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
        }
    }
}
