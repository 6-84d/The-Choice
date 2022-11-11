using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace The_choice
{
    public class CurrencyListVM: INotifyPropertyChanged
    {
        public ObservableCollection<Currency> currencies { get; set; }
        public ObservableCollection<Currency> favoriteCurrencies { get; set; }
        public CurrencyListVM()
        {
            currencies = new ObservableCollection<Currency>();
            favoriteCurrencies = new ObservableCollection<Currency>();
            Load();
        }
        public async void Load()
        {
            int number = 1;
            CurrencyResult result = await CurrencyGet.LoadRates("https://openexchangerates.org/api/latest.json?app_id=b43edbb38ba14eea9766294e65657b5a");
            StreamReader reader = new StreamReader(@"..\..\..\Resources\FavoriteCurrencies.txt");
            string[] favoritesIDs = reader.ReadToEnd().Split(";\r\n");
            foreach (var rate in result.rates)
            {
                bool isFavorite = false;
                if (favoritesIDs.Contains(rate.Key))
                    isFavorite = true;
                currencies.Add(new Currency(rate.Key, rate.Value, number, isFavorite));
                number++;
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
