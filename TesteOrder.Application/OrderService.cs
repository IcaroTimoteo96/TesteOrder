using TesteOrder.Domain.IRepository;
using TesteOrder.Domain;

namespace TesteOrder.Application
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void PlaceOrder(Order order)
        {
            if (order == null || order.TotalAmount <= 0)
                throw new ArgumentException("Invalid order");

            _orderRepository.Save(order);
        }

        public Order FindOrderById(int id)
        {
            return _orderRepository.GetOrderById(id) ?? throw new KeyNotFoundException("Order not found.");
        }
    }
}