using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class SalesImplemention:ISale
{
    const string SALE_XML = @"..\xml\sales.xml";
    public int Create(Sale item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, item.IdSale.ToString());
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> listSale;
        using (StreamReader sr = new StreamReader(SALE_XML))
        {
            listSale = serializer.Deserialize(sr) as List<Sale>;
        }
        int code=Config.SaleCurrentCode;
        listSale.Add(item with { IdSale = code });
        using (StreamWriter sw = new StreamWriter(SALE_XML))
        {
            serializer.Serialize(sw, listSale);
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale created successful");
        return item.IdSale;
    }

    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> listSale;
        using (StreamReader sr = new StreamReader(SALE_XML))
        {
            listSale = serializer.Deserialize(sr) as List<Sale>;
        }
        listSale.Remove(listSale.FirstOrDefault(sale => sale.IdSale == id));
        using (StreamWriter sw = new StreamWriter(SALE_XML))
        {
            serializer.Serialize(sw, listSale);
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale deleted successful");
    }

    public Sale? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> listSale;
        using (StreamReader sr = new StreamReader(SALE_XML))
        {
            listSale = serializer.Deserialize(sr) as List<Sale>;
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale read successfully");
        return listSale.FirstOrDefault(sale => sale.IdSale == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale read successfully");
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> listSale;
        using (StreamReader sr = new StreamReader(SALE_XML))
        {
            listSale = serializer.Deserialize(sr) as List<Sale>;
        }
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale read successfully");
        return listSale.FirstOrDefault(filter);
    }

    public List<Sale> ReadAll(Func<Sale, bool> filter = null)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sales read successfully");
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> listSale;
        using (StreamReader sr = new StreamReader(SALE_XML))
        {
            listSale = serializer.Deserialize(sr) as List<Sale>;
        }
        if (filter != null)
            return listSale.Where(filter).ToList();
        return listSale;
    }

    public void Update(Sale item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.IdSale.ToString());
        Delete(item.IdSale);
        Create(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale updated successful");
    }
}
