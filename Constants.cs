using BLOGSOCIALUDLA.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA
{
    public static class Constants
    {
        private const string DBFileName = "Datos.db";
        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite
            | SQLiteOpenFlags.Create
            | SQLiteOpenFlags.SharedCache;

   
        public static string BaseDatosPath
        {

            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);

            }

        }
    }
    
}
