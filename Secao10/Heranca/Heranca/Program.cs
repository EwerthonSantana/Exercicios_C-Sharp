using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new();

            Console.Write("Enter the number of products: ");
            int amountProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amountProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string tipProductChoise = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipProductChoise == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                if (tipProductChoise == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                if (tipProductChoise == "c")
                {
                    product.Add(new Product(name, price));
                }

            }


            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in product)
            {
                item.PriceTag();
            }



        }
    }
}
