using DAL;
using DTO;

namespace BUS
{
    public class ProductItemsBUS
    {
        private readonly ProductItemsDAL _dal = new ProductItemsDAL();

        /// <summary>
        /// Kiểm tra serial hợp lệ khi bán hàng.
        /// Trả về item nếu đang "Trong kho", null nếu không hợp lệ.
        /// </summary>
        public (ProductItemsDTO item, string error) ValidateForSale(string itemCode)
        {
            if (string.IsNullOrWhiteSpace(itemCode))
                return (null, "Mã serial không được để trống.");

            var item = _dal.GetByItemCode(itemCode);
            if (item == null)
                return (null, $"Không tìm thấy serial: {itemCode}");
            if (item.Status != "Trong kho")
                return (null, $"Serial {itemCode} đang ở trạng thái: {item.Status}");

            return (item, null);
        }

        public bool MarkAsSold(int itemID) =>
            _dal.UpdateStatus(itemID, "Đã bán");

        public bool MarkAsWarranty(int itemID) =>
            _dal.UpdateStatus(itemID, "Đang bảo hành");

        public bool MarkAsDefective(int itemID) =>
            _dal.UpdateStatus(itemID, "Lỗi");
        public ProductItemsDTO GetByItemCode(string itemCode)
        {
            return _dal.GetByItemCode(itemCode);
        }
        
    }
}