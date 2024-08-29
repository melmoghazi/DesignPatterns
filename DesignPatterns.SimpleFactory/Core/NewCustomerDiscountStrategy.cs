﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.Core
{
    internal class NewCustomerDiscountStrategy : ICustomerDiscountStrategy  
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
