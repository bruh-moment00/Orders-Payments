using Jane;
using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Funds.Repositories.Interfaces;
using Orders_Payments_Server.Domain.Funds.Converters;
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
        private readonly IFundsRepository _fundsRepository;
        public FundsService(IFundsRepository fundsRepository)
        {
            _fundsRepository = fundsRepository;
        }
        public IResult<IEnumerable<FundResponse>> GetManyFunds()
        {
            IEnumerable<FundResponse> funds = _fundsRepository.GetFundsFromDB().ToFundMultipleResponse();
            return Result.Success(funds);
        }
        IResult<FundResponse> IFundsService.GetSingleFund(int id)
        {
            FundResponse fund = _fundsRepository.GetFundByIDFromDB(id).ToFundResponse();
            return Result.Success(fund);
        }
        public IResult AddNewFunds(IEnumerable<QueryFund> queryFunds)
        {
            IEnumerable<FundDB> newFundDBs = queryFunds.ToFundDBs();
            try
            {
                _fundsRepository.SaveNewFunds(newFundDBs);
                return Result.Success();
            } 
            catch(Exception ex)
            {
                return Result.Failure(ex);
            }
        }
    }
}
