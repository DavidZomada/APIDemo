using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using APIDemoApp.Models;
using Newtonsoft.Json;

namespace APIDemoApp.Utilities
{
    public class HttpHelper<T>
    {
        public HttpHelper()
        {
        }

        public async Task<ObservableCollection<Plant>> GetRestServiceDataAsync(string serviceAdress)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(serviceAdress);
            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ObservableCollection<Plant>>(jsonResult);
            return result;
        }
    }
}
