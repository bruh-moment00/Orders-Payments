using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.Funds.Models
{
    public class Fund
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public double Remain { get; set; }
    }
}
