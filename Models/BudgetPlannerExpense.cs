using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Models
{
    public class BudgetPlannerExpense
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Frequency { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)"), Required]
        public double Amount { get; set; }
    }
}
