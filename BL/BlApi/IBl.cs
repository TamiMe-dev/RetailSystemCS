namespace BlApi;

public interface IBl
{
    public ICustomer Customer { get; }
    public ISale Sale { get; }
    public IProduct Product { get; }
    public IOrder Order { get; }
}
