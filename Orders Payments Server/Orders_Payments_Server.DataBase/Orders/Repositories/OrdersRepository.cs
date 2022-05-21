using Orders_Payments_Server.DataBase.Contexts;
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
        private readonly OrdersPaymentsDBContext _context;
        public OrdersRepository(OrdersPaymentsDBContext context)
        {
            _context = context;
        }
        public List<OrderDB> GetOrdersFromDB()
        {
            return _context.Orders.ToList();
        }
        public OrderDB GetOrderByIDFromDB(int id)
        {
            return _context.Orders.Find(id);
        }
        public void SaveNewOrders(IEnumerable<OrderDB> orderDBs)
        {
            _context.Orders.AddRange(orderDBs);
            _context.SaveChanges();
        }
    }
}
