using SinsModManager.Classes;
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
using System.Windows.Shapes;

namespace SinsModManager.Dialogs
{
    /// <summary>
    /// Interaction logic for settingsDialogWINDOW.xaml
    /// </summary>
    public partial class settingsDialogWINDOW : Window
    {
        public settingsDialogWINDOW()
        {
            InitializeComponent();
        }

        private void btnSettingsConfirm_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnSettingsBrowseToSinsEXE_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Function is currently Broken. plz fix.");
        }
    }
}
