using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.DataBase.Payments.Models;

#nullable disable

namespace Orders_Payments_Server.DataBase.Context
{
    public partial class OrdersPaymentsDBContext : DbContext
    {
        protected readonly string ConnectionString;
        public OrdersPaymentsDBContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public OrdersPaymentsDBContext(DbContextOptions<OrdersPaymentsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FundDB> Funds { get; set; }
        public virtual DbSet<OrderDB> Orders { get; set; }
        public virtual DbSet<PaymentDB> Payments { get; set; }
    }
}
