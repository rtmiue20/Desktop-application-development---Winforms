using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class UsersDAL
    {
        /// <summary>
        /// Lấy thông tin người dùng theo Username (phục vụ đăng nhập)
        /// </summary>
        public UsersDTO GetByUsername(string username)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND IsActive = 1";
                
                // Dapper sẽ tự động map các cột của bảng Users vào các thuộc tính của UsersDTO
                return db.QueryFirstOrDefault<UsersDTO>(query, new { Username = username });
            }
        }
    }
}