
using DalApi;
using DO;
using System;
using System.Reflection;
using Tools;

namespace DalTest
{
    public delegate void CreateUpdateDel();
    internal class Program
    {
        private static readonly IDal s_dal = DalApi.Factory.Get;
        public static int printMenu()
        {
            Console.WriteLine("Product press 1");
            Console.WriteLine("Sale press 2");
            Console.WriteLine("Customer press 3");
            Console.WriteLine("Delete logs press 4");
            Console.WriteLine("end press 0");
            int select;
            if (!(int.TryParse(Console.ReadLine(), out select)))
            {
                select = -1;
            }
            return select;
        }

        public static int printSubMenu(string item)
        {
            Console.WriteLine("end press 0");
            Console.WriteLine("To Add " + item + " press 1");
            Console.WriteLine("To read " + item + " press 2");
            Console.WriteLine("To read all " + item + " press 3");
            Console.WriteLine("To update " + item + " press 4");
            Console.WriteLine("To delete " + item + " press 5");
            int select;
            if (!(int.TryParse(Console.ReadLine(), out select)))
            {
                select = -1;
            }
            return select;
        }

        public static void SubMenu<T>(string item, ICrud<T> crud, CreateUpdateDel createDel, CreateUpdateDel updateDel)
        {
            int select = printSubMenu(item);
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        createDel();
                        break;
                    case 2:
                        Read(crud);
                        break;
                    case 3:
                        ReadAll(crud);
                        break;
                    case 4:
                        updateDel();
                        break;
                    case 5:
                        Delete(crud);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                select = printSubMenu(item);
            }
        }

        private static void UpdateProduct()
        {
            Console.WriteLine("press code of product");
            int code;
            if (!(int.TryParse(Console.ReadLine(), out code))) code = -1;
            Console.WriteLine(s_dal.Product.Read(code));
            try
            {
              
                Product product = AskProducts(code);
                s_dal.Product.Update(product);
            }
            catch (Exception e)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! The code{code} is wrong");

            }

        }
        private static void AddProducts()
        {
            Product product = AskProducts();
            int code = s_dal.Product.Create(product);
            product = product with { IdProduct = code };
            Console.WriteLine("create");
            Console.WriteLine(product);

        }
        private static Product AskProducts(int code = 0)
        {

            int IdProduct;
            string NameProduct;
            Categories CategoryProduct;
            double priceProduct;
            int amountProduct;
            int select;

            Console.WriteLine("press ProductName");
            NameProduct = Console.ReadLine();
            Console.WriteLine("category:  Necklaces press1, Bracelets press2, Rings press 3, Earrings press 4, Clocks press 5, sets press 6");
            if (!(int.TryParse(Console.ReadLine(), out select))) select = -1;
            switch (select)
            {
                case 1:
                    CategoryProduct = Categories.  FaceMakeup;
                    break;
                case 2:
                    CategoryProduct = Categories.EyeMakeup;
                    break;
                case 3:
                    CategoryProduct = Categories.LipMakeup;
                    break;
                case 4:
                    CategoryProduct = Categories.Skincare;
                    break;
                case 5:
                    CategoryProduct = Categories.MakeupToolsAndAccessories;
                    break;
                default:
                    CategoryProduct = Categories.EyeMakeup;
                    break;
            }
            Console.WriteLine("press price");
            if (!(double.TryParse(Console.ReadLine(), out priceProduct))) priceProduct = -1;
            Console.WriteLine("press quantityStock ");
            if (!(int.TryParse(Console.ReadLine(), out amountProduct))) amountProduct = -1;
            Product product = new Product(code, NameProduct, CategoryProduct, priceProduct, amountProduct);
            return product;
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("press code of Customer");
            int code;
            if (!(int.TryParse(Console.ReadLine(), out code))) code = -1;
           
            try
            {
                Console.WriteLine(s_dal.Customer.Read(code));
                Customer customer = AskCustomer(code);
                s_dal.Customer.Update(customer);
            }
            catch (Exception e) {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! The code{code} is wrong ,{e.Message}!");
            }

        }
        private static void AddCustomer()
        {
            Customer customer = AskCustomer();
            int code = s_dal.Customer.Create(customer);
            customer = customer with { IdCustomer = code };
            Console.WriteLine("create");
            Console.WriteLine(customer);
        }
        private static Customer AskCustomer(int code = 0)
        {
            int Id;
            string Name;
            string Phone;
            string Address;
            Console.WriteLine("press id");
            if (!(int.TryParse(Console.ReadLine(), out Id))) Id = -1;
            Console.WriteLine("press phone");
            Phone = Console.ReadLine();
            Console.WriteLine("press customer name");
            Name = Console.ReadLine();
            Console.WriteLine("press customer address");
            Address = Console.ReadLine();
            Customer customer = new Customer(Id, Name, Address, Phone);
            return customer;
        }

        private static void UpdateSale()
        {

            Console.WriteLine("press code of Sale");
            int code;
            if (!(int.TryParse(Console.ReadLine(), out code))) code = -1;
            try
            {
                Console.WriteLine(s_dal.Sale.Read(code));
                Sale sale = AskSale(code);
                s_dal.Sale.Update(sale);
            }
            catch (Exception e) {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! The code{code} is wrong ,{e.Message}!");
            }

        }
        private static void AddSale()
        {
            Sale sale = AskSale();
            int code = s_dal.Sale.Create(sale);
            sale = sale with { IdSale = code };
            Console.WriteLine("create");
            Console.WriteLine(sale);
        }
        private static Sale AskSale(int code = 0)
        {
            int IdSale;
            int NumProduct;
            int AmountForSale;
            double PriceSale;
            bool IsClub;
            DateTime DateStartSale;
            DateTime DateFinishSale;
            int day;
            int select;
            Console.WriteLine("press ProductId");
            if (!(int.TryParse(Console.ReadLine(), out NumProduct))) NumProduct = -1;
            Console.WriteLine("press RequiredItems");
            if (!(int.TryParse(Console.ReadLine(), out AmountForSale))) AmountForSale = -1;
            Console.WriteLine("press TotalPrice");
            if (!(double.TryParse(Console.ReadLine(), out PriceSale))) PriceSale = -1;
            Console.WriteLine("IsCustomersClub? 0/1");
            select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    IsClub = true;
                    break;
                case 1:
                    IsClub = false;
                    break;
                default:
                    IsClub = false;
                    break;
            }
            Console.WriteLine("how many days fron today the sale begin");
            if (!int.TryParse(Console.ReadLine(), out day)) day = 0;
            DateStartSale = DateTime.Now.AddDays(day);
            Console.WriteLine("how many days fron the begining the sale finish");
            if (!int.TryParse(Console.ReadLine(), out day)) day = 0;
            DateFinishSale = DateStartSale.AddDays(day);
            Sale s = new Sale(0, NumProduct, AmountForSale, PriceSale, IsClub, DateStartSale, DateFinishSale);
            return s;
        }

        private static void Read<T>(ICrud<T> crud)
        {
            Console.WriteLine("enter code");
            int code;
            if (!(int.TryParse(Console.ReadLine(), out code))) code = -1;
            try
            {
                
                Console.WriteLine(crud.Read(code));
            }
            catch (Exception e)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! The code{code} is wrong ,{e.Message}!");
            }
        }
        private static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        private static void Delete<T>(ICrud<T> crud)
        {
            Console.WriteLine("enter code");
            int code;
            if (!(int.TryParse(Console.ReadLine(), out code))) code = -1;
            try
            {
                crud.Delete(code);
            }
            catch (Exception e)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! The code{code} is wrong ,{e.Message}!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("You went to initialize data?");
            Console.WriteLine("no press 0");
            Console.WriteLine("yes press 1");
            int select =int.Parse(Console.ReadLine());
            if(select!=0)
                Initialization.Initialize();
            select = printMenu();
            try
            {
                while (select != 0)
                {
                    switch (select)
                    {
                        case 1:
                            SubMenu("product", s_dal.Product, AddProducts, UpdateProduct);
                            break;
                        case 2:
                            SubMenu("sale", s_dal.Sale, AddSale, UpdateSale);
                            break;
                        case 3:
                            SubMenu("customer", s_dal.Customer, AddCustomer, UpdateCustomer);
                            break;
                        case 4:
                            LogManager.DeleteLog();
                            break;
                        default:
                            Console.WriteLine("error, press again");
                            break;
                    }
                    select = printMenu();
                }
            }
            catch (Exception e)
            {
                LogManager.WriteIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, $"Error! {e.Message}");
            }
        }

    }
}
