using Course.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500, 400));
            accounts.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0;
            foreach (Account account in accounts)
            {
                sum += account.Balance;
            }

            Console.WriteLine(sum);

            foreach (Account account in accounts)
            {
                account.Withdraw(10);
            }

            foreach (Account account in accounts)
            {
                Console.WriteLine(account.Balance);
            }
        }
    }
}
