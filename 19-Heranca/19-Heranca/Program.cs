using _19_Heranca.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            BusinessAccount account = new(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}