using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    public class Metal: IAsset
    {
        public string? name { get; set; }
        public string? code { get; set; }
        public double price { get; set; }
        public Metal(string? name, string? code, double price)
        {
            this.name = name;
            this.code = code;
            this.price = price;
        }
    }
}
