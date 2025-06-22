namespace BO;

public class Sale
{
    public int IdSale { get; init; }
    public int ProductId { get; set; }
    public int RequiredAmount { get; set; }
    public double PriceSale { get; set; }
    public bool IsForClubMembers { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public override string ToString() => this.ToStringProperty();
    public Sale(int IdSale, int ProductId, int RequiredAmount, double PriceSale, bool IsForClubMembers, DateTime StartDate, DateTime EndDate):this(ProductId,RequiredAmount,PriceSale,IsForClubMembers,StartDate,EndDate)
    {
        this.IdSale = IdSale;
    }
    public Sale( int ProductId, int RequiredAmount, double PriceSale, bool IsForClubMembers, DateTime StartDate, DateTime EndDate)
    {
        this.IdSale =0;
        this.ProductId = ProductId;
        this.RequiredAmount = RequiredAmount;
        this.PriceSale = PriceSale;
        this.IsForClubMembers = IsForClubMembers;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
    }
}
