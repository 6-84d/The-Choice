using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace The_choice
{
    public class MetalGet
    {

        public static async Task<Dictionary<string, double>> LoadAllMetals()
        {
            string[] metals = { "spot", "spot/commodities" };
            return await Loadmetals(metals);
        }

        static async Task<Dictionary<string, double>> Loadmetals(string[] types)
        {
            Dictionary<string, double> metals = new Dictionary<string, double>();
            foreach (var type in types)
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://api.metals.live/v1/" + type))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        content = Regex.Replace(content, "[\\[\\]{}\\\"]", ""); // []{}"
                        string[] pairs = content.Split(",");
                        foreach (string pair in pairs)
                        {
                            string[] temp = pair.Split(":");
                            if (temp[0] == "timestamp") continue;
                            metals.Add(temp[0], Convert.ToDouble(temp[1].Replace(".", ",")));
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            return metals;
        }
    }
}
