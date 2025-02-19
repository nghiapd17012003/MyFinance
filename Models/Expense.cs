using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public required string Name { get; set; }
        
        public required string Type { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)"), Required]
        public double Amount { get; set; }

        [StringLength(64)]
        public string? Description { get; set; }
        
    }
}
