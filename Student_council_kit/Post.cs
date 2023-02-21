using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class Post
    {
        public Post()
        {
            StudentCouncils = new HashSet<StudentCouncil>();
        }

        public long IdPost { get; set; }
        public string NamePost { get; set; }

        public virtual ICollection<StudentCouncil> StudentCouncils { get; set; }
    }
}
