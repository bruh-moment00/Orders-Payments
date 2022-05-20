using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.Domain.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Orders.Converters
{
    public static class OrdersConverter
    {
        public static Order ToOrder(this OrderDB orderDB)
        {
            return new Order()
            {
                Id = orderDB.Id,
                Date = orderDB.Date,
                Sum = orderDB.Sum,
                PaidSum = orderDB.PaidSum
            };
        }

        public static IEnumerable<Order> ToOrders(this IEnumerable<OrderDB> orderDBs)
        {
            return orderDBs.Select(ToOrder);
        }

        public static OrderDB ToOrderDB(this Order order)
        {
            return new OrderDB()
            {
                Date = order.Date,
                Sum = order.Sum,
            };
        }

        public static IEnumerable<OrderDB> ToOrderDBs(this IEnumerable<Order> orders)
        {
            return orders.Select(ToOrderDB);
        }
    }
}
