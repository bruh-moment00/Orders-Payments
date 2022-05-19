using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Orders.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Orders_Payments_Server.DataBase.Payments.Models
{
    public partial class PaymentDB
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FundId { get; set; }
        public double PaymentSum { get; set; }

        public virtual FundDB Fund { get; set; }
        public virtual OrderDB Order { get; set; }
    }
}
