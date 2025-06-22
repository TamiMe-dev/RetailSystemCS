namespace DO;
public record Customer(
    int IdCustomer,
    string Name,
    string Address,
    string Phone
)
{
    public Customer() : this(0, "", "", "") { }
}
