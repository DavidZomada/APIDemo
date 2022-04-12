using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APIDemoApp.Views;
using APIDemoApp.Views.Componets;

namespace APIDemoApp
{
    public partial class App : Application
    {
        public App()
        {
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            InitializeComponent();
            //MainPage = new MainPageView();
            MainPage = new ArenaPageView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
