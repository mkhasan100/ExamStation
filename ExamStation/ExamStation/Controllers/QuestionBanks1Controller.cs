using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamStation.Data;
using ExamStation.Models;

namespace ExamStation.Controllers
{
    public class QuestionBanks1Controller : Controller
    {
        private readonly ExamStationDbContext _context;
        public QuestionBanks1Controller(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionBanks1
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionBank.ToListAsync());
        }

        // GET: QuestionBanks1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        // GET: QuestionBanks1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionBanks1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuestionGroup,DifficultyLevel,Question,Explanation,Upload,Hints,Mark,QuestionType")] QuestionBank questionBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionBank);
        }

        // GET: QuestionBanks1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank.FindAsync(id);
            if (questionBank == null)
            {
                return NotFound();
            }
            return View(questionBank);
        }

        // POST: QuestionBanks1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuestionGroup,DifficultyLevel,Question,Explanation,Upload,Hints,Mark,QuestionType")] QuestionBank questionBank)
        {
            if (id != questionBank.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionBankExists(questionBank.Id))
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
            return View(questionBank);
        }

        // GET: QuestionBanks1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        // POST: QuestionBanks1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionBank = await _context.QuestionBank.FindAsync(id);
            _context.QuestionBank.Remove(questionBank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionBankExists(int id)
        {
            return _context.QuestionBank.Any(e => e.Id == id);
        }
    }
}
