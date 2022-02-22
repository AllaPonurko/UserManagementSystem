using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Data.Entities
{ 
   [Serializable]
        /// <summary>
        /// Сущность пользователя системы
        /// </summary>
        public class User
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }
            public List<Role> Roles { get; set; } = new List<Role>();
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
    

}
