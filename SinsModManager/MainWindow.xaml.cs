using SinsModManager.Dialogs;
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
using static SinsModManager.Classes.PathHandler;

namespace SinsModManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MenuItemSettings_Click(object sender, RoutedEventArgs e)
        {
            settingsDialogWINDOW settingsDialogWINDOW = new settingsDialogWINDOW();
            if(settingsDialogWINDOW.ShowDialog() == true)
            {
                //Confirm all values that came from settings dialog
                return;
            }
        }

        private void MenuItemAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutDialogWINDOW aboutDialogWINDOW = new AboutDialogWINDOW();
            if(aboutDialogWINDOW.ShowDialog() == true) { return; }

            
        }
        
        private void btnSetRebellionModsPath_Click(object sender, RoutedEventArgs e)
        {
            UserRebellionModPath userRebellionModPath = new UserRebellionModPath();
            if (userRebellionModPath.FolderSelectDialog())
                return;



        }
    }
}
