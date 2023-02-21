using Student_council_kit.Models;
using Student_council_kit.Views;
using System;
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
    /// Логика взаимодействия для Personal_AccountWindow.xaml
    /// </summary>
    public partial class Personal_AccountWindow : Window
    {
        public Faculty faculty = null;
        public Personal_AccountWindow(User user)
        {
            InitializeComponent();
            if (user.Role == "Студсоветчик")
            {
                btn_create_event.Visibility = Visibility.Visible;
                btn_student_list.Visibility = Visibility.Visible;
                btn_all_events.Visibility = Visibility.Hidden;
                btn_my_events.Visibility = Visibility.Hidden;
            }
            else
            {
                btn_all_events.Visibility = Visibility.Visible;
                btn_my_events.Visibility = Visibility.Visible;
                btn_create_event.Visibility = Visibility.Hidden;
                btn_student_list.Visibility = Visibility.Hidden;
            }
            DataContext = user;
            using (student_councilContext db = new student_councilContext())
            {
                 faculty = db.Faculties.ToList().FirstOrDefault(x => (x.IdFaculty == user.IdFaculty));
            }
            tblock_faculty.Text = faculty.NameFaculty;
        }
        public Personal_AccountWindow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            Hide();
            autorizationWindow.Show();
        }

        private void btn_all_events_Click(object sender, RoutedEventArgs e)
        {
            DirectoriesWindow directoriesWindow = new DirectoriesWindow();
            Hide();
            directoriesWindow.Show();
        }

        private void btn_create_event_Click(object sender, RoutedEventArgs e)
        {
            Create_EventWindow createEventWindow = new Create_EventWindow();
            Hide();
            createEventWindow.Show();
        }

        private void btn_my_events_Click(object sender, RoutedEventArgs e)
        {
            My_EventsWindow my_EventsWindow = new My_EventsWindow(AutorizationWindow.user);
            Hide();
            my_EventsWindow.Show();
        }
    }
}
