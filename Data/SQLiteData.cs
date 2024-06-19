using BLOGSOCIALUDLA.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexionDB;
         public UserDataa UserDataTable { get; set; }    

        public SQLiteData( string path)
        {
            _conexionDB = new SQLiteAsyncConnection(path);
            _conexionDB.CreateTableAsync<User>().Wait();
            
            UserDataTable = new UserDataa(_conexionDB);



        }



    }
}
