using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class ReportsBUS
    {
        private readonly SalesInvoicesDAL _invoiceDAL  = new SalesInvoicesDAL();
        private readonly SalesDetailsDAL  _detailDAL   = new SalesDetailsDAL();
        private readonly ReportsDAL       _reportsDAL  = new ReportsDAL();

        // ── Đã có sẵn từ leader ───────────────────────────────────
        /// <summary>Doanh thu + lợi nhuận gộp trong ngày của một nhân viên.</summary>
        public (decimal revenue, decimal profit) GetDailySummary(int userID, DateTime date)
        {
            var invoices = _invoiceDAL.GetByShift(userID, date);
            decimal revenue = 0, cost = 0;

            foreach (var inv in invoices)
            {
                revenue += inv.FinalAmount;
                var details = _detailDAL.GetByInvoice(inv.InvoiceID);
                cost += details.Sum(d => d.CostPrice * d.Quantity);
            }

            return (revenue, revenue - cost);
        }

        // ── Bổ sung cho FormReport ────────────────────────────────

        /// <summary>Tổng hợp: doanh thu, lợi nhuận, số đơn, số sp bán ra theo khoảng ngày.</summary>
        public ReportSummaryDTO GetSummary(DateTime from, DateTime to)
        {
            return _reportsDAL.GetSummary(from, to);
        }

        /// <summary>Top N sản phẩm bán chạy nhất theo khoảng ngày.</summary>
        public List<TopProductDTO> GetTopProducts(DateTime from, DateTime to, int top = 10)
        {
            return _reportsDAL.GetTopProducts(from, to, top);
        }

        /// <summary>Doanh thu + lợi nhuận theo từng ngày trong khoảng.</summary>
        public List<RevenueByDateDTO> GetRevenueByDate(DateTime from, DateTime to)
        {
            return _reportsDAL.GetRevenueByDate(from, to);
        }
    }
}