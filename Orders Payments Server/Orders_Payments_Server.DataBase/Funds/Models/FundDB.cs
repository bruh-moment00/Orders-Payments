﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Orders_Payments_Server.DataBase.Models
{
    public partial class FundDB
    {
        public FundDB()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public double Remain { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
