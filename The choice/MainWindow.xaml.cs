using System;
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
            this.Height = SystemParameters.PrimaryScreenHeight;
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.WindowState = WindowState.Maximized;
            ApiHelper.InitializeClient();
            MainFrame.NavigationService.Navigate(new MainPage());
        }
        private void OptionsPage_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }
        private void CryptoPage_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            MainFrame.NavigationService.Navigate(new CryptoPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/SecondBack.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
=======
            MainFrame.NavigationService.Navigate(new CryptoPage(MainFrame));
>>>>>>> 4d85faa8834ec3144462c9ff1be3792c49d91d9f
        }
        private void CurrenciesPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new CurrenciesPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/SecondBack.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }
        private void MaterialsPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MaterialsPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/SecondBack.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }
        private void SharesPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SharesPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/SecondBack.png")));
            SecondGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MainPage());
            MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Background.jpg")));
            SecondGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Lines.png")));
        }
    }
}
