using Orders_Payments_Client.API.Payments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Payments.Repositories.Interfaces
{
    public interface IPaymentsRepository
    {
        public IEnumerable<Payment> GetPayments();
        public bool PostPayment(PaymentQuery orders);
    }
}
