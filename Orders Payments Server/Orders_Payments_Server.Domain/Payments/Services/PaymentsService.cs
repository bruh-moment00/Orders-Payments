using Jane;
using Orders_Payments_Server.DataBase.Payments.Models;
using Orders_Payments_Server.DataBase.Payments.Repositories.Interfaces;
using Orders_Payments_Server.Domain.Payments.Converters;
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
        private readonly IPaymentsRepository _paymentsRepository;
        public PaymentsService(IPaymentsRepository paymentsRepository)
        {
            _paymentsRepository = paymentsRepository;
        }
        public IResult AddNewPayment(QueryPayment queryPayment)
        {
            PaymentDB paymentDB = queryPayment.ToPaymentDB();
            try
            {
                _paymentsRepository.SaveNewPayments(paymentDB);
                return Result.Success();
            }
            catch(Exception ex)
            {
                return Result.Failure(ex);
            }
        }

        public IResult<IEnumerable<Payment>> GetManyPayments()
        {
            IEnumerable<Payment> payments = _paymentsRepository.GetPaymentsFromDB().ToPayments();
            return Result.Success(payments);
        }
    }
}
