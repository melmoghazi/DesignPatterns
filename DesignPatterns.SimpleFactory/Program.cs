using DesignPatterns.SimpleFactory.Core;

namespace DesignPatterns.SimpleFactory
{
    internal class Program
    {
        /*
         * Simple Factory Design Pattern
         * Type? Creational
         * Why? to make one place resposible of creating an instance of a related classes.
         * (DRY) Do not Repeat Yourself or Your code. 
         * Encapsulate what varies (الاشياء التى تتغير كثيرا تكون فى مكان واحد)
         * The best benifit is the code reusability and centeralization.
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

                var customer = customers.First(x => x.Id == customerId);

                ICustomerDiscountStrategy customerDiscountStrategy =new CustomerDiscountStrategyFactory()
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
