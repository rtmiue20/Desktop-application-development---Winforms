namespace DTO;

public class ProductItemsDTO
{
    public int ItemID { get; set; }
    public int ProductID { get; set; }
    public string ItemCode { get; set; } = string.Empty; // Đây chính là mã Serial
    public string Status { get; set; } = "Trong kho";
    public int InboundID { get; set; }
}