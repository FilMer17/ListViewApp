using ListViewApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoAstroObject : ContentPage
    {
        public InfoAstroObject()
        {
            InitializeComponent();
            AstroObject aoModel = new AstroObject();
            BindingContext = aoModel;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }

            Page p = new AddAstroObject(((((ListView)sender).SelectedItem) as Model.AstroObject), (BindingContext as StoredAstroObjects).AllAstroObjects);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            if ((sender as ListView) != null)
            {
                (sender as ListView).SelectedItem = null;
            }
        }
    }
}