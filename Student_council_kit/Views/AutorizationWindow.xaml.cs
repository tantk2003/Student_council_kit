using Student_council_kit.Models;
using Student_council_kit.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Student_council_kit.Views
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public int counter = 0;
        public static User user = null;
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "";
            if(counter == 0)
            {
                pass = tbox_password.Password;
            }
            else
            {
                pass = tbox_pass_open.Text;
            }
            if (Registration_and_Autorization.Login(tbox_login.Text, pass))
            {
                MessageBox.Show("Вход выполнен успешно!");
                using (student_councilContext db = new student_councilContext())
                {
                     user = db.Users.ToList().FirstOrDefault(x => (x.Login == tbox_login.Text));
                }
                Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(user);
                Hide();
                personal_AccountWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Повторите попытку!");
            }

        }

        private void Create_button_Click(object sender, RoutedEventArgs e)
        {
            Registration_Window registration_Window = new Registration_Window();
            Hide();
            registration_Window.Show();
        }

        private void btn_show_pass_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                tbox_pass_open.Visibility = Visibility.Visible;
                tbox_pass_open.Text = tbox_password.Password;
                tbox_password.Visibility = Visibility.Hidden;
            }
            else
            {
                tbox_password.Visibility = Visibility.Visible;
                tbox_password.Password = tbox_pass_open.Text;
                tbox_pass_open.Visibility = Visibility.Hidden;
                counter = 0;
            }
        }
    }
}
