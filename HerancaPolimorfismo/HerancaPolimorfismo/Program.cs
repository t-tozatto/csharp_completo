using HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = Convert.ToInt16(Console.ReadLine());

            char type;
            string name;
            double price;

            List<Product> listProduct = new List<Product>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine(string.Concat("Product #", i + 1, " data:"));
                Console.Write("Common, used or imported (c/u/i)? ");
                type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch(type)
                {
                    case 'i':
                        Console.Write("Custom fee: ");
                        listProduct.Add(new ImportedProduct(name, price, Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture)));
                        break;
                    case 'u':
                        Console.Write("Manufacture date: ");
                        listProduct.Add(new UsedProduct(name, price, Convert.ToDateTime(Console.ReadLine())));
                        break;
                    default:
                        listProduct.Add(new Product(name, price));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            for (int i = 0; i < numberOfProducts; i++)
                Console.WriteLine(listProduct[i].PriceTag());
        }
    }
}
