using Orders_Payments_Server.DataBase.Payments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Payments.Repositories.Interfaces
{
    public interface IPaymentsRepository
    {
        public List<PaymentDB> GetPaymentsFromDB();
        public void SaveNewPayments(PaymentDB paymentDB);
    }
}
