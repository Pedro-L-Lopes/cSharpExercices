using _19_Heranca.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account acc1 = new(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}