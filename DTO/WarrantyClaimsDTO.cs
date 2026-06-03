namespace DTO;

public class WarrantyClaimsDTO
{
    public int ClaimID { get; set; }
    public string ClaimCode { get; set; } = string.Empty;
    public int SerialID { get; set; }
    public int CustomerID { get; set; }
    public int UserID { get; set; }
    public int InvoiceID { get; set; }
    public DateTime ReceiveDate { get; set; } = DateTime.Now;
    public string DefectDescription { get; set; } = string.Empty;
    public string Status { get; set; } = "Đang kiểm tra";
    public string? Resolution { get; set; }
}