using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace The_choice.Resources.Pages
{
    /// <summary>
    /// Interaction logic for CryptoInfo.xaml
    /// </summary>
    public partial class CryptoInfo : Page
    {
        private Frame mainFrame;

        public CryptoInfo(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            DataContext = new AppVM();
            this.Width = mainFrame.Width;
            this.Height = mainFrame.Height;
            cryptoesLB.Width = this.Width;
        }
        private void cryptoesLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.mainFrame.NavigationService.Navigate(new ExtraInfoPage(((AppVM)DataContext).SelectedCrypto));
        }
    }
}
