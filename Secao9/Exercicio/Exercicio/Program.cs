using System;
using Exercicio.Entities;
using Exercicio.Entities.Enums;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new(1, DateTime.Now, OrderStatus.PendingPayment);



            Console.WriteLine(order);
        }
    }
}
