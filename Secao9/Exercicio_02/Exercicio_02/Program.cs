using System;
using System.Globalization;
using Exercicio_02.Entities.Enums;
using Exercicio_02.Entities;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime atualTime = DateTime.Now;

            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime formatedBirthDate = birthDate.Date;

            Client client = new(name, email, formatedBirthDate);

            Console.WriteLine();
            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Quantos items vão ser adicionados ao pedido? ");
            int amountOrder = int.Parse(Console.ReadLine());

            Order order = new(atualTime.Date, orderStatus, client);

            for (int i = 1; i <= amountOrder; i++)
            {
                Console.WriteLine($"Entre com os dados do item #{i}:");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int amountItem = int.Parse(Console.ReadLine());
                Product product = new(productName, productPrice);
                OrderItem orderItem = new(amountItem, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("Resumo do pedido:");
            Console.WriteLine("Momento do pedido: " + order.Moment.Date);
            Console.WriteLine("Estado do pedido: " + order.Status);
            Console.WriteLine($"Cliente: {order}");
            Console.WriteLine("Items do pedido: ");
            foreach (OrderItem item in order.OrderItem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Preço total: $" + order.Total().ToString("F2"));

        }
    }
}
