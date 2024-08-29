using DesignPatterns.SimpleFactory.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
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
            return null;
        }
    }
}
