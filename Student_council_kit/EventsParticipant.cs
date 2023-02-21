using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class EventsParticipant
    {
        public long Id { get; set; }
        public long IdEvent { get; set; }
        public long IdUser { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
