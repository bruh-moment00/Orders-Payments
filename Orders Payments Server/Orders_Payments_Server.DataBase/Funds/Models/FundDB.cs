using Orders_Payments_Server.DataBase.Payments.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Orders_Payments_Server.DataBase.Funds.Models
{
    public partial class FundDB
    {
        //public FundDB()
        //{
        //    Payments = new HashSet<PaymentDB>();
        //}

        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public double? Remain { get; set; }

        //public virtual ICollection<PaymentDB> Payments { get; set; }
    }
}
