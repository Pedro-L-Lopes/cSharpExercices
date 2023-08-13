using T;
using P;
using System.Globalization;
using Funcionario_log;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = f2.CalcularMetade();
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));



            /* Pessoa pessoa1, pessoa2;

             pessoa1 = new Pessoa();
             pessoa2 = new Pessoa();

             Console.WriteLine("Digite os dados da primeira pessoa: ");
             Console.Write("Nome: ");
             pessoa1.nome = Console.ReadLine();
             Console.Write("Idade: ");
             pessoa1.idade = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite os dados da segunda pessoa: ");
             Console.Write("Nome: ");
             pessoa2.nome = Console.ReadLine();
             Console.Write("Idade: ");
             pessoa2.idade = int.Parse(Console.ReadLine());

             Console.WriteLine($"A primeira foi pessoa {pessoa1.nome} e tem {pessoa1.idade} anos \n A segunda pessoa foi {pessoa2.nome} e tem {pessoa2.idade} anos");
             if(pessoa1.idade > pessoa2.idade)
             {
                 Console.WriteLine($"{pessoa1.nome} com {pessoa1.idade} anos é mais velha");
             }
             else
             {
                 Console.WriteLine($"{pessoa2.nome} com {pessoa2.idade} anos é mais velha");
             }*/


            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");*/

            /*Console.Write("Digite a senha: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Programa finalizado!");*/

            /*Console.Write("Quantos números inteiros você vai digitar ? ");
            int q = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= q; i++)
            {
                Console.Write($"{i}º número: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            Console.WriteLine($"Soma = {soma}");
            }*/

            /* 
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
     
            Console.WriteLine("Entre com as medidas do triangulo x:");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y:");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é do triangulo x");
            }
            else
            {
                Console.WriteLine("Maior área é do triangulo y");
            }*/
        }

        static int Maior(int n1, int n2, int n3)
        {
            int maior;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}