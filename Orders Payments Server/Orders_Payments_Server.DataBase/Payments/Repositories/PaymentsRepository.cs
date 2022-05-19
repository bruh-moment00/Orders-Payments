using Orders_Payments_Server.DataBase.Payments.Models;
using Orders_Payments_Server.DataBase.Payments.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Payments.Repositories
{
    class PaymentsRepository : IPaymentsRepository
    {
        public List<PaymentDB> GetPaymentsFromDB()
        {
            throw new NotImplementedException();
        }

        public void SaveNewPayments(IEnumerable<PaymentDB> paymentDBs)
        {
            throw new NotImplementedException();
        }
    }
}
