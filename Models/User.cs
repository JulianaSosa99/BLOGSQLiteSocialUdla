using Microsoft.EntityFrameworkCore;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Models
{
    public class User
    {
     //   [SQLite.PrimaryKey,AutoIncrement]
        public Guid Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
       
        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
