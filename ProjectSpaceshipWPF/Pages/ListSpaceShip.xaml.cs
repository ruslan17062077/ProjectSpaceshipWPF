using ProjectSpaceshipWPF.Components;
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
    /// Логика взаимодействия для ListSpaceShip.xaml
    /// </summary>
    public partial class ListSpaceShip : Page
    {
        private Passenger passenger;
        public ListSpaceShip(Passenger _passenger)
        {
            InitializeComponent();
            passenger = _passenger;
            planetCb.ItemsSource = App.db.Planet.ToList();
            planetCb.DisplayMemberPath = "Name";
            Refresh();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.NavigationService.Navigate(new AuthPage());
        }

        private void TroublesBtns_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TroublesPage());
        }

        void Refresh()
        {
            WP.Children.Clear();
            if (planetCb.SelectedIndex == -1)
            {
                foreach (var item in App.db.Flight_PlanetLinks.ToList())
                {
                    WP.Children.Add(new Space(item));
                }
            }
            else
            {
                var selplanet = planetCb.SelectedItem as Planet;
                foreach (var item in App.db.Flight_PlanetLinks.Where(x => x.PlanetLinks.PlanetStart_Id == selplanet.id).ToList())
                {
                    WP.Children.Add(new Space(item));
                }
            }
        }

        private void planetCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
