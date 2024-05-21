// 使用 dto 承接前端傳來的資料

using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseAPI.Models
{
    public class ExpenseDto
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string? Category { get; set; }

        public Expense ToEntity()
        {
            return new Expense
            {
                Date = this.Date,
                Description = this.Description,
                Amount = this.Amount,
                Category = this.Category
            };
        }
    }
}