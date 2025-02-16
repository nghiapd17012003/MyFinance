using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Data;
using System;
using System.Linq;

namespace MyFinance.Models
{
    public static class SeedExpensesData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyFinanceContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyFinanceContext>>()))
            {
                //Looks for any expense
                if (context.Expense.Any())
                {
                    return;
                }
                context.Expense.AddRange(
                    new Expense
                    {
                        Name = "Expense Dummy 1",
                        Amount = 1,
                        TotalPrice = 0,
                        Description = "This is the first dummy expense, you can delete it!"
                    },
                    new Expense
                    {
                        Name = "Expense Dummy 2",
                        Amount = 2,
                        TotalPrice = 0,
                        Description = "This is the second dummy expense, you can delete it!"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
