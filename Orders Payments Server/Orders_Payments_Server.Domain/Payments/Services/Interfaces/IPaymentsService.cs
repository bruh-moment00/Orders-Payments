using Jane;
using Orders_Payments_Server.Domain.Payments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Payments.Services.Interfaces
{
    public interface IPaymentsService
    {
        public IResult<IEnumerable<Payment>> GetManyPayments();
        public IResult AddNewPayment(QueryPayment queryPayment);
    }
}
