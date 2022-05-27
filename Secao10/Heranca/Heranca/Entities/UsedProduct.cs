using System;
using System.Globalization;

namespace Heranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate)
        {
            Name = name;
            Price = price;
            ManufacturedDate = manufacturedDate;
        }

        public override void PriceTag()
        {
            Console.WriteLine($"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufacturedDate.ToShortDateString()})");
        }
    }
}
