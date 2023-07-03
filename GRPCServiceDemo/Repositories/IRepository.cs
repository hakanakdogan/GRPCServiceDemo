namespace GRPCServiceDemo.Repositories
{
    public interface IRepository
    {
        public Task<Order> GetOrder();
    }
}
