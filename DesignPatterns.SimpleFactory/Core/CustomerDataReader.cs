using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.Core
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer{ Id=1, Name="Mohammed", CustomerCategory= CustomerCategory.Gold},
                new Customer{ Id=2, Name="Hind", CustomerCategory= CustomerCategory.Sliver}
            };
        }
    }
}
