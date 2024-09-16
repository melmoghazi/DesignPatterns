using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Core
{
    internal class OrderLine
    {
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
