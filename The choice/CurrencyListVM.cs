using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace The_choice
{
    internal class CurrencyListVM: INotifyPropertyChanged
    {
        public ObservableCollection<Currency> currencies { get; set; }
        public CurrencyListVM()
        {
            currencies = new ObservableCollection<Currency>();
            Load();
        }
        public async void Load()
        {
            CurrencyResult result = await CurrencyGet.LoadRates("https://openexchangerates.org/api/latest.json?app_id=b43edbb38ba14eea9766294e65657b5a");
            foreach (var rate in result.rates)
                currencies.Add(new Currency(rate.Key, rate.Value));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
