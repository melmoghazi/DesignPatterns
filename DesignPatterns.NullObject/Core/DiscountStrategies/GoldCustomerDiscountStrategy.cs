namespace DesignPatterns.NullObject.Core.DiscountStrategies
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.10 : 0;
        }
    }
}
