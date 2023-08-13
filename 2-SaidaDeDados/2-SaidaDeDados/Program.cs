using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite separando por espaço: Nome, sexo, idade e altura");

            string[] array = Console.ReadLine().Split(' ');

            string nome = array[0];
            char sexo = char.Parse(array[1]);
            int idade = int.Parse(array[2]);
            float altura = float.Parse(array[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} \n sexo: {sexo} \n idade: {idade} \n altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");


            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0) {
                Console.WriteLine($"{numero} é par");
            }
            else
            {
                Console.WriteLine($"{numero} é impar");
            }
        }


    }

}

