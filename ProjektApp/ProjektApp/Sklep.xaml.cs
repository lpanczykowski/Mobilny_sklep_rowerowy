using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sklep : ContentPage
    {
        public Sklep()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}