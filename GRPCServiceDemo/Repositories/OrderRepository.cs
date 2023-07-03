

using GRPCServiceDemo;

namespace GRPCServiceDemo.Repositories
{
    public class OrderRepository : IRepository
    {
        public async Task<Order> GetOrder()
        {
            return await Task.FromResult(new Order
            {
                OrderId = 1,
                ShipAddress = "Nilüfer",
                ShipCity = "Bursa",
                ShipPostalCode = "0000016",
                OrderQuantity = 100
            });
        }
    }
}
