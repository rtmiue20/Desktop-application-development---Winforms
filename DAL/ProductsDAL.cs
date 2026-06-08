using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class ProductsDAL
    {
        public List<ProductsDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<ProductsDTO>("SELECT * FROM Products").AsList();
            }
        }

        public ProductsDTO GetByCode(string code)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.QueryFirstOrDefault<ProductsDTO>(
                    "SELECT * FROM Products WHERE ProductCode=@code", new { code });
            }
        }

        public int Insert(ProductsDTO product)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Products
                         (ProductCode, ProductName, CategoryID, IsSerialized, UnitPrice, CostPrice, WarrantyMonths, MinStock, ImagePath)
                         VALUES (@ProductCode, @ProductName, @CategoryID, @IsSerialized, @UnitPrice, @CostPrice, @WarrantyMonths, @MinStock, @ImagePath);
                         SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, product);
            }
        }

        public bool Update(ProductsDTO product)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Products SET ProductName=@ProductName, CategoryID=@CategoryID,
                         UnitPrice=@UnitPrice, CostPrice=@CostPrice,
                         WarrantyMonths=@WarrantyMonths, MinStock=@MinStock, ImagePath=@ImagePath
                         WHERE ProductID=@ProductID";
                return db.Execute(query, product) > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Execute("DELETE FROM Products WHERE ProductID=@id", new { id }) > 0;
            }
        }
    }
}