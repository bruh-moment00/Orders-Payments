using Orders_Payments_Server.DataBase.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Orders.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public OrderDB GetOrderByID();
        public List<OrderDB> GetOrders();
        public void SaveNewOrders(IEnumerable<OrderDB> orderDBs);
    }
}
