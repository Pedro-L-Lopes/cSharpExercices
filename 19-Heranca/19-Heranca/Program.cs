using _19_Heranca.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new(1001, "Crebin", 0);
            BusinessAccount bacc = new(1002, "Zezin", 0, 500);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Cleito", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Mario", 0, 0.01);

            // Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}