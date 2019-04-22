using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;
namespace ProjektApp
{
    public class Customer
    {
       [AutoIncrement,PrimaryKey]
        public int id
        { get; set; }

        public string LastName
        { get; set; }

        public string FirstName
        { get; set; }

        public string Adress
        { get; set; }
        public string Login
        { get; set; }
        public string Password
        { get; set; }
        public DateTime Dob
        { get; set; }
    }
}
