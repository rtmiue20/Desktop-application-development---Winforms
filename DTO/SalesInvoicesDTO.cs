namespace DTO;

public class SalesInvoicesDTO
{
    public int InvoiceID { get; set; }
    public string InvoiceCode { get; set; } = string.Empty;
    public int? CustomerID { get; set; }
    public int UserID { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalAmount { get; set; }
    public string PaymentMethod { get; set; } = "Tiền mặt";
    public DateTime SaleDate { get; set; } = DateTime.Now;
}