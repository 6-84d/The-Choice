using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    internal class FavoritesVM: INotifyPropertyChanged
    {
        public ObservableCollection<IAsset> assets { get; set; } // Favorite assets collection
        public FavoritesVM()
        {
            assets = new ObservableCollection<IAsset>(); // Initialize instance of the collection
            Load(); // Call method to fill new collection
        }
        private void Load()
        {
            // Load from file all favorites assets
            string favoritesStr = File.ReadAllText(@"UserData/Favorites.txt");
            string[] favorites = favoritesStr.Split(';', '\n');
            for (int i = 4; i < favorites.Length; i += 2)
            {
                IAsset asset = new Crypto();
                asset.name = favorites[i];
                asset.price = Convert.ToInt32(favorites[i + 1]);
                assets.Add(asset);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnProperyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }
    }
}
