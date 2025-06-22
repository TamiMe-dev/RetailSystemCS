using BlApi;
using BO;
using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        static void Main(string[] args)
        {
            int select = 1;
            while (select != 0)
            {
                Console.WriteLine("Enter your customer ID or 0");
                int customerId = int.Parse(Console.ReadLine());
                Order order = new Order(customerId != 0 && s_bl.Customer.IsCustomerExist(customerId),new List<ProductInOrder>(), customerId);
                int toContinue = 1;
                while (toContinue!=0)
                {
                    Console.WriteLine("Enter product code: ");
                    int productId = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount: ");
                    int amount = int.Parse(Console.ReadLine());
                    try
                    {
                        List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, productId, amount);
                        Console.WriteLine("Product added successfully");
                        Console.WriteLine("Sales applied:");
                        if (sales.Count > 0)
                        {
                            foreach (SaleInProduct sale in sales)
                            {
                                Console.WriteLine($"Sale: {sale.SaleId}: {sale.AmountForSale} units for {sale.Price}");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }

                    Console.WriteLine("Add another product?");
                    Console.WriteLine("press 1 to continue");
                    Console.WriteLine("press 0 to exit");
                    toContinue = int.Parse(Console.ReadLine());
                }
                s_bl.Order.DoOrder(order);
                Console.WriteLine($"Order completed! Final price: {order.TotalPrice}");
                Console.WriteLine("Do you want to place another order?");
                Console.WriteLine("press 1 to continue");
                Console.WriteLine("press 0 to exit");
                select = int.Parse(Console.ReadLine());

            }

        
        
        }
    }
}