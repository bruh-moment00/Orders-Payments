using Jane;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders_Payments_Server.Domain.Funds.Models;
using Orders_Payments_Server.Domain.Funds.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders_Payments_Server.API.Controllers
{
    [Route("api/funds")]
    [ApiController]
    public class FundsController : ControllerBase
    {
        private IFundsService _fundsService;
        public FundsController(IFundsService fundsService)
        {
            _fundsService = fundsService;
        }
        [HttpGet]
        public ActionResult GetOrders()
        {
            IResult<IEnumerable<FundResponse>> getFundsResult = _fundsService.GetManyFunds();

            JsonResult jsonResult;

            if (getFundsResult.Ok)
            {
                jsonResult = new JsonResult(getFundsResult.Value);
            }
            else
            {
                jsonResult = new JsonResult(getFundsResult.Reason);
            }

            return jsonResult;
        }
        [HttpGet("{id}")]
        public ActionResult GetFundById(int id)
        {
            IResult<FundResponse> getFundResult = _fundsService.GetSingleFund(id);

            JsonResult jsonResult;

            if (getFundResult.Ok)
            {
                jsonResult = new JsonResult(getFundResult.Value);
            }
            else
            {
                jsonResult = new JsonResult(getFundResult.Reason);
            }

            return jsonResult;
        }
        [HttpPost]
        public ActionResult AddFunds([FromBody] IEnumerable<QueryFund> queryFund)
        {
            IResult addFundsResult = _fundsService.AddNewFunds(queryFund);

            JsonResult jsonResult;

            if (addFundsResult.Ok)
            {
                jsonResult = new JsonResult(addFundsResult.Ok);
            }
            else
            {
                jsonResult = new JsonResult(addFundsResult.Reason);
            }

            return jsonResult;
        }
    }
}
