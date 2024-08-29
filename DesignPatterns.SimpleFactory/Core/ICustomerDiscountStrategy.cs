using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.Core
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
