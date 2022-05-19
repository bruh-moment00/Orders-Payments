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
        public List<OrderDB> GetOrdersFromDB();
        public OrderDB GetOrderByIDFromDB(int id);
        public void SaveNewOrders(IEnumerable<OrderDB> orderDBs);
    }
}
