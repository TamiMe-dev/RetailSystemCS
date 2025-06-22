using DalApi;
using DO;
using Tools;
using System.Reflection;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Dal;

internal class CustomersImplemention : ICustomer
{
    const string CUSTOMERS = @"..\xml\customers.xml";
    const string CUSTOMER = "Customer";
    const string ID_CUSTOMER = "IdCustomer";
    const string NAME = "Name";
    const string ADDRESS = "Address";
    const string PHONE = "Phone";
    public int Create(Customer item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.IdCustomer.ToString());
        XElement customersXml = XElement.Load(CUSTOMERS);
        XElement existing = customersXml.Elements(CUSTOMER).FirstOrDefault(c => c.Element(ID_CUSTOMER)?.Value == item.IdCustomer.ToString());

        if (existing == null)
        {
            customersXml.Add(new XElement(CUSTOMER,
            new XElement(ID_CUSTOMER, item.IdCustomer),
            new XElement(NAME, item.Name),
            new XElement(ADDRESS, item.Address),
            new XElement(PHONE, item.Phone)));
            customersXml.Save(CUSTOMERS);
            LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer addition successful");
            return item.IdCustomer;
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer addition successful");
        return 0;
    }

    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        XElement customersXml = XElement.Load(CUSTOMERS);
        customersXml.Descendants(ID_CUSTOMER).First(idCustomer => idCustomer.Value == id.ToString()).Parent.Remove();
        customersXml.Save(CUSTOMERS);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer deleted successfully");

    }

    public Customer? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        XElement customersXml = XElement.Load(CUSTOMERS);
        XElement customer = customersXml.Descendants(ID_CUSTOMER).FirstOrDefault(idCustomer => idCustomer.Value==id.ToString()).Parent;
        if(customer != null)
        {
            LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
            return new Customer(int.Parse(customer.Element(ID_CUSTOMER).Value),
                                          customer.Element(NAME).Value,
                                          customer.Element(ADDRESS).Value,
                                          customer.Element(PHONE).Value);

                                          
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        return null;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        XElement customersXml = XElement.Load(CUSTOMERS);
      
            List<Customer> customers = customersXml.Descendants(CUSTOMER)
                .Select(c => new Customer(
                    int.Parse(c.Element(ID_CUSTOMER).Value)
                    , c.Element(NAME).Value,
                    c.Element(ADDRESS).Value,
                    c.Element(PHONE).Value)).ToList();
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        return customers.FirstOrDefault(filter);
        
    }

    public List<Customer> ReadAll(Func<Customer, bool> filter = null)
    {

        XElement customersXml = XElement.Load(CUSTOMERS);
        List<Customer> customers = customersXml.Descendants(CUSTOMER)
            .Select(c => new Customer(
                int.Parse(c.Element(ID_CUSTOMER).Value)
                , c.Element(NAME).Value,
                c.Element(ADDRESS).Value,
                c.Element(PHONE).Value)).ToList();
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customers were read successfully");
        if (filter != null)
            return customers.Where(filter).ToList();
        return customers;
    }


    public void Update(Customer item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id: " + item.IdCustomer.ToString());
        XElement customersXml = XElement.Load(CUSTOMERS);
        Delete(item.IdCustomer);
        Create(item);
        customersXml.Save(CUSTOMER);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer updated successfully");
    }

}
