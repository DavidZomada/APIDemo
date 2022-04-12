using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using APIDemoApp.Models;
using Newtonsoft.Json;

namespace APIDemoApp.Utilities
{
    public class HttpHelper
    {
        public string Root = "https://serverdemo.azurewebsites.net/api/";

        public HttpHelper()
        {
        }

        public async Task<ObservableCollection<Plant>> GetAllPlants(string Path)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Root + Path);
            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ObservableCollection<Plant>>(jsonResult);
            return result;
        }

        public async Task<Plant> PostNewPlant(string Path, Plant NewPlant)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Root + Path);
            var json = JsonConvert.SerializeObject(NewPlant);
            var response = await client.PostAsync(client.BaseAddress, new StringContent(json, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Plant>(jsonResult);
            return result;
        }
    }
}
