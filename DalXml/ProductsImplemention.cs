using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class ProductsImplemention : IProduct
{
    const string PRODUCTS_XML = @"..\xml\products.xml";
    public int Create(Product item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.IdProduct.ToString());
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> listProduct;
        using (StreamReader sr = new StreamReader(PRODUCTS_XML))
        {
            listProduct = serializer.Deserialize(sr) as List<Product>;
        }
        if (item.IdProduct == 0)
        {
            int code = Config.ProductCurrentCode;
            listProduct.Add(item with { IdProduct = code });
        }
        else
        {
            listProduct.Add(item);
        }
        using (StreamWriter sw = new StreamWriter(PRODUCTS_XML))
        {
            serializer.Serialize(sw, listProduct);
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product addition successful");
        return item.IdProduct;
    }

    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> listProduct;
        using (StreamReader sr = new StreamReader(PRODUCTS_XML))
        {
            listProduct = serializer.Deserialize(sr) as List<Product>;
        }
        listProduct.Remove(listProduct.FirstOrDefault(product => product.IdProduct == id));
        using (StreamWriter sw = new StreamWriter(PRODUCTS_XML))
        {
            serializer.Serialize(sw, listProduct);
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product deleted successfully");
    }

    public Product? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> listProduct;
        using (StreamReader sr = new StreamReader(PRODUCTS_XML))
        {
            listProduct = serializer.Deserialize(sr) as List<Product>;
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "\"Product readed successful\"\r\n");
        return listProduct.FirstOrDefault(product => product.IdProduct == id);
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> listProduct;
        using (StreamReader sr = new StreamReader(PRODUCTS_XML))
        {
            listProduct = serializer.Deserialize(sr) as List<Product>;
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        return listProduct.FirstOrDefault(filter);
    }

    public List<Product> ReadAll(Func<Product, bool> filter = null)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Products were read successfully");
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> listProduct;
        using (StreamReader sr = new StreamReader(PRODUCTS_XML))
        {
            listProduct = serializer.Deserialize(sr) as List<Product>;
        }
        if(filter != null)
            return listProduct.Where(filter).ToList();
        return listProduct.Select(p=>p).ToList();
    }

    public void Update(Product item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.IdProduct.ToString());
        Delete(item.IdProduct);
        Create(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product updated successfully");
    }
}
