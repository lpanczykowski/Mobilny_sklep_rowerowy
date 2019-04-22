using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
namespace ProjektApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Log : ContentPage
    {



        public SQLiteConnection conn;
        public Customer customer;
        int x = 0;
        public Log()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Customer>();





        }



        async void Gosc_button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage("użytkowniku"));
        }
        async void Log_button(object sender, EventArgs args)
        {


            var query = conn.Table<Customer>();
            try
            {




                foreach (var stock in query)

                {
                    if (entry_login.Text == stock.Login && entry_pass.Text == stock.Password)
                    {
                        x = 0;
                        await Navigation.PushAsync(new MainPage(entry_login.Text));
                    }
                    else x++;


                }
                if (x != 0)
                {
                    await DisplayAlert("Bład", "Użytkownik nieistnieje", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bład", "Niewłasciwe Dane", "Ok");
                throw ex;

            }

        }
        async void Rej_button(object sender, EventArgs args)
        {
            await  Navigation.PushAsync(new Rej());
        }

        







            }




        }



