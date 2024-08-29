namespace DesignPatterns.NullObject.Core.DiscountStrategies
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
