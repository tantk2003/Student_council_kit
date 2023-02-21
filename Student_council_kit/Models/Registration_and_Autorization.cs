using Student_council_kit.Views;
using Student_council_kit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Student_council_kit.Models
{
    public class Registration_and_Autorization
    {
        public static bool Login(string login, string password)
        {
            if (login == "" && password == "")
            {
                MessageBox.Show("Вы не ввели данные!");
                return false;
            }
            using (student_councilContext db = new student_councilContext())
            {
                var user = db.Users.ToList().FirstOrDefault(x => (x.Login == login) && (x.Password == password));
                if (user == null)
                {
                    user = student_councilContext.GetContext().Users.Where(x => x.Login == login).FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("Введен неверный пароль!");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден!");
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool SignUp(string name, string surname, string patronymic, long faculty, long numgroup, string email, string login, string password)
        {

            using (student_councilContext db = new student_councilContext())
            {
                if (name == "" || surname == "" || patronymic == "" || faculty == 0 || numgroup == 0 || email == "" || login == "" || password == "")
                {
                    MessageBox.Show("Пустые данные");
                    return false;
                }
                var user = db.Users.FirstOrDefault(x => x.Login == login);
                if (user != null)
                {
                    MessageBox.Show("Невозможно создать нового пользователя, т.к такой уже зарегистрирован");
                    return false;
                }
                else
                {
                    Manipulation_BD.AddUser(name, surname, patronymic, faculty, numgroup, email, login, password);
                    return true;
                }
            }
        }
    }
}
