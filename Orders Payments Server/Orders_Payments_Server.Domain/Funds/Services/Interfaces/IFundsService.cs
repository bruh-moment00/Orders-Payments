using Jane;
using Orders_Payments_Server.Domain.Funds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Funds.Services.Interfaces
{
    public interface IFundsService
    {
        public IResult<IEnumerable<FundResponse>> GetManyFunds();
        public IResult<FundResponse> GetSingleFund(int id);
        public IResult AddNewFunds(IEnumerable<QueryFund> funds);
    }
}
