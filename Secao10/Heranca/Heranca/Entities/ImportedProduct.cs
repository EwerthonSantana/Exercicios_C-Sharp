using System;
using System.Globalization;

namespace Heranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustumsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double custumsFee)
        {
            Name = name;
            Price = price;
            CustumsFee = custumsFee;
        }


        public override void PriceTag()
        {
            Console.WriteLine($"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs fee: $ {CustumsFee.ToString("F2", CultureInfo.InvariantCulture)})");
        }

        public double totalPrice()
        {
            return Price + CustumsFee;
        }

       
    }
}
