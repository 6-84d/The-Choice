using SecondVersion.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace The_choice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height = SystemParameters.PrimaryScreenHeight;
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.WindowState = WindowState.Maximized;
        }

        private void OptionsPage_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }
    }
}
