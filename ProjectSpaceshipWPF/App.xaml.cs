using ProjectSpaceshipWPF.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectSpaceshipWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SpaceshipCompanyEntities db = new SpaceshipCompanyEntities();
        public static MainWindow mainWindow;
    }
}
