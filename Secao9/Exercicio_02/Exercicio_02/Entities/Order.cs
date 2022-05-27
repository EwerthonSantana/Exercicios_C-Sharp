using System;
using System.Collections.Generic;
using Exercicio_02.Entities.Enums;

namespace Exercicio_02.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public override string ToString()
        {
            return Client.Name + " " + Client.BirthDate + " - " + Client.Email;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in OrderItem)
            {
                total += item.SubTotal();
            }
            return total;
        }

    }
}
