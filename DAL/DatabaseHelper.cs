using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = "Server=localhost;Port=3306;Database=techstore;Uid=root;Pwd=049206;Charset=utf8mb4;";

        /// <summary>
        /// Hàm trả về một kết nối mới tới cơ sở dữ liệu
        /// </summary>
        public static IDbConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}