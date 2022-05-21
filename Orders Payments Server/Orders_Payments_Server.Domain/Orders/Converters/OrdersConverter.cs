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
        public static OrderResponse ToOrderResponse(this OrderDB orderDB)
        {
            return new OrderResponse()
            {
                Id = orderDB.Id,
                Date = orderDB.Date,
                Sum = orderDB.Sum,
                PaidSum = orderDB.PaidSum
            };
        }

        public static IEnumerable<OrderResponse> ToOrderMultipleResponse(this IEnumerable<OrderDB> orderDBs)
        {
            return orderDBs.Select(ToOrderResponse);
        }

        public static OrderDB ToOrderDB(this QueryOrder queryOrder)
        {
            return new OrderDB()
            {
                Date = queryOrder.Date,
                Sum = queryOrder.Sum,
            };
        }

        public static IEnumerable<OrderDB> ToOrderDBs(this IEnumerable<QueryOrder> queryOrders)
        {
            return queryOrders.Select(ToOrderDB);
        }
    }
}
