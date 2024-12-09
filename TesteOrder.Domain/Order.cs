namespace TesteOrder.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<string> Products { get; set; } = new List<string>();
        public decimal TotalAmount { get; set; }
        public bool IsProcessed { get; private set; }

        public void AddProduct(string product, decimal price)
        {
            if (string.IsNullOrWhiteSpace(product) || price <= 0)
                throw new ArgumentException("Invalid product or price.");

            Products.Add(product);
            TotalAmount += price;
        }

        public void ProcessOrder()
        {
            if (Products.Count == 0)
                throw new InvalidOperationException("Order cannot be processed without products.");

            IsProcessed = true;
        }
    }
}