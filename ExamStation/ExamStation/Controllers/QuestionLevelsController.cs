using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamStation.Data;
using ExamStation.Models;
using ExamStation.Models.ViewModels;

namespace ExamStation.Controllers
{
    public class QuestionLevelsController : Controller
    {
        private readonly ExamStationDbContext _context;

        public QuestionLevelsController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionLevels
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionLevel.ToListAsync());
        }

        // GET: QuestionLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionLevel = await _context.QuestionLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionLevel == null)
            {
                return NotFound();
            }

            return View(questionLevel);
        }

        [HttpGet]
        public IActionResult QuestionLevelList()
        {
            var QuestionLevelListViewModel = new QuestionLevelListViewModel();
            var questionLevelList = _context.QuestionLevel.AsEnumerable()
                                        .Select(qll => new QuestionLevel
                                        {
                                            Id = qll.Id,
                                            Title = qll.Title
                                        }).ToList();

            QuestionLevelListViewModel.QuestionLevelList = questionLevelList;
            return View(QuestionLevelListViewModel);
        }

        [HttpPost]
        public IActionResult QuestionLevelList(QuestionLevelListViewModel questionLevelListViewModel)
        {
            var QuestionLevelListViewModel = new QuestionGroupListViewModel();
            var questionLevelList = _context.QuestionLevel.AsEnumerable()
                                        .Select(qgl => new QuestionLevel
                                        {
                                            Id = qgl.Id,
                                            Title = qgl.Title
                                        }).ToList();
            var QLListViewModel = new QuestionLevelListViewModel();
            QLListViewModel.QuestionLevelList = questionLevelList;
            return View(QLListViewModel);
        }

        // GET: QuestionLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionLevels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] QuestionLevel questionLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(QuestionLevelList));
            }
            return View(questionLevel);
        }

        // GET: QuestionLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionLevel = await _context.QuestionLevel.FindAsync(id);
            if (questionLevel == null)
            {
                return NotFound();
            }
            return View(questionLevel);
        }

        // POST: QuestionLevels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] QuestionLevel questionLevel)
        {
            if (id != questionLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionLevelExists(questionLevel.Id))
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
            return View(questionLevel);
        }

        // GET: QuestionLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionLevel = await _context.QuestionLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionLevel == null)
            {
                return NotFound();
            }

            return View(questionLevel);
        }

        // POST: QuestionLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionLevel = await _context.QuestionLevel.FindAsync(id);
            _context.QuestionLevel.Remove(questionLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionLevelExists(int id)
        {
            return _context.QuestionLevel.Any(e => e.Id == id);
        }

        public JsonResult GetLevelList(string questionLevelList)
        {
            questionLevelList = questionLevelList.ToUpper();
            var qLevelList = _context.QuestionLevel
                .Where(a => a.Title.ToUpper().Contains(questionLevelList))
                .Select(a => new { a.Id, a.Title });
            return Json(qLevelList);
        }

        public JsonResult GetKeyword(string q)
        {
            string QuestionLevelKeyword = q.ToUpper();
            var qLevelList = _context.QuestionLevel
                .Where(a => a.Title.ToUpper().Contains(QuestionLevelKeyword))
                .Select(a => new { a.Id, a.Title });
            return Json(qLevelList);
        }

    }
}
