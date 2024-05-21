// 使用 ExpenseContext 產生預設資料
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExpenseAPI.Models;

namespace ExpenseAPI.Models
{
    public static class ExpenseDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExpenseContext(
                serviceProvider.GetRequiredService<DbContextOptions<ExpenseContext>>()))
            {
                // Look for any expenses.
                if (context.Expenses.Any())
                {
                    return;   // Data was already seeded
                }

                context.Expenses.AddRange(
                    new Expense
                    {
                        Description = "買午餐",
                        Amount = 100.00m,
                        Date = DateTime.Parse("2021-03-01"),
                        Category = "食",
                    },
                    new Expense
                    {
                        Description = "買晚餐",
                        Amount = 200.00m,
                        Date = DateTime.Parse("2021-03-02"),
                        Category = "食",
                    },
                    new Expense
                    {
                        Description = "買衣服",
                        Amount = 300.00m,
                        Date = DateTime.Parse("2021-03-03"),
                        Category = "衣",
                    },
                    new Expense
                    {
                        Description = "買書",
                        Amount = 400.00m,
                        Date = DateTime.Parse("2021-03-04"),
                        Category = "育",
                    },
                    new Expense
                    {
                        Description = "買票",
                        Amount = 500.00m,
                        Date = DateTime.Parse("2021-03-05"),
                        Category = "樂",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
