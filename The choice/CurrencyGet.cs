using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace The_choice
{
    internal class CurrencyGet
    {
        public static async Task<CurrencyResult> LoadRates(string url)
        {
            //"https://cryptingup.com/api/assets/ETH";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    CurrencyResult Assets = JsonConvert.DeserializeObject<CurrencyResult>(content);
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
