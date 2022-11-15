using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Diagnostics.Metrics;

namespace The_choice
{
    public class MetalsVM: INotifyPropertyChanged
    {
        public ObservableCollection<Metal> metals { get; set; }
        public ObservableCollection<Metal> favoriteMetals { get; set; }
        public MetalsVM()
        {
            metals = new ObservableCollection<Metal>();
            favoriteMetals = new ObservableCollection<Metal>();
            Load();
        }
        public async void Load()
        {
            Dictionary<string, double> result = await MetalGet.LoadAllMetals();
            StreamReader reader = new StreamReader(@"..\..\..\Resources\FavoriteMetals.txt");
            string[] favoritesIDs = reader.ReadToEnd().Split(";\r\n");
            reader.Close();
            foreach (var metal in result)
            {
                bool isFavorite = false;
                if (favoritesIDs.Contains(metal.Key))
                    isFavorite = true;
                metals.Add(new Metal(metal.Key, metal.Value, isFavorite));
                
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
