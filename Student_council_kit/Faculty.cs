using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class Faculty
    {
        public Faculty()
        {
            Users = new HashSet<User>();
        }

        public long IdFaculty { get; set; }
        public string NameFaculty { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
