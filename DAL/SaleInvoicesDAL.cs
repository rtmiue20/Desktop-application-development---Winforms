using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class SalesInvoicesDAL
    {
        public int Insert(SalesInvoicesDTO invoice)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string sql = @"
                INSERT INTO SalesInvoices
                    (InvoiceCode, CustomerID, UserID, TotalAmount, DiscountAmount, FinalAmount, PaymentMethod, SaleDate)
                VALUES
                    (@InvoiceCode, @CustomerID, @UserID, @TotalAmount, @DiscountAmount, @FinalAmount, @PaymentMethod, @SaleDate);
                SELECT LAST_INSERT_ID();";

            try
            {
                // Nếu SaleDate null thì truyền NOW() từ SQL; ở đây ta truyền giá trị từ DTO
                var parameters = new
                {
                    invoice.InvoiceCode,
                    CustomerID = invoice.CustomerID == 0 ? (int?)null : invoice.CustomerID,
                    invoice.UserID,
                    invoice.TotalAmount,
                    invoice.DiscountAmount,
                    invoice.FinalAmount,
                    invoice.PaymentMethod,
                    SaleDate = invoice.SaleDate == default ? DateTime.Now : invoice.SaleDate
                };

                int id = db.ExecuteScalar<int>(sql, parameters);
                return id;
            }
            catch
            {
                // Ném lên để tầng trên (BUS/GUI) xử lý; hoặc log ở đây nếu cần
                throw;
            }
        }

        public List<SalesInvoicesDTO> GetByShift(int userID, DateTime date)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string query = "SELECT * FROM SalesInvoices WHERE UserID = @userID AND DATE(SaleDate) = DATE(@date)";
            return db.Query<SalesInvoicesDTO>(query, new { userID, date }).AsList();
        }

        public SalesInvoicesDTO? GetByCode(string code)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string query = "SELECT * FROM SalesInvoices WHERE InvoiceCode = @code LIMIT 1";
            return db.QueryFirstOrDefault<SalesInvoicesDTO>(query, new { code });
        }

        public List<SalesInvoicesDTO> GetByDateRange(DateTime from, DateTime to)
        {
            using IDbConnection db = DatabaseHelper.GetConnection();
            const string query = "SELECT * FROM SalesInvoices WHERE SaleDate >= @from AND SaleDate <= @to";
            return db.Query<SalesInvoicesDTO>(query, new { from, to }).AsList();
        }
    }
}
