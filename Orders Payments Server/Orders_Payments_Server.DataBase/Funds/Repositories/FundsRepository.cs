using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Funds.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Funds.Repositories
{
    public class FundsRepository : IFundsRepository
    {
        public List<FundDB> GetFundDBs()
        {
            throw new NotImplementedException();
        }

        public List<FundDB> GetFundsFromDB()
        {
            throw new NotImplementedException();
        }

        public FundDB GetFundByIDFromDB()
        {
            throw new NotImplementedException();
        }

        public void SaveNewFunds(IEnumerable<FundDB> fundDBs)
        {
            throw new NotImplementedException();
        }
    }
}
