using System;
using Student_council_kit.Views;
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
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Student_council_kit.Views
{
    /// <summary>
    /// Логика взаимодействия для Events_DirectionsWindow.xaml
    /// </summary>
    public partial class Events_DirectionsWindow : Window
    {
        public Events_DirectionsWindow(Direction selectedDirection)
        {
            InitializeComponent();
            var enableEvents = student_councilContext.GetContext().Events.Where(x => x.IdDirection == selectedDirection.IdDirection).ToList();
            dgrid_events.ItemsSource = enableEvents;
        }

        private void dgrid_events_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var selectedEvent = dgrid_events.SelectedItems.Cast<Event>().ToList();
            foreach (var item in selectedEvent)
            {
                tblock_name.Text = item.Name;
                tblock_description.Text = item.Description;
                tblock_date.Text = item.Date;
                tblock_status.Text = item.Status;
            }
        }

        private void btn_enroll_Click(object sender, RoutedEventArgs e)
        {
            var selectedEvent = dgrid_events.SelectedItems.Cast<Event>().ToList();
            if(Enroll_and_Other.Enroll(selectedEvent,AutorizationWindow.user))
            {
                MessageBox.Show("Вы успешно записались на данное мероприятие!");
            }
            else
            {
                MessageBox.Show("Ошбка! Вы уже записаны на это мероприятие.");
            }

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            DirectoriesWindow directoriesWindow = new DirectoriesWindow();
            Hide();
            directoriesWindow.Show();
        }
    }
}
