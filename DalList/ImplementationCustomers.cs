
using DO;
using DalApi;
using System.Reflection;
using Tools;


namespace DAL;

internal class ImplementationCustomers : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name,"id:"+item.IdCustomer.ToString());

        foreach (Customer i in DataSource.Customers)
        {
            if (item.IdCustomer == i.IdCustomer)
            {
                throw new DalIdExistsException("Customer already exists");
            }
        }
        DataSource.Customers.Add(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer addition successful");
        return item.IdCustomer;
    }

    public Customer? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name,"id:"+ id.ToString());

        foreach (Customer item in DataSource.Customers)
        {
            if (item.IdCustomer == id)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer read successfully");
                return item;
            }
        }
        throw new DalIdNotExistsException("not found!");
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");

        Customer customer = DataSource.Customers.FirstOrDefault(c => filter(c));
        if (customer == null)
            throw new DalIdNotExistsException("The customer is not exists");
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        return customer;
    }
    public List<Customer> ReadAll(Func<Customer, bool> filter = null)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customers were read successfully");
        if(filter == null)
        {
            return new List<Customer>(DataSource.Customers);
        }
        else
        {
            return  DataSource.Customers.Where(filter).ToList();
        }
    }

    public void Update(Customer item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id: "+item.IdCustomer.ToString());

        Delete(item.IdCustomer);
        DataSource.Customers.Add(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer updated successfully");
    }
    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+id);
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer deleted successfully");
    }
}
