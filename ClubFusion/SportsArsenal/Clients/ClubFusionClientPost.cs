using Newtonsoft.Json;
using SportsArsenal.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SportsArsenal.Clients
{
    public class ClubFusionClientPost
    {
        public static async Task<T> Post<T>(string actionUrl, object data)
        {
            T result = default(T);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.baseUrl);
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(actionUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(responseContent);
                }
            }
            return result;
        }
    }
}