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
    public class CryptoGet
    {
        public static async Task<Crypto> LoadCrypto(string url)
        {
            //"https://cryptingup.com/api/assets/ETH";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    CryptoResult Assets = JsonConvert.DeserializeObject<CryptoResult>(content);
                    return Assets.asset;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
