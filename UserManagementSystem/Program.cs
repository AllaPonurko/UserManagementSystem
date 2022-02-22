using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    internal static class Program
    {
        public static NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        public static Data.ApplicationDbContext _db = Data.ApplicationDbContext.getInstance();
        public static Helpers.Auth.AuthStore _auth = Helpers.Auth.AuthStore.getInstance();
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _db.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
