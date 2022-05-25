using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Orders.Models;
using Orders_Payments_Server.DataBase.Payments.Models;

namespace Orders_Payments_Server.DataBase.Contexts
{
    public class MSSQLServerDBContext : OrdersPaymentsDBContext
    {
        public MSSQLServerDBContext(string connectionString) : base(connectionString)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
