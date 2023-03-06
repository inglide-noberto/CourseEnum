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
        }
    }
}