using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
        public double TotalPrice { get; set; }
        public string? Description { get; set; }
        
    }
}
