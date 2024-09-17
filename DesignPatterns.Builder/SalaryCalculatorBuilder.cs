using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /*
     * create builder class for your class suffix the class name with builder word
     * step 1 create variable foreach parameter
     * step 2 foreach variable create method that return the builder class
     * step 3 create Build method that return SalaryCalculator object
     */
    internal class SalaryCalculatorBuilder
    {
        private int _taxPercentage = 0;
        private decimal _bounsPercentage = 0;
        private decimal _educationPackage = 0;
        private decimal _transportation = 0;
        private bool _sendPayslipToEmployee = true;
        private bool _postResultsToGL = true;

        public SalaryCalculatorBuilder WithTaxPercentage(int taxPercentage)
        {
            LogMessage("WithTaxPercentage");
            _taxPercentage = taxPercentage;
            return this;
        }
        public SalaryCalculatorBuilder WithBounsPercentage(decimal bounsPercentage)
        {
            LogMessage("WithBounsPercentage");
            _bounsPercentage = bounsPercentage;
            return this;
        }
        public SalaryCalculatorBuilder WithEducationPackage(decimal educationPackage)
        {
            LogMessage("WithEducationPackage");
            _educationPackage = educationPackage;
            return this;
        }
        public SalaryCalculatorBuilder WithTransportation(decimal transportation)
        {
            LogMessage("WithTransportation");
            _transportation = transportation;
            return this;
        }
        public SalaryCalculatorBuilder SendPayslipToEmployee(bool sendPayslipToEmployee)
        {
            LogMessage("SendPayslipToEmployee");
            _sendPayslipToEmployee = sendPayslipToEmployee;
            return this;
        }
        public SalaryCalculatorBuilder PostResultsToGL(bool postResultsToGL)
        {
            LogMessage("PostResultsToGL");
            _postResultsToGL = postResultsToGL;
            return this;
        }
        private void LogMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public SalaryCalculator Build()
        {
            return new SalaryCalculator(_taxPercentage, _bounsPercentage, _educationPackage, _transportation,
                _sendPayslipToEmployee, _postResultsToGL);
        }
    }
}
