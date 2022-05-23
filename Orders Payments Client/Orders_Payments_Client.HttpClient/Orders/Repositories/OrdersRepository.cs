using Orders_Payments_Client.API.ApiClients.Interfaces;
using Orders_Payments_Client.API.Orders.Models;
using Orders_Payments_Client.API.Orders.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Orders.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly IApiClient _apiClient;
        public OrdersRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _apiClient.Get<IEnumerable<Order>>("orders");
        }
        public Order GetOrderById(int id)
        {
            return _apiClient.Get<Order>("orders/" + id);
        }

        public bool PostOrder(IEnumerable<OrderQuery> orders)
        {
            return _apiClient.Post("orders", orders).StatusCode == Leaf.xNet.HttpStatusCode.OK;
        }
    }
}
