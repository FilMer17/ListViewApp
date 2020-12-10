using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewApp.Model;
using ListViewApp.View;

namespace ListViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InfoAstroObject());
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
