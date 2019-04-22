using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProjektApp
{
    public class Service
    {
        [AutoIncrement, PrimaryKey]
        public int id
        { get; set; }

        public string LastName
        { get; set; }

        public string FirstName
        { get; set; }

        public string whattodo
        { get; set; }
        public DateTime Day
          { get; set; }

}
}
