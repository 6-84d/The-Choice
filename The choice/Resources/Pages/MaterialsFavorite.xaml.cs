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
    /// Interaction logic for MaterialsFavorite.xaml
    /// </summary>
    public partial class MaterialsFavorite : Page
    {
        private Frame mainFrame;
        public MaterialsFavorite(Frame mainFrame, MetalsVM viewModel)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            DataContext = viewModel;
            this.Width = mainFrame.Width;
            this.Height = mainFrame.Height;
            metalsLB.Width = this.Width;
        }

        private void favoriteCB_Checked(object sender, RoutedEventArgs e)
        {
            Metal newFavorite = ((CheckBox)sender).DataContext as Metal;
            MetalsVM viewModel = (MetalsVM)DataContext;
            viewModel.favoriteMetals.Add(newFavorite);
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteMetals.txt", true);
            writer.WriteLine(newFavorite.name + ";");
            writer.Close();
        }

        private void favoriteCB_Unchecked(object sender, RoutedEventArgs e)
        {
            Metal newFavorite = ((CheckBox)sender).DataContext as Metal;
            MetalsVM viewModel = (MetalsVM)DataContext;
            viewModel.favoriteMetals.Remove(newFavorite);
            StreamReader reader = new StreamReader(@"../../../Resources/FavoriteMetals.txt");
            string temp = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(@"../../../Resources/FavoriteMetals.txt");
            writer.Write(temp.Replace(newFavorite.name + ";\r\n", ""));
            writer.Close();
        }
    }
}
