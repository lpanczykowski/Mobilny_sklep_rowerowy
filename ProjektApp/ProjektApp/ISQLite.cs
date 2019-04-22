using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProjektApp
{
   
        public interface ISQLite
        {
            SQLiteConnection GetConnection();
        }
    
}
