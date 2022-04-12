using System;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using APIDemoApp.Models;
using APIDemoApp.Utilities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace APIDemoApp.ViewModels
{
    public class AddFormViewModel : BaseViewModel
    {
        private Plant _NewPlant { get; set; }
        public Plant NewPlant
        {
            get => _NewPlant;
            set
            {
                _NewPlant = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddPlantCommand { get; }

        public AddFormViewModel()
        {
            NewPlant = new Plant(5, "Cocotera", "Palnta del coco", "http://...");
            AddPlantCommand = new Command(PostNewPlant);
        }

        private async void PostNewPlant()
        {
            var client = new HttpHelper();
            await client.PostNewPlant("Plant", NewPlant);
        }


    }
}
