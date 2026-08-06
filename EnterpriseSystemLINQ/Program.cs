using EnterpriseSystemLINQ.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string? path = Console.ReadLine();

List<Employee> employees = new List<Employee>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        if (path == null)
        {
            throw new ArgumentNullException();
        }

        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine().Split(",");
            string name = fields[0];
            string email = fields[1];
            decimal salary = Convert.ToDecimal(fields[2], CultureInfo.InvariantCulture);
            employees.Add(new Employee(name, email, salary));
        }

        Console.Write("Enter salary: ");
        decimal salaryQuery = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Traga o email dos funcionários no qual o salário é maior do que o passado na variável
        var getEmail = employees.Where(e => e.Salary > salaryQuery).OrderBy(e => e.Email).Select(e => e.Email);

        var sum = employees.Where(e => e.Name.ToUpper()[0] == 'M').Sum(e => e.Salary);

        Console.WriteLine($"Email of people whose salary is more than {salaryQuery.ToString("C2")}: ");
        foreach (string item in getEmail)
        {  
            Console.WriteLine(item);   
        }
        Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("C2")}");
    }
}
catch(IOException e)
{
    Console.WriteLine($"An error occurred: {e.Message}");
}