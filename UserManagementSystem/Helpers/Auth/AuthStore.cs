using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Data.Entities;

namespace UserManagementSystem.Helpers.Auth
{
    
        public class AuthStore
        {
            public bool isAdmin()
            {
                if (CurrentUser.Role.Name == "Admin") return true;
                return CurrentUser.Roles.Exists(r => r.Name == "Admin");
            }

            public User CurrentUser { get; set; } = null;

            // Метка - вошел ли пользователь в систему
            public bool isLogin { get; set; } = false;

            private AuthStore() { }

            private static AuthStore _instance;

            public static AuthStore getInstance()
            {
                if (_instance == null) _instance = new AuthStore();
                return _instance;
            }
        }
    
}

