using System;
using System.Collections.Generic;
using System.IO;
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

        private void favoriteBtn_Click(object sender, RoutedEventArgs e)
        {
            Crypto newFavorite = ((Button)sender).DataContext as Crypto;
            AppVM viewModel = (AppVM)DataContext;
            StreamWriter writer = null;
            if (newFavorite.isFavorite)
            {
                viewModel.favoriteCryptos.Remove(newFavorite);
                StreamReader reader = new StreamReader(@"../../../Resources/FavoriteCryptos.txt");
                string temp = reader.ReadToEnd();
                reader.Close();
                writer = new StreamWriter(@"../../../Resources/FavoriteCryptos.txt");
                writer.Write(temp.Replace(newFavorite.asset_id + ";\r\n", ""));
                writer.Close();
            }
            else
            {
                viewModel.favoriteCryptos.Add(newFavorite);
                writer = new StreamWriter(@"../../../Resources/FavoriteCryptos.txt", true);
                writer.WriteLine(newFavorite.asset_id + ";");
                writer.Close();
            }
            newFavorite.isFavorite = !newFavorite.isFavorite;
        }

        private void favoriteCB_Checked(object sender, RoutedEventArgs e)
        {
            Crypto newFavorite = ((CheckBox)sender).DataContext as Crypto;
            AppVM viewModel = (AppVM)DataContext;
            viewModel.favoriteCryptos.Add(newFavorite);
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteCryptos.txt", true);
            writer.WriteLine(newFavorite.asset_id + ";");
            writer.Close();
        }

        private void favoriteCB_Unchecked(object sender, RoutedEventArgs e)
        {
            Crypto newFavorite = ((CheckBox)sender).DataContext as Crypto;
            AppVM viewModel = (AppVM)DataContext;
            viewModel.favoriteCryptos.Remove(newFavorite);
            StreamReader reader = new StreamReader(@"../../../Resources/FavoriteCryptos.txt");
            string temp = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteCryptos.txt");
            writer.Write(temp.Replace(newFavorite.asset_id + ";\r\n", ""));
            writer.Close();
        }
    }
}

