using System;
using System.Collections.Generic;

#nullable disable

namespace Orders_Payments_Server.DataBase.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FundId { get; set; }
        public double PaymentSum { get; set; }

        public virtual FundDB Fund { get; set; }
        public virtual Order Order { get; set; }
    }
}
