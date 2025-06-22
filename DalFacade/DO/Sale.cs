namespace DO;

public record Sale(
    int IdSale,
    int ProductId,
    int RequiredAmount,
    double PriceSale,
    bool IsForClubMembers,
    DateTime StartDate,
    DateTime EndDate
)
{
    public Sale() : this(0, 0, 0, 0.0, false, DateTime.MinValue, DateTime.MinValue) { }
}
