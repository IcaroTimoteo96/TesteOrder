using System.Diagnostics;
using TesteOrder.Domain;

namespace TesteOrder
{
    public class UnitTest1
    {
        [Fact]
        public void AddProductValid()
        {
            string product = "Product 1";
            decimal price = 1;

            var order = new Order();

            order.AddProduct(product, price);

            Assert.True(order.Products.Count > 0);
            Assert.True(order.TotalAmount > 0);
        }

        [Fact]
        public void AddProductInvalid()
        {
            var order = new Order();
            Assert.Throws<ArgumentException>(() => order.AddProduct("", 0));
            Assert.Throws<ArgumentException>(() => order.AddProduct("Product 1", -100000));
        }

        [Fact]
        public void ProcessOrder()
        {
            string product = "Product 2";
            decimal price = 125;

            var order = new Order();
            order.AddProduct(product, price);
            order.ProcessOrder();

            Assert.True(order.IsProcessed);
        }

        [Fact]
        public void ProcessOrderEmpty()
        {
            var order = new Order();
            Assert.Throws<InvalidOperationException>(() => order.ProcessOrder());
        }
    }
}