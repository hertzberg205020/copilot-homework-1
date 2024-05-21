// 這是代表一筆支出的 Entity
// 這個 Entity 會對應到資料庫中的一個 Table
// 這個 Entity 會被 Entity Framework Core 用來建立資料庫的 Table
// 這個 Entity 有幾個 proerty: Id, Date, Description, Amount, Category
// Id: int 一筆支出的唯一識別碼
// Date: DateTime 建立支出的日期
// Description: string 支出的說明
// Amount: decimal 支出的金額 precision: 18, scale: 2
// Category: string 支出的類別

using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseAPI.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        // value: '食' '衣' '住' '行' '育' '樂'
        [Required]
        public required string Category { get; set; }
    }
}
