using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

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
            StreamWriter streamWriter = new StreamWriter("CheckOnBlack.txt");
            streamWriter.Write(Convert.ToString(0));
            streamWriter.Close();
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

        private void MyGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StreamReader streamReader = new StreamReader("CheckOnBlack.txt");
            int result = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
            if (result == 0)
            {
                SharesPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                CryptoPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                MaterialsPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                CurrenciesPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/BackgroundWhite.png")));
                SecondGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/LinesWhite.png")));

            }
            else
            {
                SharesPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                CryptoPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                MaterialsPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                CurrenciesPageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                MyGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Background.jpg")));
                SecondGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/Lines.png")));
            }
        }
    }
}
