using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    /// <summary>
    /// Xử lý toàn bộ luồng bán hàng:
    /// validate → tạo hóa đơn → trừ kho → cập nhật trạng thái serial
    /// </summary>
    public class SalesBUS
    {
        private readonly SalesInvoicesDAL _invoiceDAL = new SalesInvoicesDAL();
        private readonly SalesDetailsDAL _detailDAL = new SalesDetailsDAL();
        private readonly ProductItemsDAL _itemDAL = new ProductItemsDAL();

        public List<SalesInvoicesDTO> GetByShift(int userID, System.DateTime date) =>
            _invoiceDAL.GetByShift(userID, date);

        public SalesInvoicesDTO GetByCode(string code) =>
            _invoiceDAL.GetByCode(code);

        /// <summary>
        /// Hoàn tất bán hàng: lưu hóa đơn + chi tiết + cập nhật trạng thái serial.
        /// </summary>
        public (bool success, string error) Checkout(
            SalesInvoicesDTO invoice,
            List<SalesDetailsDTO> details)
        {
            if (details == null || details.Count == 0)
                return (false, "Hóa đơn không có sản phẩm nào.");
            if (invoice.FinalAmount <= 0)
                return (false, "Tổng tiền không hợp lệ.");

            int invoiceID = _invoiceDAL.Insert(invoice);
            if (invoiceID <= 0)
                return (false, "Tạo hóa đơn thất bại.");

            foreach (var detail in details)
            {
                detail.InvoiceID = invoiceID;
                _detailDAL.Insert(detail);

                // Nếu là hàng có serial → cập nhật trạng thái "Đã bán"
                if (detail.SerialID.HasValue)
                    _itemDAL.UpdateStatus(detail.SerialID.Value, "Đã bán");
            }

            return (true, null);
        }

        public SalesInvoicesDTO GetByInvoiceCode(string code) => _invoiceDAL.GetByCode(code);

        public List<SalesDetailsDTO> GetInvoiceDetails(int invoiceID) => _detailDAL.GetByInvoiceID(invoiceID);
    }
}