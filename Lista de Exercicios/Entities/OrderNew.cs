using System;
using System.Collections.Generic;
using System.Text;
using Lista_de_Exercicios.Entities.Enums;

namespace Lista_de_Exercicios.Entities
{
    class OrderNew
    {
        public DateTime Moment { get; set; }
        public OrderStatusNew Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public OrderNew()
        {
        }

        public OrderNew(DateTime moment, OrderStatusNew status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Item)
                sum += item.SubTotal();
             return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
