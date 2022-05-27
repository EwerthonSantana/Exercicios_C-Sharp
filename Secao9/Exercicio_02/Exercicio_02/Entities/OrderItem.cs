namespace Exercicio_02.Entities
{
    class OrderItem
    {
      
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2") +
                ", Quantidade: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2");
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }


        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
