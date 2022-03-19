using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using APIDemoApp.Models;
using APIDemoApp.Utilities;
using Newtonsoft.Json;

namespace APIDemoApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Plant> _Plants { get; set; }
        public ObservableCollection<Plant> Plants
        {
            get => _Plants;
            set
            {
                _Plants = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            GetAllPlants();
        }

        public async void GetAllPlants()
        {
            var url = "https://serverdemo.azurewebsites.net/api/Plant";
            var service = new HttpHelper<Plant>();
            var plants = await service.GetRestServiceDataAsync(url);
            Plants = new ObservableCollection<Plant>((IEnumerable<Plant>)plants);
        }
    }
}
