using System.Windows.Controls;
using The_choice.Resources.Pages;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        private Frame mainFrame;

        public MaterialsPage(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new MetalsVM();
            this.mainFrame = mainFrame;
            MainFrame.NavigationService.Navigate(new MaterialsInfo(mainFrame, DataContext as MetalsVM));
        }
        private void favModeCB_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MaterialsFavorite(mainFrame, DataContext as MetalsVM));
        }
        private void favModeCB_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MaterialsInfo(mainFrame, DataContext as MetalsVM));
        }
    }
}
