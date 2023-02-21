using System;
using Student_council_kit.Controllers;
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
    /// Логика взаимодействия для Create_EventWindow.xaml
    /// </summary>
    public partial class Create_EventWindow : Window
    {
        public Create_EventWindow()
        {
            InitializeComponent();
            cbox_direction.ItemsSource = student_councilContext.GetContext().Directions.ToList();
        }

        private void btn_add_event_Click(object sender, RoutedEventArgs e)
        {
            if(Manipulation_BD.AddEvent(cbox_direction.SelectedIndex+1, tbox_name.Text, tbox_description.Text, dpicker_date.Text))
            {
                MessageBox.Show("Мероприятие успешно создано!");
            }
            else
            {
                MessageBox.Show("Ошибка! Повторите попытку.");
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }
    }
}
