using BLOGSOCIALUDLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Services
{
    public class AuthService : IAuthService
    {
        private User _currentUser;
        public bool IsLoggedIn => _currentUser!=null;

        public User CurrentUser => _currentUser;

        public void Login(User user)
        {
            _currentUser = user;
                }

        public void Logout()
        {
            _currentUser = null;
        }
    }
}
