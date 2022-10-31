using System.Windows.Controls;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for CurrenciesPage.xaml
    /// </summary>
    public partial class CurrenciesPage : Page
    {
        public CurrenciesPage()
        {
            InitializeComponent();
            DataContext = new CurrencyListVM();
        }
    }
}
