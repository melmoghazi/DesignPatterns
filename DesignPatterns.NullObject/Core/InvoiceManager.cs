using DesignPatterns.NullObject.Core.DiscountStrategies;

namespace DesignPatterns.NullObject.Core
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _CustomerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy customerDiscountStrategy)
        {
            _CustomerDiscountStrategy = customerDiscountStrategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                {
                    new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
                }
            };
            invoice.DiscountPercentage = _CustomerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
