using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Payments.Models
{
    public class QueryPayment
    {
        public int OrderId { get; set; }
        public int FundId { get; set; }
        public double PaymentSum { get; set; }
    }
}
