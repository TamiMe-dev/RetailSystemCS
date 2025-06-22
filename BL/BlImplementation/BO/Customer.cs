namespace BO;

public class Customer
{
    public int IdCustomer {get;init;}
    public string Name {get;set;}
    public string ?Address {get;set;}
    public string Phone {get;set;}

    public override string ToString() => this.ToStringProperty();
    public Customer(int IdCustumer, string Name, string Address, string Phone)
    {
        this.IdCustomer = IdCustumer;
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
    }
}


