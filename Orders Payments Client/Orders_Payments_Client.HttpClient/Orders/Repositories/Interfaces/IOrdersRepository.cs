using Orders_Payments_Client.API.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Orders.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public IEnumerable<Order> GetOrders();
    }
}
