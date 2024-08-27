using DesignPatterns.Adapter.Core;
using DesignPatterns.Adapter.UseAdpterPattern;
using System.Text;
using System.Text.Json;

namespace DesignPatterns.Adapter
{
    public class Program
    {
        /*
         * Adapter pattern
           Type: Stuctural 
           Why? to change the object to be compatable with other client such as callig other api or system.
           When? when you need to dail with other old or unchanged systems.
           Example1: the mobile charger 
         */
        public static void Main(string[] args)
        {
            //StartWitoutUsingAdpterPattern();
            StartUsingAdpterPattern();

            Console.ReadKey();
        }
        public async static void StartUsingAdpterPattern()
        {
            /*
             * the PayrolSystemAdapter legathy system use the payitem value with positive or negative
             * and it has no idea about is deduction property.
             * use the Adapter pattern to make a new employee object that can be compatable with PayrolSystemAdapter
             */
            var payrollCalculatorURL = "https://localhost:7050/PayrollCalculator";
            var reader = new EmployeesDataReader();
            var emplyeesList = reader.GetEmployees();
            var client = new HttpClient();
            foreach (var employee in emplyeesList)
            {
                //employee is the new employee change it to be adapted with the legathy system
                var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);
                var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorURL);
                request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");
                var response = await client.SendAsync(request);
                var responseJson = await response.Content.ReadAsStringAsync();
                var salary = decimal.Parse(responseJson);
                Console.WriteLine($"Salary for employee {employee.FullName} as for today = {salary}");
            }
        }
        public async static void StartWitoutUsingAdpterPattern()
        {
            var payrollCalculatorURL = "https://localhost:7050/PayrollCalculator";
            var reader = new EmployeesDataReader();
            var emplyeesList = reader.GetEmployees();
            var client = new HttpClient();
            foreach (var employee in emplyeesList)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorURL);
                request.Content = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
                var response = await client.SendAsync(request);
                var responseJson = await response.Content.ReadAsStringAsync();
                var salary = decimal.Parse(responseJson);
                Console.WriteLine($"Salary for employee {employee.FullName} as for today = {salary}");
            }
        }
    }
}
