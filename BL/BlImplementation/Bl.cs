
using BlApi;
using Tools;

namespace BlImplementation;

internal class Bl : IBl
{
    public ICustomer Customer => new ImplementationCustomers();

    public ISale Sale => new ImplementationSale();

    public IProduct Product => new ImplementationProduct();

    public IOrder Order =>  new ImplementationOrders();

    public Bl()
    {
        LogManager.DeleteLog();
    }
}
