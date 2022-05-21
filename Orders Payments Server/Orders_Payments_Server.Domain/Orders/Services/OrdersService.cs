using Jane;
using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.DataBase.Orders.Repositories.Interfaces;
using Orders_Payments_Server.Domain.Orders.Converters;
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
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }
        public IResult<IEnumerable<OrderResponse>> GetManyOrders()
        {
            IEnumerable<OrderResponse> orders = _ordersRepository.GetOrdersFromDB().ToOrderMultipleResponse();
            return Result.Success(orders);
        }
        IResult<OrderResponse> IOrdersService.GetSingleOrder(int id)
        {
            OrderResponse fund = _ordersRepository.GetOrderByIDFromDB(id).ToOrderResponse();
            return Result.Success(fund);
        }
        public IResult AddNewOrders(IEnumerable<QueryOrder> queryOrders)
        {
            IEnumerable<OrderDB> newFundDBs = queryOrders.ToOrderDBs();
            try
            {
                _ordersRepository.SaveNewOrders(newFundDBs);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }
    }
}
