using _15_Enumerações.Entities;
using _15_Enumerações.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Order order = new()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}