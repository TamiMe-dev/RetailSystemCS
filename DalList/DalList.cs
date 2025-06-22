using DalApi;

namespace DAL;

public sealed class DalList : IDal
{
    private static readonly DalList instance;
    public static DalList Instance
    {
        get
        {
            if (instance != null)
                return instance;
            return new DalList();
        }
    }
    private DalList()
    {
    }
    public ICustomer Customer => new ImplementationCustomers();
    public IProduct Product=> new ImplementationProduct();
    public ISale Sale =>new ImplementationSale();
}


