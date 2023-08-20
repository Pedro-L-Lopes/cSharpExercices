using _18_EnumFinal.Entities;
using _18_EnumFinal.Entities.Enums;
using System.Globalization;

namespace EnumFinal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new(name, email, birthDate);
            Order order = new(DateTime.Now, orderStatus, client);

            Console.WriteLine();

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new(productName, productPrice);

                Console.Write("quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem item = new(productQuantity, productPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine(order);

        }
    }
}