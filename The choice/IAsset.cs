using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    internal interface IAsset
    {
        double price { get; set; }
        string name { get; set; }
    }
}
