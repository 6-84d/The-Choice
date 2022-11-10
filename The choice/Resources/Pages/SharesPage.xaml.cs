using System.Windows.Controls;
using The_choice.Resources.Pages;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for SharesPage.xaml
    /// </summary>
    public partial class SharesPage : Page
    {
        private Frame mainFrame;
        public SharesPage(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new MetalsVM();
            this.mainFrame = mainFrame;
            MainFrame.NavigationService.Navigate(new SharesInfo(mainFrame));
        }
    }
}
