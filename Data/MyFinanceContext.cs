using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFinance.Models;

namespace MyFinance.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext (DbContextOptions<MyFinanceContext> options)
            : base(options)
        {
        }

        public DbSet<MyFinance.Models.Expense> Expense { get; set; } = default!;

        // Add the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .Property(e => e.Id)
                .HasColumnOrder(0);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Date)
                .HasColumnOrder(1);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Name)
                .HasColumnOrder(2);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Type)
                .HasColumnOrder(3);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Amount)
                .HasColumnOrder(4);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Description)
                .HasColumnOrder(5);
        }
    }
}
