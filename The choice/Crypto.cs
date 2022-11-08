using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace The_choice
{
    public class Crypto: IAsset
    {
        public int number { get; set; }
        public string asset_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double change_1h { get; set; }
        public string color_change_1h { get; set; }
        public double change_24h { get; set; }
        public string color_change_24h { get; set; }
        public double change_7d { get; set; }
        public string color_change_7d { get; set; }
    }
}