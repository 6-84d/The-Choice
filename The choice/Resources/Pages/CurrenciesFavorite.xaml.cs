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
    /// Interaction logic for CurrenciesFavorite.xaml
    /// </summary>
    public partial class CurrenciesFavorite : Page
    {
        private Frame mainFrame;
        public CurrenciesFavorite(Frame mainFrame, CurrencyListVM dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
            this.mainFrame = mainFrame;
            this.Width = mainFrame.Width;
            this.Height = mainFrame.Height;
            currenciesLB.Width = this.Width;
        }
        private void favoriteCB_Checked(object sender, RoutedEventArgs e)
        {
            Currency newFavorite = ((CheckBox)sender).DataContext as Currency;
            CurrencyListVM viewModel = (CurrencyListVM)DataContext;
            viewModel.favoriteCurrencies.Add(newFavorite);
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteCurrencies.txt", true);
            writer.WriteLine(newFavorite.name + ";");
            writer.Close();
        }

        private void favoriteCB_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency newFavorite = ((CheckBox)sender).DataContext as Currency;
            CurrencyListVM viewModel = (CurrencyListVM)DataContext;
            viewModel.favoriteCurrencies.Remove(newFavorite);
            StreamReader reader = new StreamReader(@"../../../Resources/FavoriteCurrencies.txt");
            string temp = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteCurrencies.txt");
            writer.Write(temp.Replace(newFavorite.name + ";\r\n", ""));
            writer.Close();
        }
    }
}
