using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta;

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial ? (s/n): ");
            char res = char.Parse(Console.ReadLine());

            if (res == 's' || res == 'S')
            {
                Console.Write("Valor do deposito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new(nome, numero, deposito);
            }
            else
            {
                conta = new(nome, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);




            Console.WriteLine();

            Console.Write("Adicionar Saldo: R$");
            double saldo = double.Parse(Console.ReadLine());
            conta.AdicionarSaldo(saldo);
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Retirar dinheiro: R$");
            saldo = double.Parse(Console.ReadLine());
            conta.RemoverSaldo(saldo);
            Console.WriteLine(conta);



        }
    }
}
