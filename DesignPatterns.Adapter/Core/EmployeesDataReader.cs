using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Core
{
    public class EmployeesDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee> {
                new Employee
                {
                     FirstName = "Mohammed",
                     LastName = "Ali",
                     PayItems=new List<PayItem>
                     {
                          new PayItem{ Name="Basic Salary", Value = 1000},
                          new PayItem{ Name="Transportation", Value = 250},
                          //new PayItem{ Name="Medical Insurance", Value = 150},
                          new PayItem{ Name="Medical Insurance", Value = 150, IsDedection = true},
                     }
                },
                new Employee
                {
                     FirstName = "Hind",
                     LastName = "Ali",
                     PayItems=new List<PayItem>
                     {
                          new PayItem{ Name="Basic Salary", Value = 1000},
                          new PayItem{ Name="Transportation", Value = 250},
                          new PayItem{ Name="Medical Insurance", Value = -150},
                     }
                }
            };
        }
    }
}
