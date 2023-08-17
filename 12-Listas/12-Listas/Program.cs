using System.Globalization;

namespace Listas
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionario serão regsitrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionario {i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Id do funcionario que tera um acrescimo no salario: ");
            int procurandoId = int.Parse(Console.ReadLine());

            Funcionario funcionario = list.Find(x => x.Id == procurandoId);

            if (funcionario != null)
            {
                Console.Write("Porcentagem em que o salario será aumentado: ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não encontrado!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista atualizada de funcionarios: ");
            foreach (Funcionario func in list)
            {
                Console.WriteLine(func);
            }

        }
    }

}

/*List<string> list = new List<string>();

            list.Add("Crebão");
            list.Add("Zezin");
            list.Add("Crebin");
            list.Add("Adalberto");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Tamanho da lista: " + list.Count);
            // Eu quero que o objeto X tal que X na posição zero seja igual a A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Last C: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'Z');
            Console.WriteLine("Posição do primeiro que comaça com Z: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Posição do primeiro que comaça com Z: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.Remove("Adalberto");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.RemoveRange(0, 2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }*/
