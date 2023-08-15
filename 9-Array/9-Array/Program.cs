using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

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

            Console.WriteLine("A media de altura é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}