    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using UserManagementSystem.Data.Entities;
using UserManagementSystem.Views;

namespace UserManagementSystem.Data
{
    
        /// <summary>
        /// Хранилище данных
        /// </summary>
        class ApplicationDbContext
        {
            public List<User> Users { get; set; } = new List<User>();
            public List<Role> Roles { get; set; } = new List<Role>();


            // Обработка событий для моей системы управления
            public event Action<string> eventSuccess;
            public event Action<string, Exception> eventError;


            /// <summary>
            /// Сохранить данные в базу
            /// </summary>
            public void Save()
            {
                try
                {
                    XmlSerializer formatterUser = new XmlSerializer(typeof(List<User>));

                    using (FileStream fs = new FileStream(Config.DbFileUsers, FileMode.OpenOrCreate))
                    {
                        formatterUser.Serialize(fs, Users);
                    }


                    XmlSerializer formatterRole = new XmlSerializer(typeof(List<Role>));

                    using (FileStream fs = new FileStream(Config.DbFileRoles, FileMode.OpenOrCreate))
                    {
                        formatterRole.Serialize(fs, Roles);
                    }

                    eventSuccess?.Invoke(" Save complite");
                }
                catch (Exception ex)
                {
                    eventError?.Invoke("On Save", ex);
                }

            }

            public void Load()
            {
                try
                {
                    // Если файла нет
                    if (!File.Exists(Config.DbFileUsers) || !File.Exists(Config.DbFileRoles))
                    {
                        eventError?.Invoke("File Not found - load demo data", null);
                        this.Seed();
                        return;
                    }

                    XmlSerializer formatterUser = new XmlSerializer(typeof(List<User>));

                    using (FileStream fs = new FileStream(Config.DbFileUsers, FileMode.OpenOrCreate))
                    {
                        Users = (List<User>)formatterUser.Deserialize(fs);
                    }


                    XmlSerializer formatterRole = new XmlSerializer(typeof(List<Role>));

                    using (FileStream fs = new FileStream(Config.DbFileRoles, FileMode.OpenOrCreate))
                    {
                        Roles = (List<Role>)formatterUser.Deserialize(fs);
                    }

                    eventSuccess?.Invoke(" Load complite");

                }
                catch (Exception ex)
                {
                    eventError?.Invoke("On Load", ex);
                }
            }

            public void Seed()
            {
                Role roleAdmin = new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                Roles.Add(roleAdmin);

                Role roleGuest = new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Guest",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                Roles.Add(roleGuest);

                User admin = new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Email = "admin@admin.com",
                    Password = "password",
                    Role = roleAdmin,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                Users.Add(admin);

                User guest = new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Guest",
                    Email = "guest@guest.com",
                    Password = "password",
                    Role = roleGuest,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                Users.Add(guest);

                eventSuccess(" Seed created");
            }


            private ApplicationDbContext()
            {
                eventError += (string Msg, Exception err) =>
                {
                    if (err != null)
                        Program.Log.Error(err.Message);
                    else
                        Program.Log.Error(Msg);

                };

                eventSuccess += (string Msg) =>
                {
                    Program.Log.Trace(Msg);
                };
            }
            private static ApplicationDbContext _instance;
            public static ApplicationDbContext getInstance()
            {
                if (_instance == null) _instance = new ApplicationDbContext();
                return _instance;
            }
        }
    
}

