using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpCashier.Repositories
{
    internal class Receipts
    {
        public static void CreateReceipt()
        {
            SqliteConnection conn = Utils.Db.CreateConnection();
            SqliteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

        }
    }
}
