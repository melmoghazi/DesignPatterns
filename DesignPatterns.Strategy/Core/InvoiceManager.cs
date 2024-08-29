﻿using DesignPatterns.Strategy.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Core
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
