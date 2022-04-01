using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDemoApp.ViewModels;
using Xamarin.Forms;

namespace APIDemoApp.Views
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new MainPageViewModel();
            this.BackgroundImageSource = "background_image.png";
        }

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {

        }
    }
}
