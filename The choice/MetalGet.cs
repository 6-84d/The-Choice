using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace The_choice
{
    public class MetalGet
    {
        public static async Task<MetalRatesResult> LoadRates(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    MetalRatesResult Assets = JsonConvert.DeserializeObject<MetalRatesResult>(content);
                    return Assets;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public static async Task<MetalsSymbolsResult> LoadSymbols(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    MetalsSymbolsResult Assets = JsonConvert.DeserializeObject<MetalsSymbolsResult>(content);
                    MessageBox.Show(content);
                    return Assets;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
