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
using System.Windows.Shapes;

namespace The_choice
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ExtraWindow : Window
    {
        private Crypto crypto;
        public ExtraWindow(Crypto crypto)
        {
            InitializeComponent();
            this.crypto = crypto;
        }

        private void AddFavoriteBtn_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"UsersData/Favorites.txt", true);
            writer.WriteLine(crypto.asset_id, crypto.name, crypto.price);
        }
    }
}
