namespace DTO;

public class ShiftsDTO
{
    public int ShiftID { get; set; }
    public string ShiftCode { get; set; } = string.Empty;
    public int UserID { get; set; }
    public DateTime StartTime { get; set; } = DateTime.Now;
    public DateTime? EndTime { get; set; }
    public decimal OpeningCash { get; set; }
    public decimal ClosingCash { get; set; }
    public decimal ExpectedCash { get; set; }
    public decimal DifferenceAmount { get; set; }
    public string? DifferenceNote { get; set; }
    public string Status { get; set; } = "Đang mở";
}