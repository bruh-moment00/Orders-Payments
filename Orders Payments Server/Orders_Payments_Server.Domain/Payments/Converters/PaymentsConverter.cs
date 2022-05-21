using Orders_Payments_Server.DataBase.Payments.Models;
using Orders_Payments_Server.Domain.Payments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Payments.Converters
{
    public static class PaymentsConverter
    {
        public static Payment ToPayment(this PaymentDB paymentDB)
        {
            return new Payment()
            {
                Id = paymentDB.Id,
                OrderId = paymentDB.OrderId,
                FundId = paymentDB.FundId,
                PaymentSum = paymentDB.PaymentSum
            };
        }

        public static IEnumerable<Payment> ToPayments(this IEnumerable<PaymentDB> paymentDBs)
        {
            return paymentDBs.Select(ToPayment);
        }

        public static PaymentDB ToPaymentDB(this QueryPayment queryPayment)
        {
            return new PaymentDB()
            {
                OrderId = queryPayment.OrderId,
                FundId = queryPayment.FundId,
                PaymentSum = queryPayment.PaymentSum
            };
        }

        public static IEnumerable<PaymentDB> ToPaymentDBs(this IEnumerable<QueryPayment> queryPayments)
        {
            return queryPayments.Select(ToPaymentDB);
        }
    }
}
