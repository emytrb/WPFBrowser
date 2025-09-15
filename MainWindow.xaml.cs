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

namespace WPFBrowser
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

        private void Button_Connect(object sender, RoutedEventArgs e)
        {
            _wb.Navigate(_cb.Text);
        }

        private void WebBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            string ad = e.Uri.AbsoluteUri;
            _cb.Text = ad;
            if(!_cb.Items.Contains(ad))_cb.Items.Add(ad);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
            {

                string ad = (string)e.AddedItems[0];

                _wb.Navigate(ad);

            }

        }
    }
}
