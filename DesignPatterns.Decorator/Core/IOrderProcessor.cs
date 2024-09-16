using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Core
{
    internal interface IOrderProcessor
    {
        void Process(Order order);
    }
}
