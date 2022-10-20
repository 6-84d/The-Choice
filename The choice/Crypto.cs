using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfApp21;

namespace WpfApp21
{
    public class Crypto
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double change_1h { get; set; }
        public double change_24h { get; set; }
        public double change_7d { get; set; }
    }
}