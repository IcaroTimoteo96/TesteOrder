namespace TesteOrder.Domain.IRepository
{
    public interface IOrderRepository
    {
        void Save(Order order);

        Order GetOrderById(int id);
    }
}
