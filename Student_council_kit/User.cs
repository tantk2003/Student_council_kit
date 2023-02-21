using System;
using System.Collections.Generic;

#nullable disable

namespace Student_council_kit
{
    public partial class User
    {
        public User()
        {
            EventsParticipants = new HashSet<EventsParticipant>();
            StudentCouncils = new HashSet<StudentCouncil>();
        }

        public long IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public long IdFaculty { get; set; }
        public long NumGroup { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; }
        public virtual ICollection<EventsParticipant> EventsParticipants { get; set; }
        public virtual ICollection<StudentCouncil> StudentCouncils { get; set; }
    }
}
