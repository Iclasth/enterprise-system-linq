using EnterpriseSystemLINQ.Entities;
using System.Globalization;

Console.WriteLine("Welcome to TechSolutions website!");
Console.WriteLine("Here you can check employees informations, stored in files, if you're allowed (need to be an admin)");
Console.WriteLine();

int tries = 5;

Console.WriteLine("Login: ");
Console.Write("Enter your email: ");
string? loginEmail = Console.ReadLine();

Console.Write("Enter Password: ");
string? loginPassword = Console.ReadLine();


if (loginEmail == "admin123@gmail.com" && loginPassword == "Admin1234")
{
    Console.WriteLine("-----------------------------------------------");
    Console.Write("Do you wanna access employees info (y/another key)? ");

    char key = Console.ReadKey().KeyChar;
    Console.WriteLine();

    while (key == 'y')
    {
        Console.Clear();
        Console.Write("Enter full file path: ");
        string? path = Console.ReadLine();

        List<Employee> employees = new List<Employee>();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                

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
                Console.WriteLine();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }

        Console.Write("Do you wanna access others employees info (y/another key)? ");

        key = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (key != 'y') return;
        
    }
    
}
else
{
    Console.WriteLine("Wrong email or password. ");
    Console.WriteLine();
    while (tries > 0)
    {
        Console.Write("Enter your email: ");
        loginEmail = Console.ReadLine();

        Console.Write("Enter Password: ");
        loginPassword = Console.ReadLine();
        tries --;
    }
}