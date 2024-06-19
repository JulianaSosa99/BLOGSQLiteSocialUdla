using BLOGSOCIALUDLA.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Data
{
    public class UserDataa
    {
        public SQLiteAsyncConnection _conexionDB;

        public UserDataa(SQLiteAsyncConnection conexionDB)
        {
            _conexionDB = conexionDB;   
        }

        public Task<List<User>> ListaUsuarios()
        {
            var lista = _conexionDB.Table<User>().ToListAsync();
            return lista;
        }

        public Task<User> ObtenerUser(string username, string password)
        {
            var user = _conexionDB.Table<User>()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefaultAsync();
            return user;
        }

        public Task<User> ObtenerUser(Guid id)
        {
            var user= _conexionDB.Table<User>()
                .Where(x=>x.Id== id)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task <int> GuardarUser(User user)
        {
            var userGuardado = await ObtenerUser(user.Id);
            if (userGuardado != null)
            {
                return await _conexionDB.InsertAsync(user);

            }
            else
            {
                return await _conexionDB.UpdateAsync(user);
            }
        }

            public async Task<int> BorrarUser(Guid id)
            {
                return await _conexionDB.DeleteAsync(id);
            }

            //public static User CurrentUser { get; set; }


    }
}
