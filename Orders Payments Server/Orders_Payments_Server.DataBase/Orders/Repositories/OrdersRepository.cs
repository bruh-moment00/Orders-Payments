using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.DataBase.Orders.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Orders.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        public OrderDB GetOrderByIDFromDB()
        {
            throw new NotImplementedException();
        }

        public List<OrderDB> GetOrdersFromDB()
        {
            throw new NotImplementedException();
        }

        public void SaveNewOrders(IEnumerable<OrderDB> orderDBs)
        {
            throw new NotImplementedException();
        }
    }
}
