using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace The_choice
{
    public class ShareGet
    {
        public static async Task<Share[]> LoadShares(HttpRequestMessage request)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Share[] result = JsonConvert.DeserializeObject<Share[]>(body);
                return result;
            }
        }
    }
}
