namespace DesignPatterns.Builder
{
    public class Employee
    {
        public Employee(string name, string email, decimal basicSalary)
        {
            Name = name;
            Email = email;
            BasicSalary = basicSalary;
        }

        public string Name { get; }
        public string Email { get; }
        public decimal BasicSalary { get; }
    }
}