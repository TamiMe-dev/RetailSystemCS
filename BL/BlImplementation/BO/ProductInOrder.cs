using DO;
using System.Collections.Generic;

namespace BO;

public class ProductInOrder
{

    public int ProductId { get; set; }
    public double BasePrice { get; set; }
    public int AmountOfOrder { get; set; }
    public List<SaleInProduct> SalesOfProduct { get; set; } = new List<SaleInProduct>();
    public double TotalPrice { get; set; }
    public override string ToString() => this.ToStringProperty();

    public ProductInOrder(int productId, double basePrice, int amountOfOrder, List<SaleInProduct> salesOfProduct)
    {
        ProductId = productId;
        BasePrice = basePrice;
        AmountOfOrder = amountOfOrder;
        SalesOfProduct = salesOfProduct;
        TotalPrice = basePrice * amountOfOrder; 
    }

    public ProductInOrder(int productId, double basePrice, int amountOfOrder)
    {
        ProductId = productId;
        BasePrice = basePrice;
        AmountOfOrder = amountOfOrder;
        TotalPrice = basePrice * amountOfOrder;
    }
    public ProductInOrder() 
    {
        ProductId = 0;
        BasePrice = 0;
        AmountOfOrder = 0;
        TotalPrice = 0;
    }


}
