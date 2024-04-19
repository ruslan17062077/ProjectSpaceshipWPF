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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectSpaceshipWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewFlightDGPage.xaml
    /// </summary>
    public partial class ViewFlightDGPage : Page
    {
        public ViewFlightDGPage()
        {
            InitializeComponent();
            FlightDataGrid.ItemsSource = App.db.Flight.ToList();
            FlightDataGrid.DataContext = App.db.Flight.ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
