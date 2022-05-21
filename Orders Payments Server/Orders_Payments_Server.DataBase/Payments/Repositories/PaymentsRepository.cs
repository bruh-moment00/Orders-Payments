using Orders_Payments_Server.DataBase.Context;
using Orders_Payments_Server.DataBase.Payments.Models;
using Orders_Payments_Server.DataBase.Payments.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Payments.Repositories
{
    public class PaymentsRepository : IPaymentsRepository
    {
        private readonly OrdersPaymentsDBContext _context;
        public PaymentsRepository(OrdersPaymentsDBContext context)
        {
            _context = context;
        }
        public List<PaymentDB> GetPaymentsFromDB()
        {
            return _context.Payments.ToList();
        }

        public void SaveNewPayments(PaymentDB paymentDB)
        {
            _context.Payments.Add(paymentDB);
            _context.SaveChanges();
        }
    }
}
