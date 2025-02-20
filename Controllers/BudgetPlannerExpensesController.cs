using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinance.Data;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class BudgetPlannerExpensesController : Controller
    {
        private readonly MyFinanceContext _context;

        public BudgetPlannerExpensesController(MyFinanceContext context)
        {
            _context = context;
        }

        // GET: BudgetPlannerExpenses
        public async Task<IActionResult> Index()
        {
            return View(await _context.BudgetPlannerExpenses.ToListAsync());
        }

        // GET: BudgetPlannerExpenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetPlannerExpense = await _context.BudgetPlannerExpenses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budgetPlannerExpense == null)
            {
                return NotFound();
            }

            return View(budgetPlannerExpense);
        }

        // GET: BudgetPlannerExpenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BudgetPlannerExpenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Frequency,Amount")] BudgetPlannerExpense budgetPlannerExpense)
        {
            if (ModelState.IsValid)
            {
                _context.Add(budgetPlannerExpense);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(budgetPlannerExpense);
        }

        // GET: BudgetPlannerExpenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetPlannerExpense = await _context.BudgetPlannerExpenses.FindAsync(id);
            if (budgetPlannerExpense == null)
            {
                return NotFound();
            }
            return View(budgetPlannerExpense);
        }

        // POST: BudgetPlannerExpenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Frequency,Amount")] BudgetPlannerExpense budgetPlannerExpense)
        {
            if (id != budgetPlannerExpense.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(budgetPlannerExpense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BudgetPlannerExpenseExists(budgetPlannerExpense.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(budgetPlannerExpense);
        }

        // GET: BudgetPlannerExpenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetPlannerExpense = await _context.BudgetPlannerExpenses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budgetPlannerExpense == null)
            {
                return NotFound();
            }

            return View(budgetPlannerExpense);
        }

        // POST: BudgetPlannerExpenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var budgetPlannerExpense = await _context.BudgetPlannerExpenses.FindAsync(id);
            if (budgetPlannerExpense != null)
            {
                _context.BudgetPlannerExpenses.Remove(budgetPlannerExpense);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BudgetPlannerExpenseExists(int id)
        {
            return _context.BudgetPlannerExpenses.Any(e => e.Id == id);
        }
    }
}
