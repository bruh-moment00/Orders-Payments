using Leaf.xNet;
using Newtonsoft.Json;
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
            return _apiClient.Get<IEnumerable<Fund>>("funds");
        }
        public Fund GetFundById(int id)
        {
            return _apiClient.Get<Fund>("funds/" + id);
        }

        public bool PostFunds(IEnumerable<FundQuery> funds)
        {
            return _apiClient.Post("funds", funds).StatusCode == HttpStatusCode.OK;
        }
    }
}
