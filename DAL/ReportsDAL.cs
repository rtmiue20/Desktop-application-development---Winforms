using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class ReportsDAL
    {
        /// <summary>Tổng hợp doanh thu, lợi nhuận, số đơn, số sp bán ra theo khoảng ngày.</summary>
        public ReportSummaryDTO GetSummary(DateTime from, DateTime to)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"
                    SELECT
                        COALESCE(SUM(i.FinalAmount), 0)                    AS Revenue,
                        COALESCE(SUM(i.FinalAmount - d.TotalCost), 0)      AS Profit,
                        COUNT(DISTINCT i.InvoiceID)                        AS OrderCount,
                        COALESCE(SUM(d.TotalQty), 0)                       AS ItemsSold
                    FROM SalesInvoices i
                    LEFT JOIN (
                        SELECT InvoiceID,
                               SUM(CostPrice * Quantity) AS TotalCost,
                               SUM(Quantity)             AS TotalQty
                        FROM   SalesDetails
                        GROUP  BY InvoiceID
                    ) d ON d.InvoiceID = i.InvoiceID
                    WHERE DATE(i.SaleDate) BETWEEN @From AND @To";

                return db.QueryFirstOrDefault<ReportSummaryDTO>(query,
                    new { From = from.Date, To = to.Date })
                    ?? new ReportSummaryDTO();
            }
        }

        /// <summary>Top N sản phẩm bán chạy theo khoảng ngày.</summary>
        public List<TopProductDTO> GetTopProducts(DateTime from, DateTime to, int top = 10)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"
                    SELECT
                        p.ProductName,
                        SUM(d.Quantity)                        AS QuantitySold,
                        SUM(d.UnitPrice * d.Quantity)          AS TotalRevenue,
                        SUM((d.UnitPrice - d.CostPrice) * d.Quantity) AS TotalProfit
                    FROM SalesDetails d
                    JOIN Products p ON p.ProductID = d.ProductID
                    JOIN SalesInvoices i ON i.InvoiceID = d.InvoiceID
                    WHERE DATE(i.SaleDate) BETWEEN @From AND @To
                    GROUP BY p.ProductID, p.ProductName
                    ORDER BY QuantitySold DESC
                    LIMIT @Top";

                return db.Query<TopProductDTO>(query,
                    new { From = from.Date, To = to.Date, Top = top }).AsList();
            }
        }

        /// <summary>Doanh thu + lợi nhuận theo từng ngày.</summary>
        public List<RevenueByDateDTO> GetRevenueByDate(DateTime from, DateTime to)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"
                    SELECT
                        DATE(i.SaleDate)                             AS SaleDate,
                        COALESCE(SUM(i.FinalAmount), 0)              AS Revenue,
                        COALESCE(SUM(i.FinalAmount - d.TotalCost), 0) AS Profit,
                        COUNT(DISTINCT i.InvoiceID)                  AS OrderCount
                    FROM SalesInvoices i
                    LEFT JOIN (
                        SELECT InvoiceID, SUM(CostPrice * Quantity) AS TotalCost
                        FROM   SalesDetails
                        GROUP  BY InvoiceID
                    ) d ON d.InvoiceID = i.InvoiceID
                    WHERE DATE(i.SaleDate) BETWEEN @From AND @To
                    GROUP BY DATE(i.SaleDate)
                    ORDER BY SaleDate";

                return db.Query<RevenueByDateDTO>(query,
                    new { From = from.Date, To = to.Date }).AsList();
            }
        }
    }
}