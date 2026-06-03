namespace DTO;

public class SalesDetailsDTO
{
    public int InvoiceID { get; set; }
    public int ProductID { get; set; }
    public int? SerialID { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal CostPrice { get; set; }
    
}