using System.Collections;
using System.Reflection;

namespace BO;

internal static class Tools
{
    public static string ToStringProperty<T>(this T obj)
    {
        if (obj == null) return "null";

        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();
        List<string> propertyStrings = new List<string>();

        foreach (var property in properties)
        {
            object value = property.GetValue(obj);
            if (value is IEnumerable)
            {
                List<string> listItems = new List<string>();
                foreach (var item in (IEnumerable)value)
                {
                    listItems.Add(item?.ToString());
                }
                propertyStrings.Add($"{property.Name}: [{string.Join(", ", listItems)}]");
            }
            else
            {
                propertyStrings.Add($"{property.Name}: {value?.ToString()}");
            }
        }

        return string.Join(", ", propertyStrings);
    }



    public static DO.Product ConvertBoProductToDoProduct(this BO.Product product)
    {
        return new DO.Product(product.IdProduct, product.Name, (DO.Categories)product.Category, product.Price, product.AmountInStock);
    }


    public static BO.Product ConversDoProductToBoProduct(this DO.Product product)
    {
        return new BO.Product(product.Name, (BO.Categories)product.Category, product.Price, product.AmountInStock);
    }

    public static BO.Product ConversDoProductToBoProductWithId(this DO.Product product)
    {
        return new BO.Product(product.IdProduct,product.Name, (BO.Categories)product.Category, product.Price, product.AmountInStock);
    }

    public static DO.Customer ConversBoCustomerToDoCustomer(this BO.Customer customer)
    {
        return new DO.Customer(customer.IdCustomer,customer.Name, customer.Address, customer.Phone);
    }

    public static BO.Customer ConversDoCustomerToBoCustomer(this DO.Customer customer)
    {
        return new BO.Customer(customer.IdCustomer, customer.Name, customer.Address, customer.Phone);
    }

    public static DO.Sale ConversBoSaleToDoSale(this BO.Sale sale)
    {
        return new DO.Sale(sale.IdSale, sale.ProductId, sale.RequiredAmount, sale.PriceSale, sale.IsForClubMembers, sale.StartDate, sale.EndDate);

    }

    public static BO.Sale ConversDoSaleToBoSale(this DO.Sale sale)
    {
        return new BO.Sale(sale.IdSale, sale.ProductId, sale.RequiredAmount, sale.PriceSale, sale.IsForClubMembers, sale.StartDate, sale.EndDate);

    }

    public static Product ConvertDoProductToBoProduct(this DO.Product product)
    {
        return new Product
        {
            IdProduct = product.IdProduct,
            Name = product.Name,
            Category = (Categories)product.Category,
            Price = product.Price,
            AmountInStock = product.AmountInStock
        };
    }

}


