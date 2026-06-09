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
        // Đảm bảo có từ khóa 'public' ở đây
        public List<WarrantyClaimsDTO> GetByStatus(string status) 
        {
            return _dal.GetByStatus(status);
        }
        // Mở file: BUS/WarrantyBUS.cs
        public List<WarrantyClaimsDTO> GetAll() 
        {
            return _dal.GetAll(); // Gọi hàm của DAL
        }
        
    }
}