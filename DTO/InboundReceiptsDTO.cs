namespace DTO;

public class InboundReceiptsDTO
{
        public int InboundID { get; set; }
        public string InboundCode { get; set; } = string.Empty;
        public int SupplierID { get; set; }
        public int UserID { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime ReceiptDate { get; set; } = DateTime.Now;
        public string? Note { get; set; }
}