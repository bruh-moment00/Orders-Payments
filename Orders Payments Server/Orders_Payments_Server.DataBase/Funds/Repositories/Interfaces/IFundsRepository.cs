using Orders_Payments_Server.DataBase.Funds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Funds.Repositories.Interfaces
{
    public interface IFundsRepository
    {
        public FundDB GetFundByID();
        public List<FundDB> GetFunds();
        public void SaveNewFunds(IEnumerable<FundDB> fundDBs);
    }
}
