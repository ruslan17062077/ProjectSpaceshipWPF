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
    /// Логика взаимодействия для TroublesPage.xaml
    /// </summary>
    public partial class TroublesPage : Page
    {
        public TroublesPage()
        {
            InitializeComponent();
            TroublesDataGrid.ItemsSource = App.db.Trouble_Planet.ToList();
            Refresh();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           Refresh();

        }
        void Refresh()
        {
            TroublesDataGrid.ItemsSource = null;
            if(SearchTb.Text.Length > 0)
            {
                TroublesDataGrid.ItemsSource = App.db.Trouble_Planet.Where(x => x.Planet.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }
            else
            {
                TroublesDataGrid.ItemsSource = App.db.Trouble_Planet.ToList();
            }
        }

        private void bcbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
