namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especify the data source
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Define the qury expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
