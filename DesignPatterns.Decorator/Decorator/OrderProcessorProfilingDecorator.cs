using DesignPatterns.Decorator.Core;
using System.Diagnostics;

namespace DesignPatterns.Decorator.Decorator
{
    internal class OrderProcessorProfilingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderProcessorProfilingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }

        public void Process(Order order)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            _orderProcessor.Process(order);
            stopWatch.Stop();
            Console.WriteLine($"Order took {stopWatch.Elapsed.TotalSeconds} to be processed.");

        }
    }
}
