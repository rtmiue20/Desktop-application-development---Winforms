namespace DTO;

public class ProductsDTO
{
    public int ProductID { get; set; }
    public string ProductCode { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int CategoryID { get; set; }
    public bool IsSerialized { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal CostPrice { get; set; }
    public int WarrantyMonths { get; set; }
    public int MinStock { get; set; }
}