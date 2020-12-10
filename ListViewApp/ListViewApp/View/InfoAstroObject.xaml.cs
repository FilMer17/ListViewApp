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
            StoredAstroObjects aoModel = new StoredAstroObjects();
            BindingContext = aoModel;
        }

        async void AstroObjectListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }

            Page p = new AddAstroObject(((ListView)sender).SelectedItem as AstroObject, (BindingContext as StoredAstroObjects).AllAstroObjects);
            await Application.Current.MainPage.Navigation.PushAsync(p);

            if ((sender as ListView) != null)
            {
                (sender as ListView).SelectedItem = null;
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Page p = new AddAstroObject(new AstroObject(), (BindingContext as StoredAstroObjects).AllAstroObjects);
            Application.Current.MainPage.Navigation.PushAsync(p);
        }
    }
}