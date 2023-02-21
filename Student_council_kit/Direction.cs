using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class Direction
    {
        public Direction()
        {
            Events = new HashSet<Event>();
        }

        public long IdDirection { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
