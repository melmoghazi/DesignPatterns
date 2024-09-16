using DesignPatterns.Decorator.Core;
using DesignPatterns.Decorator.Decorator;
using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Decorator
{
    internal class Program
    {
        /*
         * 14- Decorator Design Pattern
            In 23 Design Patterns
            Type? Structural
            Why? To update or add new functionality to an object at runtime.
         */

        /*
         * new requirement is to make profiling or to calculator the order time
         */
        static void Main(string[] args)
        {
            StartProcess();
            Console.WriteLine("----------------------------------");
            ProfilingDecoratorProcess();
            Console.WriteLine("----------------------------------");
            ExceptionHandlingDecoratorProcess();
            Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }
        static void StartProcess()
        {
            var order = new Order();
            order.AddLine(1, 1, 1000);
            order.AddLine(2, 1, 1500);
            order.AddLine(3, 1, 2000);

            IOrderProcessor processor = new OrderProcessor();
            processor.Process(order);
        }
        static void ProfilingDecoratorProcess()
        {
            var order = new Order();
            order.AddLine(1, 1, 1000);
            order.AddLine(2, 1, 1500);
            order.AddLine(3, 1, 2000);

            IOrderProcessor processor = new OrderProcessor();
            processor = new OrderProcessorProfilingDecorator(processor);
            processor.Process(order);
        }
        static void ExceptionHandlingDecoratorProcess()
        {
            var order = new Order();
            IOrderProcessor processor = new OrderProcessor();
            processor = new OrderProcessorExceptionalHandlingDecorator(processor);
            processor.Process(order);
        }
    }
}
