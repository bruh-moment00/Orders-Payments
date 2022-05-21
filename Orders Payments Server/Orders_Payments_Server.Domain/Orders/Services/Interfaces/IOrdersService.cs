using Jane;
using Orders_Payments_Server.Domain.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Orders.Services.Interfaces
{
    public interface IOrdersService
    {
        public IResult<IEnumerable<OrderResponse>> GetManyOrders();
        public IResult<OrderResponse> GetSingleOrder(int id);
        public IResult AddNewOrders(IEnumerable<QueryOrder> queryOrders);
    }
}
