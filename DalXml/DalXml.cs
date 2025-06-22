using DalApi;
using System.Xml.Linq;

namespace Dal
{
    public sealed class DalXml : IDal
    {
        private static readonly DalXml instance;
        public static DalXml Instance
        {
            get
            {
                if(instance!=null)
                    return instance;
                return new DalXml();
            }
        }

        private DalXml()
        {
        }
        public ICustomer Customer => new CustomersImplemention();
        public IProduct Product => new ProductsImplemention();
        public ISale Sale => new SalesImplemention();
    }
}
