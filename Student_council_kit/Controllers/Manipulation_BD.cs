using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_council_kit.Controllers
{
    public class Manipulation_BD
    {
        public static void AddUser(string name, string surname, string patronymic, long faculty, long numgroup, string email, string login, string password)
        {
            using (student_councilContext db = new student_councilContext())
            {
                db.Users.Add(new User()
                {
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    IdFaculty = faculty,
                    NumGroup = numgroup,
                    Email = email,
                    Login = login,
                    Password = password,
                    Role = "Студент"
                });
                db.SaveChanges();
            }
        }

        public static bool AddEvent(long id_direction, string name, string description, string date)
        {
            using (student_councilContext db = new student_councilContext())
            {
                db.Events.Add(new Event()
                {
                    IdDirection = id_direction,
                    Name = name,
                    Description = description,
                    Date = date,
                    Status = "Предстоящее"
                });
                db.SaveChanges();
                return true;
            }
        }
    }
}
