namespace BO;

public class Product
{

    public int IdProduct { get; init; }
    public string Name { get; set; }
    public Categories Category { get; set; }
    public double Price { get; set; }
    public int AmountInStock { get; set; }
    public List<SaleInProduct> ListOfSale { get; set; } = new List<SaleInProduct>();
    public override string ToString() => this.ToStringProperty();
    public Product(string Name, Categories Category, double Price, int AmountInStock)
    {
        this.Name = Name;
        this.Category = Category;
        this.Price = Price;
        this.AmountInStock = AmountInStock;
    }
    public Product(int IdProduct,string Name, Categories Category, double Price, int AmountInStock):this(Name,Category, Price, AmountInStock)
    {
        this.IdProduct = IdProduct;
    }

    public Product()
    {
        IdProduct = 0;
        Name = string.Empty;
        Category = new Categories();
        Price = 0;
        AmountInStock = 0;
    }

}
