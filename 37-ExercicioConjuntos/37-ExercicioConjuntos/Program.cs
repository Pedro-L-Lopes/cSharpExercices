using _37_ExercicioConjuntos.Entities;
using System.Threading.Channels;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new();

            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try
            {
                using StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord(name, instant));
                }
                Console.WriteLine("Total users: " + set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}