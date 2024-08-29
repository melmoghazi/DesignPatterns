using DesignPatterns.Strategy.Core;
using DesignPatterns.Strategy.Core.DiscountStrategies;

namespace DesignPatterns.Strategy
{
    internal class Program
    {
        /*
         * Strategy Pattern or named policy pattern
           Type? Behavioural
           Why? used to select function algorithm at runtime based on some input parameters.
 	            or to determine a way of execution when some thing happen.
           Example1: string comparison (case sensitive, case insensitive)
           Exmaple2: saving file in different format (pdf, text, doc)
           Example3: payment methods (fawry, paypal)
           Our example: customer discounts.
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
                Console.WriteLine("Customer List: [1] Mohammed Ali [2] Hind Ali");
                Console.Write("Enter Customer Id:");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write("Enter Item Quantity:");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price:");
                var unitPrice = double.Parse(Console.ReadLine());
 
                var customer= customers.First(x => x.Id == customerId);
               
                ICustomerDiscountStrategy customerDiscountStrategy = null;
                if (customer.CustomerCategory == CustomerCategory.Sliver)
                {
                    customerDiscountStrategy=new SliverCustomerDiscountStrategy();
                }
                if (customer.CustomerCategory == CustomerCategory.Gold)
                {
                    customerDiscountStrategy = new GoldCustomerDiscountStrategy();
                }

                InvoiceManager invoiceManager=new InvoiceManager();
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
