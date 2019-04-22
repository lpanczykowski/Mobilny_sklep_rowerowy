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
    public partial class Rej : ContentPage
    {
        public SQLiteConnection conn;
        public Customer customer;
        public Rej()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Customer>();

        }
        async void Dalej_button(object sender, EventArgs args)
        {


            if (rej_imie.Text != " " && rej_naz.Text != " " && rej_login.Text != " " && rej_password.Text != " ")
            {

                Customer customer = new Customer();
                customer.FirstName = rej_imie.Text;
                customer.LastName = rej_naz.Text;
                customer.Login = rej_login.Text;
                customer.Password = rej_password.Text;




                int x = 0;
                try
                {
                    x = conn.Insert(customer);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (x == 1)
                {
                    await DisplayAlert("Rejestracja", "Dziękujemy za zarejestrowanie się na serwisie", "OK");
                }
                else
                {
                    await DisplayAlert("Registration Failled!!!", "Please try again", "ERROR");
                }

                try
                {
                    await Navigation.PushAsync(new Log());


                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}