using System.Windows;

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
            MainFrame.NavigationService.Navigate(new CryptoPage(MainFrame));
        }
        private void CurrenciesPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new CurrenciesPage());
        }
        private void MaterialsPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MaterialsPage());
        }
        private void SharesPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SharesPage());
        }
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MainPage());
        }
    }
}
