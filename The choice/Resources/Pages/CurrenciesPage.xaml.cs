using System.Windows.Controls;
using The_choice.Resources.Pages;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for CurrenciesPage.xaml
    /// </summary>
    public partial class CurrenciesPage : Page
    {
        private Frame mainFrame;
        public CurrenciesPage(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new CurrencyListVM();
            this.mainFrame = mainFrame;
            MainFrame.NavigationService.Navigate(new CurrencyInfo(mainFrame));
        }
    }
}
