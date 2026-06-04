using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL;

public class UsersDAL
{
    /// <summary>Lấy user theo Username — dùng cho đăng nhập</summary>
    public UsersDTO? GetByUsername(string username)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        return db.QueryFirstOrDefault<UsersDTO>(
            "SELECT * FROM Users WHERE Username = @username AND IsActive = 1",
            new { username });
    }

    public UsersDTO? GetByID(int userID)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        return db.QueryFirstOrDefault<UsersDTO>(
            "SELECT * FROM Users WHERE UserID = @userID",
            new { userID });
    }

    public List<UsersDTO> GetAll()
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        return db.Query<UsersDTO>("SELECT * FROM Users").AsList();
    }

    public int Insert(UsersDTO user)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        string query = @"INSERT INTO Users (Username, Password, FullName, Phone, RoleID, IsActive, CreatedAt)
                         VALUES (@Username, @Password, @FullName, @Phone, @RoleID, @IsActive, NOW());
                         SELECT LAST_INSERT_ID();";
        return db.ExecuteScalar<int>(query, user);
    }

    public bool Update(UsersDTO user)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        string query = @"UPDATE Users SET FullName = @FullName, Phone = @Phone,
                         RoleID = @RoleID, IsActive = @IsActive
                         WHERE UserID = @UserID";
        return db.Execute(query, user) > 0;
    }

    public bool ChangePassword(int userID, string newHashedPassword)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        return db.Execute(
            "UPDATE Users SET Password = @newHashedPassword WHERE UserID = @userID",
            new { newHashedPassword, userID }) > 0;
    }

    /// <summary>Vô hiệu hóa thay vì xóa thật</summary>
    public bool Deactivate(int userID)
    {
        using IDbConnection db = DatabaseHelper.GetConnection();
        return db.Execute(
            "UPDATE Users SET IsActive = 0 WHERE UserID = @userID",
            new { userID }) > 0;
    }
}