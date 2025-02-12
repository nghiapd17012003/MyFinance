using Microsoft.EntityFrameworkCore;

namespace MyFinance.Models
{
    public class ExpensesModel : DbContext
    {
        public int ExpensesId { get; set; }
       // public string Expense {  get; set; }
        public double Amount {  get; set; }
        //public string Description { get; set; }
        public ExpensesModel(DbContextOptions<ExpensesModel> options) { }
    }
}
