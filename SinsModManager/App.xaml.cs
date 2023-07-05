using SinsModManager.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SinsModManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            PathHandler handler = new PathHandler();
            handler.RebellionPathBuilder(); //checks my documents for the rebellion mods folder

            wnd.Show();
        }
    }
}
