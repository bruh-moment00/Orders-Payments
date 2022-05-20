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
        public IResult<IEnumerable<Fund>> GetManyFunds();
        public IResult<Fund> GetSingleFund();
        public IResult AddNewFunds(IEnumerable<Fund> funds);
    }
}
