using System.IO;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace The_choice
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(@"..\..\..\Resources\CheckOnBlack.txt");
            int result = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
            if (result == 0)
            {
                LeftStringButton.Source = new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/LeftStringWhite.png"));
                RightStringButton.Source = new BitmapImage(new Uri(@"pack://application:,,,/" + "Resources/Pictures/RigthStringWhite.png"));
            }
        }
    }
}
