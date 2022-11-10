using System.Windows.Controls;
using The_choice.Resources.Pages;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for CryptoPage.xaml
    /// </summary>
    public partial class CryptoPage : Page
    {
        private Frame mainFrame;
        public CryptoPage(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new AppVM();
            this.mainFrame = mainFrame;
            MainFrame.NavigationService.Navigate(new CryptoInfo(mainFrame, DataContext as AppVM));
        }

        private void favModeCB_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new CryptoFavorite(mainFrame, DataContext as AppVM));
        }

        private void favModeCB_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new CryptoInfo(mainFrame, DataContext as AppVM));
        }
    }
}
