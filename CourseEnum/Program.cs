using CourseEnum.Entities;
using CourseEnum.Entities.Enums;

namespace CourseEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayments
            };
            Console.WriteLine( order);

            // convertendo o tipo enumerado para string
            string txt = order.Status.ToString();
            Console.WriteLine("O status é "+ txt);

            // convertendo string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os); 
        }
    }
}