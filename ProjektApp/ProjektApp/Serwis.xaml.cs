using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Serwis : ContentPage
    {
        public SQLiteConnection conn;
        public Service service;

        public Serwis()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Service>();


        }

        async void Dalej_button(object sender, EventArgs args)
        {




           

            Service service = new Service
            {
                FirstName = ser_imie.Text,
                LastName = ser_naz.Text,
                whattodo = Convert.ToString(picker.SelectedItem),
                Day = DatePicker.Date
            };



            int x = 0;
            try
            {
                x = conn.Insert(service);
                
              
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            if (x == 1)
            {
                await DisplayAlert("Serwis", "Do zobaczenia: Dzień: " + Convert.ToString(DatePicker.Date.Day) + "Miesiąc:" +Convert.ToString(DatePicker.Date.Month), "OK");
                await Navigation.PushAsync(new Serwis());
            }




        }
         








        }
    }
