using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;

namespace SinsModManager.Dialogs
{
    /// <summary>
    /// Interaction logic for AboutDialogWINDOW.xaml
    /// </summary>
    public partial class AboutDialogWINDOW : Window
    {
        public AboutDialogWINDOW()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            e.Handled = true;
        }

        private void btnAboutExit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
