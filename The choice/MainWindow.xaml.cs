using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            ApiHelper.InitializeClient();
            MainFrame.NavigationService.Navigate(new MainPage());
            this.WindowState = WindowState.Maximized;
        }
        private void OptionsPage_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }
        private void CryptoPage_Click(object sender, RoutedEventArgs e)
        {
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/back_curr.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainFrame.NavigationService.Navigate(new CryptoPage(MainFrame));
        }
        private void CurrenciesPage_Click(object sender, RoutedEventArgs e)
        {
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/back_curr.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainFrame.NavigationService.Navigate(new CurrenciesPage(MainFrame));
        }
        private void MaterialsPage_Click(object sender, RoutedEventArgs e)
        {
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/back_curr.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainFrame.NavigationService.Navigate(new MaterialsPage(MainFrame));
        }
        private void SharesPage_Click(object sender, RoutedEventArgs e)
        {
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/back_curr.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            MainFrame.NavigationService.Navigate(new SharesPage());
        }
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MainPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Background.jpg")));
            SecondGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Lines.png")));
        }
    }
}
