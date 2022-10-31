﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace The_choice
{ 
    public class AppVM : INotifyPropertyChanged
    {
        public ObservableCollection<Crypto> cryptos { get; set; }
        private Crypto selectedCrypto;
        public Crypto SelectedCrypto
        {
            get { return selectedCrypto; }
            set
            {
                selectedCrypto = value;
                OnPropertyChanged("SelectedCrypto");
            }
        }
        public AppVM()
        {
            cryptos = new ObservableCollection<Crypto>
            {
            };
            Add();
        }
        public async void Add()
        {
            var info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets");
            for (int i = 0; i < info.assets.Count; i++)
            {
                info.assets[i].number = i + 1;
                if (info.assets[i].name == "")
                    info.assets[i].name = info.assets[i].asset_id;
                cryptos.Add(info.assets[i]);
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
