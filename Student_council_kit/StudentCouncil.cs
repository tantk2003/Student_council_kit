using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class StudentCouncil
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public long IdPost { get; set; }

        public virtual Post IdPostNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
