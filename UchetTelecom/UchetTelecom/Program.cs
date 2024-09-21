using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetTelecom
{
    internal static class AppStatus
    {
        public static bool IsClose { get; set; }
    }
    internal static class DBStatus
    { 
        public static string DBConnectString { get; set; }
    }
    internal static class UserStatus
    {
        public static string Login { get; set; }
        public static string Grants { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppStatus.IsClose = false; 
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            while (AppStatus.IsClose != true)
            {
                Application.Run(new AuthForm());
                Application.Run(new MainForm());
            }
        }
    }
}
