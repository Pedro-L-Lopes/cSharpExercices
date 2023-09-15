namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> list = new() { 0, 15, 2, 32, 4, 5, 6, 36, 8, 9, 25};
            SortedSet<int> listb = new() { 5, 6, 7, 8, 9, 10};

            PrintColection(list);
            PrintColection(listb);

            // Union
            SortedSet<int> c = new(list);
            c.UnionWith(listb);
            PrintColection(c);

            // Intersection
            SortedSet<int> d = new(list);
            d.Intersect(list);
            PrintColection(d);

            // Diferrence
            SortedSet<int> e = new(list);
            e.ExceptWith(listb);
            PrintColection(e);

            /* HashSet<string> teste = new HashSet<string>();

             teste.Add("Teste1");
             teste.Add("Teste2");
             teste.Add("Teste3");

             Console.WriteLine(teste.Contains("Teste1"));  

             foreach (var test in teste)
             {
                 Console.WriteLine(test);
             }*/
        }

        static void PrintColection<T>(IEnumerable<T> colection)
        {
            foreach (T item in colection)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();
        }
    }
}