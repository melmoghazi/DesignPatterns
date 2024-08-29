namespace DesignPatterns.NullObject.Core
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer{ Id=1, Name="Mohammed", CustomerCategory= CustomerCategory.Gold},
                new Customer{ Id=2, Name="Hind", CustomerCategory= CustomerCategory.Sliver},
                new Customer{ Id=3, Name="Shady", CustomerCategory= CustomerCategory.None},
            };
        }
    }
}
