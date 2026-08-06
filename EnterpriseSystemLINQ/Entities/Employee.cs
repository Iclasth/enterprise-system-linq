namespace EnterpriseSystemLINQ.Entities
{
    public class Employee
    {
        private decimal _salary;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary {
            get => _salary;
            set => _salary = value;
        }
        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
