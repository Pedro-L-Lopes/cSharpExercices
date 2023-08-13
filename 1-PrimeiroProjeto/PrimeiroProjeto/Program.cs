using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool completo = false;

            Console.WriteLine(completo);

            // char só aceita um caractere e é colocado com aspas simples
            char genero = 'F';

            Console.WriteLine(genero);

            if (completo == true)
            {
                Console.WriteLine("Está completo");
            }
            else
            {
                Console.WriteLine("Por favor aguarde...");
            }

            float flutuante = 5.1f;

            Console.WriteLine(flutuante);


            if (flutuante > 5)
            {
                Console.WriteLine(flutuante * 0.10 + flutuante);
            }
            else
            {
                Console.WriteLine("Está livre de imposto.");
            }

            // string precisam de aspas duplas
            string nome = "Crebin";

            Console.WriteLine(nome);

            // Aceita qualquer tipo
            object objeto = "testando";

            Console.WriteLine(objeto);

            Console.WriteLine("--------------------------------");

            float testeCasa = 10.4f;

            Console.WriteLine(testeCasa.ToString("F2"));
            Console.WriteLine(testeCasa.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------");

            string nome2 = "Crebin";
            double saldo = 17.25487;
            int idade = 21;


            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R$ {2:F2} reais", nome2, idade, saldo);

            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a R$ {saldo:F2} reais");

            Console.WriteLine("-----------Exercicio aula 18-----------");

            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade3 = 30;
            int codigo = 5290;
            char genero2 = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}\n");

            Console.WriteLine($"Registro: {idade3} anos de idade, codigo {codigo} e genero {genero2}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separar o decimal invariante culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));


            Console.WriteLine("----------Aula 20----------");

            double a;
            float b;
            int c;

            // Pode jogar o conteudo de A que tem 8 bytes em B que tem 4 bytes (ira perder informações)
            a = 5.1;
            b = (float)a; // Falando que tudo bem colocar o a que é float em uma variavel float
            c = (int)a;


            Console.WriteLine(b);
            Console.WriteLine(c);


            int d = 5;
            int e = 2;

            double resutado = (double)d / e;

            Console.WriteLine(resutado);

            Console.WriteLine("---------Aula 21---------");

            float n4 = 10f / 8;

            Console.WriteLine(n4);

            // Formula de baskara
            double aa = 1.0, bb = -3.0, cc = -4.0; // Iniciando

            double delta = bb * bb - 4.0 * aa * cc;
            double delta2 = Math.Pow(bb, 2.0) - 4.0 * aa * cc; // Usando Math para calcaular a pontenciação

            double x1 = (-bb + Math.Sqrt(delta)) / (2.0 * aa);

            Console.WriteLine(delta);
            Console.WriteLine(delta2);


            Console.WriteLine(x1);





        }
    }

}
