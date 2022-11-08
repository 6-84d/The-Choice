using System.IO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

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

        private void StackPanel_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StreamReader streamReader = new StreamReader("CheckOnBlack.txt");
            int result = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
            if (result == 0)
            {
                OurStack.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/OptionsWhite.png")));
            }
            else
            {
                OurStack.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/BackgroundOptions.png")));
            }
        }
    }
}
