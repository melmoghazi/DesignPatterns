using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class SalaryCalculator
    {
        public SalaryCalculator(int taxPercentage = 0,
                                decimal bounsPercentage = 0,
                                decimal educationPackage = 0,
                                decimal transportation = 0,
                                bool sendPayslipToEmployee = true,
                                bool postResultsToGL = true)
        {
            TaxPercentage = taxPercentage;
            BounsPercentage = bounsPercentage;
            EducationPackage = educationPackage;
            Transportation = transportation;
            SendPayslipToEmployee = sendPayslipToEmployee;
            PostResultsToGL = postResultsToGL;
        }

        public int TaxPercentage { get; }
        public decimal BounsPercentage { get; }
        public decimal EducationPackage { get; }
        public decimal Transportation { get; }
        public bool SendPayslipToEmployee { get; }
        public bool PostResultsToGL { get; }

        public decimal Calculate(Employee employee)
        {
            var bonus = employee.BasicSalary * BounsPercentage / 100;
            var taxes = employee.BasicSalary * TaxPercentage / 100;
            var salary = employee.BasicSalary * EducationPackage * Transportation * bonus * taxes;

            Console.ForegroundColor = ConsoleColor.Green;
            if (SendPayslipToEmployee)
            {
                Console.WriteLine($"SendPayslipToEmployee {employee.Name}" );
            }
            if (PostResultsToGL)
            {
                Console.WriteLine($"PostResultsToGL {salary}");

            }
            Console.ForegroundColor = ConsoleColor.White;

            return salary;
        }
    }
}
