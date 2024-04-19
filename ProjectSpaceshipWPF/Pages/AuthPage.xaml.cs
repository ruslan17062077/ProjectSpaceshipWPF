﻿using ProjectSpaceshipWPF.Pages;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void RegistrBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (App.db.Passenger.FirstOrDefault(x => x.Pasport_Number.ToString() == pasportTb.Text) != null)
            {
                MessageBox.Show("Вы успешно вошли!");
                App.mainWindow.MainFrame.NavigationService.Navigate(new ListSpaceShip(App.db.Passenger.FirstOrDefault(x => x.Pasport_Number.ToString() == pasportTb.Text)));
            }
            else
            {
                MessageBox.Show("Нет такого аккаунта!");
            }
        }

        private void GuestInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewFlightDGPage());
        }
    }
}
