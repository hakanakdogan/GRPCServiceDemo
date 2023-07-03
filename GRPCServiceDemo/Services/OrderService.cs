using Grpc.Core;
using GRPCServiceDemo;
using GRPCServiceDemo.Repositories;

namespace GRPCServiceDemo.Services
{
    public class OrderService : OrderProcessing.OrderProcessingBase
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IRepository _orderRepository;

        public OrderService(ILogger<OrderService> logger, IRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public override Task<OrderResponse> GetOrder
          (OrderRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderResponse
            {
                Order = _orderRepository.GetOrder().Result
            });
        }
    }
}
