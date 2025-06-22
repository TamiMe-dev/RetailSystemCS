using BlApi;
using BO;

namespace BlImplementation;

internal class ImplementationCustomers:ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(Customer item)
    {
        try
        {
            return _dal.Customer.Create(item.ConversBoCustomerToDoCustomer());
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public bool IsCustomerExist(int customerId)
    {
        try
        {
            _dal.Customer.Read(customerId); 
            return true; 
        }
        catch (DO.DalIdNotExistsException)
        {
            return false;
        }
    }


    public Customer? Read(int id)
    {
        try
        {
            return _dal.Customer.Read(id).ConversDoCustomerToBoCustomer();
        }
        catch (Exception e)
        {
            throw new Exception("Error reading client in BL layer", e);
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {

        try
        {
            return _dal.Customer.Read(p => filter(p.ConversDoCustomerToBoCustomer())).ConversDoCustomerToBoCustomer();
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        try
        {
            List<Customer> Customers = _dal.Customer.ReadAll().Select(p => p.ConversDoCustomerToBoCustomer()).ToList();
            if (filter != null)
                return Customers.Where(filter).ToList();

            return Customers;
        }
        catch (Exception e)
        {
            throw new Exception("Error reading all customers in BL layer", e);
        }
    }


    public void Update(Customer item)
    {
        try
        {
            _dal.Customer.Update(item.ConversBoCustomerToDoCustomer());
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }
}
