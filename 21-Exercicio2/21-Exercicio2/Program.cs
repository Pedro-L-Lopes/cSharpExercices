﻿using _21_Exercicio2.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char res = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (res == 'i' || res == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (res == 'u' || res == 'U')
                {
                    Console.Write("Manufacture date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Price tags");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}