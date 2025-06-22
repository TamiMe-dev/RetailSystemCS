using BlApi;
using static BO.Tools;

namespace BlImplementation;

internal class ImplementationSale:ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
            return _dal.Sale.Create(item.ConversBoSaleToDoSale());
        }
        catch(Exception e) {

            throw new Exception();
        }
       
    }

    public void Delete(int id)
    {
        try
        {
             _dal.Sale.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).ConversDoSaleToBoSale();
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(s => filter(s.ConversDoSaleToBoSale())).ConversDoSaleToBoSale();


        }
        catch(Exception e)
        {
            throw new Exception();
        }
    }

    public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter != null)
                return _dal.Sale.ReadAll(s => filter(s.ConversDoSaleToBoSale())).Select(s=>s.ConversDoSaleToBoSale()).ToList();
            return _dal.Sale.ReadAll().Select(s => s.ConversDoSaleToBoSale()).ToList();


        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
           _dal.Sale.Update(item.ConversBoSaleToDoSale());
        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }
}
