using System;
using Student_council_kit.Views;
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
    /// Логика взаимодействия для My_EventsWindow.xaml
    /// </summary>
    public partial class My_EventsWindow : Window
    {

        public My_EventsWindow(User user)
        {
            InitializeComponent();
        }
        public My_EventsWindow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }
    }
}
