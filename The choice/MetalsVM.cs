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
    public class MetalsVM: INotifyPropertyChanged
    {
        public ObservableCollection<Metal> metals { get; set; }
        public MetalsVM()
        {
            metals = new ObservableCollection<Metal>();
            Load();
        }
        public async void Load()
        {
            Dictionary<string, double> result = await MetalGet.LoadSpot();
            foreach (var metal in result)
                metals.Add(new Metal(metal.Key, metal.Value));
            result.Clear();
            result = await MetalGet.LoadCommodities();
            foreach (var metal in result)
                metals.Add(new Metal(metal.Key, metal.Value));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
