using System.Windows.Controls;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for CryptoPage.xaml
    /// </summary>
    public partial class CryptoPage : Page
    {
        public CryptoPage()
        {
            InitializeComponent();
            DataContext = new AppVM();
        }
    }
}
