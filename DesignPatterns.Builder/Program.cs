namespace DesignPatterns.Builder
{
    internal class Program
    {
        /*
         * 13-Builder Design Pattern
            Type? Creational
            Why? facilitate create the complex objects تسهيل إنشاء الكائنات المعقدة
         */
        static void Main(string[] args)
        {
            SalaryCalculatorBuilder builder = new SalaryCalculatorBuilder();
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add 20% bouns");
                Console.WriteLine("2. Deduct 10% taxes");
                Console.WriteLine("3. Add 2000 education package");
                Console.WriteLine("4. Add 1000 transportation");
                Console.WriteLine("5. Send payslip to employee");
                Console.WriteLine("6. Add 1000 transportation");
                Console.WriteLine("0. Build");

                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                    builder.WithBounsPercentage(20);
                else if (option == 2)
                    builder.WithTaxPercentage(10);
                else if (option == 3)
                    builder.WithEducationPackage(2000);
                else if (option == 4)
                    builder.WithTransportation(1000);
                else if (option == 5)
                    builder.SendPayslipToEmployee(true);
                else if (option == 6)
                    builder.PostResultsToGL(true);
                else if (option == 0)
                {
                    var calculatorBuilder = builder.Build();
                    Employee employee = new Employee("Mohammed", "example@example.com", 1000);
                    var salary = calculatorBuilder.Calculate(employee);
                    Console.ReadKey();
                    builder = new SalaryCalculatorBuilder();
                }
            }
        }
    }
}
