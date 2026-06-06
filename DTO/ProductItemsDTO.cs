namespace DTO
{
    public class ProductItemsDTO
    {
        public int ItemID { get; set; }
        public int ProductID { get; set; }
        public string ItemCode { get; set; } = string.Empty; // Đây chính là mã Serial
        public string Status { get; set; } = "Trong kho";
        public int InboundID { get; set; }
        
        // --- CÁC TRƯỜNG CẦN BỔ SUNG THÊM ---
        public int? CustomerID { get; set; } 
        
        // Bổ sung luôn InvoiceID cho chuẩn với Database c
        public int? InvoiceID { get; set; } 
        
    }
}