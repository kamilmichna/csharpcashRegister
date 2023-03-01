using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpCashier.Utils
{

    internal class Db
    {
        public static SqliteConnection CreateConnection()
        {
            SqliteConnection _connection = new SqliteConnection("Data Source=hello.db");
            try
            {
                _connection.Open();
            } catch
            {
                throw new Exception("Db not working");
            }
            return _connection;
        }

        public static void CreateBasicTables(SqliteConnection conn)
        {
            SqliteCommand sqlite_cmd;
            string CreateProductsTable = "CREATE TABLE IF NOT EXISTS Products (Col1 VARCHAR(20), Col2 INT)";
            string CreateReceiptsTable = "CREATE TABLE IF NOT EXISTS Receipts (Col1 VARCHAR(20), Col2 INT)";
             sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CreateProductsTable;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = CreateReceiptsTable;
                sqlite_cmd.ExecuteNonQuery();
        }

    }
}
