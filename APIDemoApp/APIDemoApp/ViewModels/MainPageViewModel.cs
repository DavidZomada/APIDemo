using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using APIDemoApp.Models;
using APIDemoApp.Utilities;
using Newtonsoft.Json;
using Xamarin.Forms;

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

        //TODO: Add visual element type as agument to made the cast the sender flexable
        public MainPageViewModel(VisualElement sender)
        {
            LoadPage(sender);
        }

        public async void LoadPage(VisualElement sender)
        {
            var task = Task.Run(() =>
            {
                GetAllPlants();
            });

            await task.ContinueWith(antecedent =>
            {
                (sender as StackLayout).FadeTo(1, 2000);
                (sender as StackLayout).ScaleTo(0.95, 2000);
            });
        }

        public async void GetAllPlants()
        {
            var client = new HttpHelper();
            Plants = await client.GetAllPlants("Plant");
        }
    }
}
