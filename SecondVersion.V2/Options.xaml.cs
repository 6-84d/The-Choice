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

namespace SecondVersion.V2
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Source = new Uri("AboutUs.xaml",UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.Source = new Uri("MainSettings.xaml", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame.Source = new Uri("Tutorial.xaml", UriKind.Relative);
        }
    }
}
