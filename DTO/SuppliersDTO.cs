namespace DTO;

public class SuppliersDTO
{
    public int SupplierID { get; set; }
    public string SupplierCode { get; set; } = string.Empty;
    public string SupplierName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Address { get; set; }
    public decimal Debt { get; set; } // Công nợ nhà cung cấp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}