using _26_ExercicioTryCatch.Entities;
using _26_ExercicioTryCatch.Entities.Exceptions;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: R$ ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: R$ ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdrawn: ");
                double witthdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(witthdraw);

                Console.Write("New balance: R$ " + account.Balance);


            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdrawn error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, something went wrong, please try again later.  " + e.Message);
            }


        }
    }
}