using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using SQLitePCL;
using System.IO;
using Xamarin.Forms;
using ProjektApp.Droid;

[assembly: Dependency(typeof(SQliteDroid))]
namespace ProjektApp.Droid
{
    public class SQliteDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbase = "Customers.db";
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbpath, dbase);
            var connection = new SQLiteConnection(path);
            return connection;

        }
    }
}