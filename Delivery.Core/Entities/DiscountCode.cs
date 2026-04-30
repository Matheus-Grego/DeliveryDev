namespace Delivery.Core.Entities;

public class DiscountCode : BaseEntity
{
    public DiscountCode(string code, DateTime? expirationDate, decimal discountAmount, decimal? minimalOrderAmount)
    {
        Code = code;
        ExpirationDate = expirationDate;
        IsActive = true;
        DiscountAmount = discountAmount;
        MinimalOrderAmount = minimalOrderAmount;
    }

    public string Code { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal? MinimalOrderAmount { get; set; }
}