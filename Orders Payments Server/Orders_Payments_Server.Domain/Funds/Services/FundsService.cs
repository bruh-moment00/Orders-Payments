using Jane;
using Orders_Payments_Server.Domain.Funds.Models;
using Orders_Payments_Server.Domain.Funds.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Funds.Services
{
    class FundsService : IFundsService
    {
        public IResult<IEnumerable<Fund>> GetManyFunds()
        {
            throw new NotImplementedException();
        }
        IResult<Fund> IFundsService.GetSingleFund()
        {
            throw new NotImplementedException();
        }
        public IResult AddNewFunds(IEnumerable<Fund> funds)
        {
            throw new NotImplementedException();
        }
    }
}
