using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Funds.Models
{
    public class FundQuery
    {
        public DateTime Date { get; set; }
        public double Sum { get; set; }
    }
}
