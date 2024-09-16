using DesignPatterns.Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator
{
    internal class OrderProcessorExceptionalHandlingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderProcessorExceptionalHandlingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }
        public void Process(Order order)
        {
            try
            {
                _orderProcessor.Process(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception handling message: {ex.Message}");
            }
        }
    }
}
