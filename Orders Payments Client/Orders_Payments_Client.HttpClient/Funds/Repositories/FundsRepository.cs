using Orders_Payments_Client.API.ApiClients.Interfaces;
using Orders_Payments_Client.API.Funds.Models;
using Orders_Payments_Client.API.Funds.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Funds.Repositories
{
    public class FundsRepository : IFundsRepository
    {
        private readonly IApiClient _apiClient;
        public FundsRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public IEnumerable<Fund> GetFunds()
        {
            IEnumerable<Fund> funds = (IEnumerable<Fund>)_apiClient.Get("funds");
            return funds;
        }

        public string PostFunds(IEnumerable<Fund> newFunds)
        {
            throw new NotImplementedException();
        }
    }
}
