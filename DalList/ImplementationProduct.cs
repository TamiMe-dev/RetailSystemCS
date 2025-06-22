using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace DAL;

internal class ImplementationProduct : IProduct
{
    public int Create(Product item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.IdProduct.ToString());
        Product product = item with { IdProduct = DataSource.Config.ProductCode };
        DataSource.Products.Add(product);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product addition successful");
        return product.IdProduct;
    }

    public Product? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+id);

        foreach (Product item in DataSource.Products)
        {
            if (item.IdProduct == id)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "\"Product readed successful\"\r\n");
                return item;
            }
        }
        throw new DalIdNotExistsException("not found!");
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        Product product = DataSource.Products.FirstOrDefault(c => filter(c));
        if (product == null)
            throw new DalIdNotExistsException("The product does not exist");
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        return product;
    }

    public List<Product> ReadAll(Func<Product, bool> filter = null)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Products were read successfully");
        if (filter == null)
        {
            return new List<Product>(DataSource.Products);
        }
        else
        {
            return DataSource.Products .Where(filter).ToList();
        }
    }

    public void Update(Product item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+item.IdProduct.ToString());
        Delete(item.IdProduct);
        DataSource.Products.Add(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product updated successfully");
    }

    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+id);
        Product product = Read(id);
        DataSource.Products.Remove(product);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product deleted successfully");
    }
}
