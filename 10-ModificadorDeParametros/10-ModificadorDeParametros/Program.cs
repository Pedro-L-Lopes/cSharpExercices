using _10_ModificadorDeParametros;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;

            Calculadora.Triple(a, out triple);
            Console.WriteLine(triple);

            /*int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);*/

            // int resultado = Calculadora.sum(1, 2, 3, 4, 5, 10, 15);
            //Console.WriteLine(resultado);

        }
    }
}
