using DesignPatterns.NullObject.Core;
using DesignPatterns.NullObject.Core.DiscountStrategies;

namespace DesignPatterns.NullObject
{
    public class Program
    {
        /*
         * Null Object Design Pattern 
         * Type? behavioural
         * Why? to eliminate null checks
         */
        static void Main(string[] args)
        {
            Start();

            Console.ReadKey();
        }
        static void Start()
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();

            while (true)
            {
                foreach (var cust in customers)
                {
                    Console.WriteLine($"{cust.Id} {cust.Name} {cust.CustomerCategory}");
                }
                Console.Write("Enter Customer Id:");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write("Enter Item Quantity:");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price:");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.First(x => x.Id == customerId);

                ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory()
                    .CreateCustomerDiscountStrategy(customer.CustomerCategory);
                //if (customer.CustomerCategory == CustomerCategory.Sliver)
                //{
                //    customerDiscountStrategy = new SliverCustomerDiscountStrategy();
                //}
                //if (customer.CustomerCategory == CustomerCategory.Gold)
                //{
                //    customerDiscountStrategy = new GoldCustomerDiscountStrategy();
                //}

                InvoiceManager invoiceManager = new InvoiceManager();
                invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

                var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);


                Console.WriteLine($"Invoice create for customer id {customer.Name} with Net Price {invoice.NetPrice} ");
                Console.WriteLine("Press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
