using BlApi;
using BO;
using System.Linq;

namespace BlImplementation;

internal class ImplementationProduct : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(Product item)
    {
        try
        {
            return _dal.Product.Create(item.ConvertBoProductToDoProduct());
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
            _dal.Product.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public Product? Read(int id)
    {

        try
        {
            return _dal.Product.Read(id).ConversDoProductToBoProduct();
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(p => filter(p.ConversDoProductToBoProduct())).ConversDoProductToBoProduct();


        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            List<Product> products = _dal.Product.ReadAll().Select(p => p.ConversDoProductToBoProductWithId()).ToList();
            if (filter != null)
                return products.Where(filter).ToList();

            return products;
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public void Update(Product item)
    {

        try
        {
            _dal.Product.Update(item.ConvertBoProductToDoProduct());
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }

    public void UpdateValidSalesForProduct(int code, bool isFavorite)
    {
        throw new NotImplementedException();
    }
}
