using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    public class MetalsSymbolsResult
    {
        public Dictionary<string, string> Symbols { get; set; }
        public MetalsSymbolsResult()
        {
            Symbols = new Dictionary<string, string>();
            StreamReader reader = new StreamReader("../../../Resources/MetalsSymbols.txt");
            while (!reader.EndOfStream)
            {
                string metalStr = reader.ReadLine();
                string[] metalArr = metalStr.Split(";");
                Symbols[metalArr[0]] = metalArr[1];
            }
            reader.Close();
        }
    }
}
