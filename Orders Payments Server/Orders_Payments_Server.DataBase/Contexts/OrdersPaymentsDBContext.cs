using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Orders_Payments_Server.DataBase.Models;

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
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}
