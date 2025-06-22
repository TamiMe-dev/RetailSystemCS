namespace BO;

public class Order
{
    public bool IsFavoriteCustomer {  get; set; }
    public List<ProductInOrder>ProductList { get; set; }

    public double TotalPrice {  get; set; }

    public Order()
    {
        IsFavoriteCustomer = false;
        ProductList = new List<ProductInOrder>();
        TotalPrice = 0;
    }

    public Order(bool IsFavoriteCustomer)
    {
        this.IsFavoriteCustomer = IsFavoriteCustomer;
        ProductList = new List<ProductInOrder>();
        TotalPrice = 0;
    }
    public Order(bool IsFavoriteCustomer, List<ProductInOrder> ProductList,double TotalPrice)
    {
        this.IsFavoriteCustomer=IsFavoriteCustomer; 
        this.ProductList = ProductList; 
        this.TotalPrice = TotalPrice;
    }
}
