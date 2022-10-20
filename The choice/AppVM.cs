using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace The_choice
{ 
    public class AppVM : INotifyPropertyChanged
    {

        public ObservableCollection<Crypto> cryptos { get; set; }

        public AppVM()
        {
            cryptos = new ObservableCollection<Crypto>
            {
            };
            Add();
        }
        public async void Add()
        {
            Crypto.number = 0;
            var info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/BTC");
            cryptos.Add(info);
            await Task.Delay(100);
            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/ETH");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/USDT");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/USDC");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/BNB");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/XRP");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/BUSD");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/ADA");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/SOL");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/DOGE");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/MATIC");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/DOT");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/DAI");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/TRX");
            cryptos.Add(info);
            await Task.Delay(100);

            info = await CryptoGet.LoadCrypto("https://cryptingup.com/api/assets/SHIB");
            cryptos.Add(info);
            await Task.Delay(100);

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
