using System.Windows.Controls;
using System.IO;
using System.Text;
using System.Threading;
using System;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for MainSettings.xaml
    /// </summary>
    public partial class MainSettings : Page
    {
        public MainSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StreamReader streamReader = new StreamReader("CheckOnBlack.txt");
            int result = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
            StreamWriter streamWriter = new StreamWriter("CheckOnBlack.txt");
            if (result == 0)
            {
                streamWriter.WriteLine(Convert.ToString(1));
                ButtonSwitch.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/DarkOn.png")));
            }
            else
            {
                streamWriter.WriteLine(Convert.ToString(0));
                ButtonSwitch.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/DarkOff.png")));
            }
            streamWriter.Close();
        }
    }
}
