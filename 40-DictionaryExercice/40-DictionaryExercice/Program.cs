namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try
            {
                using StreamReader sr = new StreamReader(path);

                Dictionary<string, int> dictionary = new();

                while (!sr.EndOfStream)
                {
                    string[] votingRecord = sr.ReadLine().Split(',');
                    string cadidate = votingRecord[0];
                    int votes = int.Parse(votingRecord[1]);

                    if (dictionary.ContainsKey(cadidate))
                    {
                        dictionary[cadidate] += votes;
                    }
                    else
                    {
                        dictionary[cadidate] = votes;
                    }
                }

                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}