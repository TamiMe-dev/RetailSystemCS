using DO;


namespace DAL;

internal static class DataSource
{
    internal static List <Product?> Products =new List<Product?> ();

    internal static List<Customer?> Customers = new List<Customer?>();

    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config
    {
        internal const int ProductMinCode = 100;
        internal const int SaleMinCode =100 ;
        private static int productIndex = ProductMinCode;
        private static int saleIndex = SaleMinCode;

        public static int ProductCode
        {
            get
            {
                return productIndex++;
            }
        }
        public static int SaleCode
        {
            get
            {
                return saleIndex += 1;
            }
        }
    }
}
 

