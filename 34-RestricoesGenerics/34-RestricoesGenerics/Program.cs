using Course.Entities;
using Course.Services;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(",");
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vet[0], price));
            }

            CalculationService calculationService = new();

            Product p = calculationService.Max(list);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(p);
        }
    }
}
