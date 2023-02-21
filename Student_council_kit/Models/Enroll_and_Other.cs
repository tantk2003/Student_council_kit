using Student_council_kit.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_council_kit.Models
{
    public class Enroll_and_Other
    {
        public static bool Enroll(List<Event> selectedEvent, User currentUser)
        {
            int id_user = Convert.ToInt32(currentUser.IdUser);
            int id_event = 0;
            foreach (var item in selectedEvent)
            {
                id_event = Convert.ToInt32(item.IdEvent);
            }
            EventsParticipant eventsParticipant = new EventsParticipant()
            {
                IdUser = id_user,
                IdEvent = id_event
            };
            var checkEnroll = student_councilContext.GetContext().EventsParticipants.FirstOrDefault(x => x.IdEvent == id_event && x.IdUser == id_user);
            if (checkEnroll == null)
            {
                try
                {
                    student_councilContext.GetContext().EventsParticipants.Add(eventsParticipant);
                    student_councilContext.GetContext().SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
