using _9_Array;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = name, Price = price };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }

            double media = soma / n;

            Console.WriteLine("Preço medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/*int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
               sum += vet[i];
            }

            double media = sum / n;

            Console.WriteLine("A media de altura é: " + media.ToString("F2", CultureInfo.InvariantCulture));*/