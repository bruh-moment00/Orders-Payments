using Jane;
using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.Domain.Orders.Models;
using Orders_Payments_Server.Domain.Orders.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Orders.Services
{
    public class OrdersService : IOrdersService
    {
        public IResult<IEnumerable<Order>> GetManyOrders()
        {
            throw new NotImplementedException();
        }

        public IResult<Order> GetSingleOrder()
        {
            throw new NotImplementedException();
        }
        public IResult AddNewOrders(IEnumerable<Order> orders)
        {
            throw new NotImplementedException();
        }
    }
}
