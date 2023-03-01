using csharpCashier.Utils;
using Microsoft.Data.Sqlite;

namespace csharpCashier
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SqliteConnection conn = Db.CreateConnection();
            Db.CreateBasicTables(conn);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            

        }
    }
}