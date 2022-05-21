using Jane;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders_Payments_Server.Domain.Orders.Models;
using Orders_Payments_Server.Domain.Orders.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders_Payments_Server.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        [HttpGet]
        public ActionResult GetOrders()
        {
            IResult<IEnumerable<OrderResponse>> getOrdersResult = _ordersService.GetManyOrders();

            JsonResult jsonResult;

            if (getOrdersResult.Ok)
            {
                jsonResult = new JsonResult(getOrdersResult.Value);
            }
            else
            {
                jsonResult = new JsonResult(getOrdersResult.Reason);
            }

            return jsonResult;
        }
        [HttpGet("{id}")]
        public ActionResult GetOrderById(int id)
        {
            IResult<OrderResponse> getOrderResult = _ordersService.GetSingleOrder(id);

            JsonResult jsonResult;

            if (getOrderResult.Ok)
            {
                jsonResult = new JsonResult(getOrderResult.Value);
            }
            else
            {
                jsonResult = new JsonResult(getOrderResult.Reason);
            }

            return jsonResult;
        }
        [HttpPost]
        public ActionResult AddOrders([FromBody] IEnumerable<QueryOrder> queryOrder)
        {
            IResult addOrdersResult = _ordersService.AddNewOrders(queryOrder);

            JsonResult jsonResult;

            if (addOrdersResult.Ok)
            {
                jsonResult = new JsonResult(addOrdersResult.Ok);
            }
            else
            {
                jsonResult = new JsonResult(addOrdersResult.Reason);
            }

            return jsonResult;
        }
    }
}
