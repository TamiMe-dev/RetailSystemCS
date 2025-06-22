namespace BO;

public class SaleInProduct
{
    public int SaleId { get; init; }
    public int ProductId { get; init; }
    public int AmountForSale { get; set; }
    public double Price { get; set; }
    public bool IsSaleForAllCustomers { get; set; }
    public override string ToString() => this.ToStringProperty();

    public SaleInProduct(int saleId,int productId, int amountForSale, double price, bool isSaleForAllCustomers)
    {
        SaleId = saleId;
        ProductId = productId;
        AmountForSale = amountForSale;
        Price = price;
        IsSaleForAllCustomers = isSaleForAllCustomers;
    }
    public SaleInProduct() 
    {
        SaleId = 0;
        AmountForSale = 0;
        Price = 0;

    }
}


