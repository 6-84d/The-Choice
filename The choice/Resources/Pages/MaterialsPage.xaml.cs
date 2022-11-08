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
            //DataContext = new MetalsListVM();
            this.mainFrame = mainFrame;
           //MainFrame.NavigationService.Navigate(new MaterialsInfo(mainFrame));
        }
    }
}
