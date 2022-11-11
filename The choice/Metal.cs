using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    public class Metal
    {
        public string? name { get; set; }
        public double price { get; set; }
        public bool isFavorite { get; set; }
        public Metal(string? name, double price, bool isFavorite)
        {
            this.name = name;
            this.price = price;
            this.isFavorite = isFavorite;
        }
    }
}
