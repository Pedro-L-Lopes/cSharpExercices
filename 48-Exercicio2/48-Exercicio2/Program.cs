using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                List<Employee> list = new();

                using StreamReader sr = new(path);
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(',');
                    string name = data[0];
                    string email = data[1];
                    double salary = double.Parse(data[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }

                Console.WriteLine();

                Console.Write("Email of people whose salary is more than: ");
                double salaryMt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var emails = list.Where(p => p.Salary > salaryMt).OrderBy(p => p.Email);
                foreach (Employee emp in emails)
                {
                    Console.WriteLine(emp.Email);
                }

                Console.WriteLine();

                var sumSalarys = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalarys.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}