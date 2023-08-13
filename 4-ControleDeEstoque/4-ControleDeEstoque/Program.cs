using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("1º nota: ");
            aluno.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("2º nota: ");
            aluno.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("3º nota: ");
            aluno.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota final: " + aluno.ResultadoFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltaram {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} pontos ");

            }



        }
    }

    /* Funcionario funcionario = new();

            Console.WriteLine("Insira os dados do funcionário: ");
            Console.WriteLine();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {funcionario.Nome}, R$ {funcionario.SalarioBruto().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            funcionario.Porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {funcionario.Nome}, R$ {funcionario.AumentoSalario().ToString("F2", CultureInfo.InvariantCulture)}");*/



}/*
            Produto produto = new Produto();

            Console.WriteLine("Coloque os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Números de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + produto);

            Console.WriteLine();
            Console.Write("Números de produtos a serem removidos: ");
            int menosQte = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(menosQte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + produto);*/

