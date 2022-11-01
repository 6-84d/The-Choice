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

namespace The_choice
{
    public class MetalsListVM
    {
        public ObservableCollection<Metal> metals { get; set; }
        public MetalsListVM()
        {
            metals = new ObservableCollection<Metal>();
            Load();
        }
        public async void Load()
        {
            MetalRatesResult resultRates = await MetalGet.LoadRates("https://metals-api.com/api/latest?access_key=ezeyz0in66gq56d33dnt615scpaqwkjv9s07zi8068ik1pzywb59xojhhkyu");
            MetalsSymbolsResult resultSymbols = new MetalsSymbolsResult();
            //await MetalGet.LoadSymbols("https://metals-api.com/api/symbols?access_key=ezeyz0in66gq56d33dnt615scpaqwkjv9s07zi8068ik1pzywb59xojhhkyu");
            foreach (var metal in resultRates.rates)
            {
                string? name = null;
                if (resultSymbols.Symbols.TryGetValue(metal.Key, out name))
                {
                    metals.Add(new Metal(name, metal.Key, metal.Value));
                }
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
