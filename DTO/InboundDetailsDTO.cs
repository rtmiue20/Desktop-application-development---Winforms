namespace DTO;

public class InboundDetailsDTO
{
    public int InboundID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal UnitCost { get; set; }
    public decimal TotalCost { get; set; }
}