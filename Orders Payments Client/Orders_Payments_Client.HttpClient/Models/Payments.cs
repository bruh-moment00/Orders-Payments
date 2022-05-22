using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.HttpClient.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FundId { get; set; }
        public double PaymentSum { get; set; }
    }
}
