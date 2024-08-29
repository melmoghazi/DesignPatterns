using DesignPatterns.NullObject.Core;
using DesignPatterns.NullObject.Core.DiscountStrategies;

namespace DesignPatterns.NullObject
{
    public class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory customerCategory)
        {
            if (customerCategory == CustomerCategory.Sliver)
            {
                return new SliverCustomerDiscountStrategy();
            }
            else if (customerCategory == CustomerCategory.Gold)
            {
                return new GoldCustomerDiscountStrategy();
            }
            //return null;
            return new NullCustomerDiscountStrategy();
        }
    }
}
