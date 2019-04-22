using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace ProjektApp
{
   
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {


        public string Login { get; set; }
        public SQLiteConnection conn;
        public MainPage(String data)
        {

            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Login = data;
            BindingContext = this;
           
           

        }
        
        async void Sklep_button(object sender,EventArgs args)
        {
            await Navigation.PushAsync(new Sklep());
        }

        async void Serwis_button(object sender,EventArgs args)
        {
            await Navigation.PushAsync(new Serwis());
        }
        async void Pomoc_button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Pomoc());
        }
        public void DisplayDetails()
        {

            
            
        }
    }
}
