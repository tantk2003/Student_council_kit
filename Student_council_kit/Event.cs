using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class Event
    {
        public Event()
        {
            EventsParticipants = new HashSet<EventsParticipant>();
        }

        public long IdEvent { get; set; }
        public long IdDirection { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public virtual Direction IdDirectionNavigation { get; set; }
        public virtual ICollection<EventsParticipant> EventsParticipants { get; set; }
    }
}
