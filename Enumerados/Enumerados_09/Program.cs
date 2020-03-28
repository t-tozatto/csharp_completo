using Enumerados_09.Entities;
using Enumerados_09.Entities.Enums;
using System;
using System.Globalization;

namespace Enumerados_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int quantity = Convert.ToInt16(Console.ReadLine());

            OrderItem orderItem;
            Product product;
            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine(string.Concat("Enter #", i + 1," item data:"));
                Console.Write("Product name: ");
                string produtcName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = Convert.ToInt16(Console.ReadLine());

                product = new Product(produtcName, productPrice);
                orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order.ToString());
        }
    }
}
