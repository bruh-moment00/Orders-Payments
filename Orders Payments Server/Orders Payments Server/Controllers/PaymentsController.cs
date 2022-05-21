using Jane;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders_Payments_Server.Domain.Payments.Models;
using Orders_Payments_Server.Domain.Payments.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders_Payments_Server.API.Controllers
{
    [Route("api/payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private IPaymentsService _paymentsService;
        public PaymentsController(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
        }
        [HttpGet]
        public ActionResult GetPayments()
        {
            IResult<IEnumerable<Payment>> getPaymentResult = _paymentsService.GetManyPayments();

            JsonResult jsonResult;

            if (getPaymentResult.Ok)
            {
                jsonResult = new JsonResult(getPaymentResult.Value);
            }
            else
            {
                jsonResult = new JsonResult(getPaymentResult.Reason);
            }

            return jsonResult;
        }

        [HttpPost]
        public ActionResult AddPayment([FromBody] QueryPayment queryPayment)
        {
            IResult addPaymentResult = _paymentsService.AddNewPayment(queryPayment);

            JsonResult jsonResult;

            if (addPaymentResult.Ok)
            {
                jsonResult = new JsonResult(addPaymentResult.Ok);
            }
            else
            {
                jsonResult = new JsonResult(addPaymentResult.Reason);
            }

            return jsonResult;
        }
    }
}
