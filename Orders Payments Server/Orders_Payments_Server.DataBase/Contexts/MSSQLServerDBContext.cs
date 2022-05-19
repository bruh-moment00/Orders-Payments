using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Orders_Payments_Server.DataBase.Context;
using Orders_Payments_Server.DataBase.Models;

namespace Orders_Payments_Server.DataBase.Contexts
{
    class MSSQLServerDBContext : OrdersPaymentsDBContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<FundDB>(entity =>
            {
                entity.ToTable("FUNDS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remain).HasColumnName("remain");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<OrderDB>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaidSum).HasColumnName("paid_sum");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<PaymentDB>(entity =>
            {
                entity.ToTable("PAYMENTS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FundId).HasColumnName("fund_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PaymentSum).HasColumnName("payment_sum");

                entity.HasOne(d => d.Fund)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_FUNDS");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_ORDERS");
            });
        }

    }
}
