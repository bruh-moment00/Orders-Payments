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
            var funds = _apiClient.Get<IEnumerable<Fund>>("funds").ToString();

            return JsonConvert.DeserializeObject<IEnumerable<Fund>>(funds);
        }
        public Fund GetFundById(int id)
        {
            var fund = _apiClient.Get<Fund>("funds/" + id).ToString();

            return JsonConvert.DeserializeObject<Fund>(fund);
        }

        public HttpStatusCode PostFunds(IEnumerable<Fund> funds)
        {
            return _apiClient.Post("funds", funds).StatusCode;
        }
    }
}
