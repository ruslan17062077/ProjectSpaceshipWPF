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

namespace ProjectSpaceshipWPF.Components
{
    /// <summary>
    /// Логика взаимодействия для Space.xaml
    /// </summary>
    public partial class Space : UserControl
    {
        private Flight_PlanetLinks flight_PlanetLinks;
        public Space(Flight_PlanetLinks _flight_PlanetLinks)
        {
            Random random = new Random();
            InitializeComponent();
            flight_PlanetLinks = _flight_PlanetLinks;
            NameTb.Text += $" {flight_PlanetLinks.Flight.Spaceship.Name}";
            MestoPodTB.Text = $"{App.db.Planet.Where(x=> x.id == flight_PlanetLinks.PlanetLinks.PlanetStart_Id)}";
            MestoTB.Text = $"{random.Next(0, 5)}";
        }
    }
}
