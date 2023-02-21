using System;
using Student_council_kit.Models;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Registration_Window.xaml
    /// </summary>
    public partial class Registration_Window : Window
    {
        public User user = null;
        public Registration_Window()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            if(Registration_and_Autorization.SignUp(name_reg.Text, surname_reg.Text,patronmic_reg.Text,Convert.ToInt64(faculty_reg.Text),Convert.ToInt64(numgroup_reg.Text),email_reg.Text,login_reg.Text,password_reg.Text))
            {
                MessageBox.Show("Пользователь зарегистрирован!");
                AutorizationWindow autorizationWindow = new AutorizationWindow();
                Hide();
                autorizationWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неудачная попытка регистрации!");
            }

        }
    }
}
