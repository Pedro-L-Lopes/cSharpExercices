﻿using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            string nome = Console.ReadLine();
            p.Nome = nome;

            Console.WriteLine(p.Nome);

            Console.ReadKey();
        }
    }
}