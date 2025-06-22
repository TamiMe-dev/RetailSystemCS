namespace DO;

public record Product(
    int IdProduct,
    string Name,
    Categories Category,
    double Price,
    int AmountInStock
)
{
    public Product() : this(0, "", Categories.EyeMakeup, 0.0, 0) { }
}
