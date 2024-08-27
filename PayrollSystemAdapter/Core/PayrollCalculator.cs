
using System.Diagnostics;

namespace PayrollSystemAdapter.Core
{
    public class PayrollCalculator
    {
        internal object? Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating salary for employee {employee.FullName}");
            if (employee == null)
                return 0;
            if (employee.PayItems?.Any() == false)
                return 0;
            var monthTotal = employee.PayItems.Sum(p => p.Value);
            return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) *
                DateTime.Today.Day, 2);
        }
    }
}
