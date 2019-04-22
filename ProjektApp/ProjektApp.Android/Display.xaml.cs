
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using ProjektApp;

namespace SqliteReg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Display : ContentPage
    {
        public SQLiteConnection conn;
        public Registration regmodel;
        public Display()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Registration>();
            DisplayDetails();

        }

        public void DisplayDetails()
        {

            var details = (from x in conn.Table<Registration>() select x).ToList();
            myListView.ItemsSource = details;
        }


    }
}