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
            // 1. Kiểm tra các ràng buộc logic đầu vào (Validate)
            if (invoiceID == 0) return (false, "Mã hóa đơn gốc không hợp lệ.");
            if (returnedSerials == null || returnedSerials.Count == 0) return (false, "Danh sách sản phẩm chọn đổi trả đang trống.");
            if (refundAmount < 0) return (false, "Số tiền hoàn trả không được phép âm.");

            try
            {
                foreach (var serial in returnedSerials)
                {
                    // Tùy vào lý do mà cập nhật trạng thái máy trong kho
                    string newStatus = reason.Contains("lỗi") ? "Lỗi" : "Trong kho";
                    
                }

                // Trả về thành công nếu chạy mượt mà
                return (true, null);
            }
            catch (Exception ex)
            {
                // Trả về thất bại kèm thông báo lỗi cụ thể
                return (false, $"Lỗi hệ thống khi xử lý đổi trả: {ex.Message}");
            }
        }
    }
}