using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Core
{
    public class PayItem
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsDedection { get; set; } //new properity to know if the value positive or negative
    }
}
