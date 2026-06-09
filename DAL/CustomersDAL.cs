using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class CustomersDAL
    {
        public CustomersDTO? GetByPhone(string phone)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string sql = @"
                SELECT CustomerID,
                       Phone,
                       FullName,
                       Address,
                       Email,
                       CustomerType,
                       COALESCE(TotalPoints, 0) AS TotalPoints,
                       CreatedAt
                FROM Customers
                WHERE Phone = @phone
                LIMIT 1;";
            return db.QueryFirstOrDefault<CustomersDTO>(sql, new { phone });
        }

        public List<CustomersDTO> GetAll()
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string sql = @"
                SELECT CustomerID,
                       Phone,
                       FullName,
                       Address,
                       Email,
                       CustomerType,
                       COALESCE(TotalPoints, 0) AS TotalPoints,
                       CreatedAt
                FROM Customers
                ORDER BY CreatedAt DESC;";
            return db.Query<CustomersDTO>(sql).AsList();
        }

        public int Insert(CustomersDTO customer)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();

            // Thực tế tên cột trong DB có thể là TotalPoint hoặc TotalPoints.
            // Ở đây ta chèn vào TotalPoint (thường là tên cột trong DB cũ).
            // Nếu DB của bạn dùng TotalPoints, đổi tên cột trong query tương ứng.
            const string sql = @"
                INSERT INTO Customers
                    (Phone, FullName, Address, Email, CustomerType, TotalPoints, CreatedAt)
                VALUES
                    (@Phone, @FullName, @Address, @Email, @CustomerType, @TotalPoints, @CreatedAt);
                SELECT LAST_INSERT_ID();";

            var parameters = new
            {
                customer.Phone,
                customer.FullName,
                customer.Address,
                customer.Email,
                customer.CustomerType,
                TotalPoints = customer.TotalPoints, // sẽ map vào TotalPoint cột
                CreatedAt = customer.CreatedAt == default ? DateTime.Now : customer.CreatedAt
            };

            return db.ExecuteScalar<int>(sql, parameters);
        }

        public bool Update(CustomersDTO customer)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();

            const string sql = @"
        UPDATE Customers
        SET FullName = @FullName,
            Address = @Address,
            Email = @Email,
            CustomerType = @CustomerType,
            TotalPoints = @TotalPoints,
            Phone = @Phone
        WHERE CustomerID = @CustomerID;";
                
            int affected = db.Execute(sql, new
                {
                    customer.FullName,
                    customer.Address,
                    customer.Email,
                    customer.CustomerType,
                    TotalPoints = customer.TotalPoints,
                    customer.Phone,
                    customer.CustomerID
                });

             return affected > 0;         
        }


        // Nếu cần GetById
        public CustomersDTO? GetById(int id)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string sql = @"
                SELECT CustomerID,
                       Phone,
                       FullName,
                       Address,
                       Email,
                       CustomerType,
                       COALESCE(TotalPoints, 0) AS TotalPoints,
                       CreatedAt
                FROM Customers
                WHERE CustomerID = @id
                LIMIT 1;";
            return db.QueryFirstOrDefault<CustomersDTO>(sql, new { id });
        }
    }
}
