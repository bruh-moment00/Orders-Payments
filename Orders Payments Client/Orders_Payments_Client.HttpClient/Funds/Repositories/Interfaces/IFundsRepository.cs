using Orders_Payments_Client.API.Funds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Funds.Repositories.Interfaces
{
    public interface IFundsRepository
    {
        public IEnumerable<Fund> GetFunds();
        public string PostFunds(IEnumerable<Fund> newFunds);
    }
}
