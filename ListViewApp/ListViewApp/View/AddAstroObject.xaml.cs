using ListViewApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAstroObject : ContentPage
    {
        public ObservableCollection<AstroObject> objectColl;

        public AddAstroObject()
        {
            InitializeComponent();
        }

        public AddAstroObject(AstroObject aob, ObservableCollection<AstroObject> coll)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(aob);
            BindingContext = pvm;
            objectColl = coll;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            objectColl.Add((BindingContext as PageViewModel).SetAstroObject());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
    public class PageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(AstroObject aObject)
        {
            Name = aObject.Name;
            Type = aObject.Type;
            Description = aObject.Description;
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        string _Type;
        public string Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }

        public AstroObject SetAstroObject()
        {
            AstroObject ao = new AstroObject
            {
                Name = this.Name,
                Type = this.Type,
                Description = this.Description
            };

            return ao;
        }
    }
}