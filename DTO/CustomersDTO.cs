namespace DTO;

public class CustomersDTO
{
    public int CustomerID { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string CustomerType { get; set; } = "Thường";
    public int TotalPoints { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}