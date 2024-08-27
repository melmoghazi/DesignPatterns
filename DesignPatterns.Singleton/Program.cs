namespace DesignPatterns.Singleton
{
    internal class Program
    {
        /*
         * Design pattern is an elegant solution to repeating problem.
         * 23 desgin pattern in the book "Design Patterns elements of reusable object-oriented software" by GoF.
         * Desgin Patterns:
         *  1-Creational, creation of the objects.
         *  2-Structural, relationship between objects.
         *  3-Behavioural, interaction or communication between objects.
         * ---------------------------------------------------------------------------------
         * Singleton pattern is a creational pattern.
         * Why? Used to be sure that there is only one instance of a class while the application is running.
         * When? when you have a static data or little change
         * Example1: configuration values, appsettings file. 
         * Example2: lookups.
         * 
         * Implementd example exchange rate between currencies.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            #region without using singlton
            //while (true)
            //{
            //    Console.WriteLine("Enter your base currency");
            //    var baseCurrency = Console.ReadLine();
            //    Console.WriteLine("Enter your targe currency");
            //    var targetCurrency = Console.ReadLine();
            //    Console.WriteLine("Enter the amount");
            //    var amount = decimal.Parse(Console.ReadLine());
            //    CurrencyConverter currencyConverter = new CurrencyConverter();
            //    var result = currencyConverter.Convert(baseCurrency, targetCurrency, amount);
            //    Console.WriteLine($"{amount} {baseCurrency} = {result} {targetCurrency}");
            //    Console.WriteLine("---------------------------------------------------------------");
            //}
            #endregion

            #region using singlton
            while (true)
            {
                //after the first loop it will not take time because the data will be chached in the memory
                //depending on singleton instance.
                Console.WriteLine("Enter your base currency");
                var baseCurrency2 = Console.ReadLine();
                Console.WriteLine("Enter your targe currency");
                var targetCurrency2 = Console.ReadLine();
                Console.WriteLine("Enter the amount");
                var amount2 = decimal.Parse(Console.ReadLine());
                //CurrencyConverterSingleton currencyConverter2 = new CurrencyConverterSingleton();//can not because private constructor
                var result2 = CurrencyConverterSingleton.Instance.Convert(baseCurrency2, targetCurrency2, amount2);
                Console.WriteLine($"{amount2} {baseCurrency2} = {result2} {targetCurrency2}");
                Console.WriteLine("---------------------------------------------------------------");
            }
            #endregion

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
