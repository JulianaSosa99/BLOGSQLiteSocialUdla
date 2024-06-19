using BLOGSOCIALUDLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Services
{
    public interface IAuthService
    {
        bool IsLoggedIn { get; }
        User CurrentUser { get; }
        void Login(User user);
        void Logout();
    }
}
