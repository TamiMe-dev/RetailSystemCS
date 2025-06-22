
using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace DAL;


internal class ImplementationSale : ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, item.IdSale.ToString());
        Sale p = item with { IdSale = DataSource.Config.SaleCode };
        DataSource.Sales.Add(p);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale created successful");
        return p.IdSale;
    }

    public Sale? Read(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+id);
        foreach (Sale item in DataSource.Sales)
        {
            if (item.IdSale == id)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale read successfully");
                return item;
            }
        }
        throw new DalIdNotExistsException("not found!");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sale read successfully");
        Sale sale = DataSource.Sales.FirstOrDefault(c => filter(c));
        if (sale == null)
            throw new DalIdNotExistsException("The sale is not exists");
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sale read successfully");
        return sale;
    }

    public List<Sale> ReadAll(Func<Sale, bool> filter = null)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sales read successfully");
        if (filter == null)
        {
            return new List<Sale>(DataSource.Sales);
        }
        else
        {
            return DataSource.Sales.Where(filter).ToList();
        }
    }

    public void Update(Sale item)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:"+item.IdSale.ToString());
        Delete(item.IdSale);
        DataSource.Sales.Add(item);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale updated successful");
    }

    public void Delete(int id)
    {
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name,"id:"+id);
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale deleted successful");
    }
}
