using ProjectSpaceshipWPF.Components;
using ProjectSpaceshipWPF.Pages;
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

namespace ProjectSpaceshipWPF
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
            GenderCb.ItemsSource = App.db.Gender.ToList();
            GenderCb.DisplayMemberPath = "Gender_Name";
        }

        private void RegistrBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var selgender = GenderCb.SelectedItem as Gender;
                Passenger passenger = App.db.Passenger.Add(new Components.Passenger()
                {
                    LastName = LastNameTb.Text,
                    FirstName = firstNameTb.Text,
                    Patronymic = PatronymicTb.Text,
                    Pasport_Number = int.Parse(Pasport_numberTb.Text),
                    DateOfBirth = DateOfBirthDP.SelectedDate,
                    Gender = selgender.Gender_Name,
                    Weight = int.Parse(WeightTb.Text)
                });
                App.db.SaveChanges();
                App.mainWindow.MainFrame.NavigationService.Navigate(new ListSpaceShip(passenger));
            } catch (Exception ex) { MessageBox.Show("Errors"); NavigationService.Navigate(new AuthPage()); };
               
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
