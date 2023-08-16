namespace Listas
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

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
            }

        }
    }

}
