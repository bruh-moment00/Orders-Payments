using Leaf.xNet;
using Orders_Payments_Client.API.ApiClients.Interfaces;
using Orders_Payments_Client.API.Payments.Models;
using Orders_Payments_Client.API.Payments.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Payments.Repositories
{
    public class PaymentsRepository : IPaymentsRepository
    {
        private readonly IApiClient _apiClient;
        public PaymentsRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public IEnumerable<Payment> GetPayments()
        {
            return _apiClient.Get<IEnumerable<Payment>>("payments");
        }

        public bool PostPayment(PaymentQuery payment)
        {
            return _apiClient.Post("payments", payment).StatusCode == HttpStatusCode.OK;
        }
    }
}
