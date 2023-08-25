using _24_Exercicio3.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Taxpayer> taxPayers = new List<Taxpayer>();

            Console.Write("Enter de numbers of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i} data");
                Console.Write("Individual or Company (i/c)? ");
                char res = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (res == 'i' || res == 'I')
                {
                    Console.Write("Helth expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOFEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new JuridicalPerson(name, anualIncome, numberOFEmployees));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0; ;
            foreach (Taxpayer t in taxPayers)
            {
                double tax = t.Tax();
                Console.WriteLine($"{t.Name}: R$ {t.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }

            Console.WriteLine($"TOTAL TAXES: R$ {sum.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}