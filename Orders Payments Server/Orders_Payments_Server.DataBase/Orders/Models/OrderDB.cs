using Orders_Payments_Server.DataBase.Payments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Orders_Payments_Server.DataBase.Orders.Models
{
    public partial class OrderDB
    {
        [Key]
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public double PaidSum { get; set; }
    }
}
