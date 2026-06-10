using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class WarrantyBUS
    {
        private readonly WarrantyClaimsDAL _dal = new WarrantyClaimsDAL();
        private readonly ProductItemsDAL _itemDAL = new ProductItemsDAL();

        public List<WarrantyClaimsDTO> GetByCustomer(int customerID) =>
            _dal.GetByCustomer(customerID);

        public (bool success, string error) Receive(WarrantyClaimsDTO claim)
        {
            if (string.IsNullOrWhiteSpace(claim.DefectDescription))
                return (false, "Mô tả lỗi không được để trống.");

            claim.Status = "Đang kiểm tra";
            int id = _dal.Insert(claim);
            if (id <= 0) return (false, "Tiếp nhận bảo hành thất bại.");

            // Cập nhật trạng thái serial sang "Đang bảo hành"
            _itemDAL.UpdateStatus(claim.SerialID, "Đang bảo hành");
            return (true, null);
        }

        public bool UpdateStatus(int claimID, string status, string resolution = null) =>
            _dal.UpdateStatus(claimID, status, resolution);

        /// <summary>Trả máy cho khách → serial về "Trong kho" hoặc "Đã bán" tùy resolution.</summary>
        public bool ReturnToCustomer(int claimID, int serialID, string resolution)
        {
            _dal.UpdateStatus(claimID, "Đã trả khách", resolution);
            _itemDAL.UpdateStatus(serialID, "Đã bán");
            return true;
        }

        public List<WarrantyClaimsDTO> GetByStatus(string status) 
        {
            return _dal.GetByStatus(status);
        }

        public List<WarrantyClaimsDTO> GetAll() 
        {
            return _dal.GetAll(); 
        }
        public (bool success, string error) CreateTradeIn(int invoiceID, int customerID, string reason, string note, decimal refundAmount, List<string> returnedSerials)
        {
            // 1. Kiểm tra đầu vào
            if (invoiceID <= 0) return (false, "Mã hóa đơn gốc không hợp lệ.");
            if (returnedSerials == null || returnedSerials.Count == 0) return (false, "Danh sách sản phẩm chọn đổi trả đang trống.");
            if (refundAmount < 0) return (false, "Số tiền hoàn trả không được phép âm.");

            try
            {
                // 2. Duyệt qua từng số Serial được tích chọn trên giao diện
                foreach (var serial in returnedSerials)
                {
                    // Xác định trạng thái mới dựa trên lý do
                    string newStatus = reason.Contains("lỗi") ? "Lỗi" : "Trong kho";

                    // Tìm sản phẩm trong DB theo Serial
                    var item = _itemDAL.GetByItemCode(serial);
                    if (item != null)
                    {
                        // Bước 2.1: Cập nhật lại trạng thái của máy đó trong kho
                        _itemDAL.UpdateStatus(item.ItemID, newStatus);

                        // Bước 2.2: Tạo một phiếu bảo hành/đổi trả mới lưu vào DB
                        var claim = new WarrantyClaimsDTO
                        {
                            ClaimCode = "ĐỔITRẢ-" + DateTime.Now.ToString("ddMMyyHHmmss"),
                            SerialID = item.ItemID,
                            CustomerID = customerID,
                            UserID = 1, // (Nếu bạn có biến lưu UserID đăng nhập thì thay số 1 bằng biến đó)
                            InvoiceID = invoiceID,
                            DefectDescription = note,
                            Status = "Đã hoàn tất",
                            Resolution = "Hoàn tiền đổi trả: " + reason
                        };
                        _dal.Insert(claim); // Gọi lệnh INSERT xuống bảng WarrantyClaims
                    }
                }

                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, $"Lỗi hệ thống khi xử lý: {ex.Message}");
            }
        }
    }
}