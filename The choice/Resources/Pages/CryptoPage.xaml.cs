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
        }

        private void cryptoesLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            this.mainFrame.NavigationService.Navigate(new ExtraInfoPage(((AppVM)DataContext).SelectedCrypto));
        }
    }
}
