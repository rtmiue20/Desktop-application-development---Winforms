namespace DTO;

/// <summary>Tổng hợp chung: doanh thu, lợi nhuận, số đơn, số sản phẩm bán ra.</summary>
public class ReportSummaryDTO
{
    public decimal Revenue    { get; set; }
    public decimal Profit     { get; set; }
    public int     OrderCount { get; set; }
    public int     ItemsSold  { get; set; }
}

/// <summary>Một dòng trong bảng top sản phẩm bán chạy.</summary>
public class TopProductDTO
{
    public string  ProductName   { get; set; } = string.Empty;
    public int     QuantitySold  { get; set; }
    public decimal TotalRevenue  { get; set; }
    public decimal TotalProfit   { get; set; }
}

/// <summary>Một dòng trong bảng doanh thu theo ngày.</summary>
public class RevenueByDateDTO
{
    public DateTime SaleDate   { get; set; }
    public decimal  Revenue    { get; set; }
    public decimal  Profit     { get; set; }
    public int      OrderCount { get; set; }
}