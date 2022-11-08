using System.Windows;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
            SettingsFrame.NavigationService.Navigate(new MainSettings());
            this.ResizeMode = ResizeMode.NoResize;
        }
        private void AboutUsBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingsFrame.NavigationService.Navigate(new AboutUs());
        }
        private void MainSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingsFrame.NavigationService.Navigate(new MainSettings());
        }
        private void TutorialBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingsFrame.NavigationService.Navigate(new Tutorial());
        }
    }
}
