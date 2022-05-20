using Jane;
using Orders_Payments_Server.Domain.Payments.Models;
using Orders_Payments_Server.Domain.Payments.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Payments.Services
{
    class PaymentsService : IPaymentsService
    {
        public IResult AddNewPayment()
        {
            throw new NotImplementedException();
        }

        public IResult<IEnumerable<Payment>> GetManyPayments()
        {
            throw new NotImplementedException();
        }
    }
}
