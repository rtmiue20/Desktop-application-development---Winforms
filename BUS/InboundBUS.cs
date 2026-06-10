using DAL;
using Dapper;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    /// <summary>
    /// Xử lý luồng nhập kho:
    /// tạo phiếu nhập → lưu chi tiết → tạo ProductItems cho hàng có serial
    /// </summary>
    public class InboundBUS
    {
        private readonly InboundReceiptsDAL _receiptDAL = new InboundReceiptsDAL();
        private readonly InboundDetailsDAL _detailDAL = new InboundDetailsDAL();
        private readonly ProductItemsDAL _itemDAL = new ProductItemsDAL();

        public List<InboundReceiptsDTO> GetAll() => _receiptDAL.GetAll();

        public (bool success, string error) CreateReceipt(
            InboundReceiptsDTO receipt,
            List<InboundDetailsDTO> details,
            List<string> serialCodes,   // danh sách serial cho hàng có ID
            int productIDForSerials)    // ProductID tương ứng với serialCodes
        {
            if (details == null || details.Count == 0)
                return (false, "Phiếu nhập không có sản phẩm nào.");

            int receiptID = _receiptDAL.Insert(receipt);
            if (receiptID <= 0)
                return (false, "Tạo phiếu nhập thất bại.");

            foreach (var detail in details)
            {
                detail.InboundID = receiptID;
                _detailDAL.Insert(detail);
            }

            // Tạo ProductItems cho từng serial
            if (serialCodes != null)
            {
                foreach (var code in serialCodes)
                {
                    _itemDAL.Insert(new ProductItemsDTO
                    {
                        ProductID = productIDForSerials,
                        ItemCode = code,
                        Status = "Trong kho",
                        InboundID = receiptID
                    });
                }
            }

            return (true, null);
        }
       
    }
}