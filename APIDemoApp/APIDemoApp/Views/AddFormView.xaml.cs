using System;
using System.Collections.Generic;
using APIDemoApp.Models;
using APIDemoApp.ViewModels;
using Xamarin.Forms;

namespace APIDemoApp.Views
{
    public partial class AddFormView : ContentPage
    {
        public AddFormView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new AddFormViewModel();
        }
    }
}
