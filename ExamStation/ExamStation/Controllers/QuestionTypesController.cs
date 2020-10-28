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
    public class QuestionTypesController : Controller
    {
        private readonly ExamStationDbContext _context;

        public QuestionTypesController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionType.ToListAsync());
        }

        // GET: QuestionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionType = await _context.QuestionType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionType == null)
            {
                return NotFound();
            }

            return View(questionType);
        }

        [HttpGet]
        public IActionResult QuestionTypeList()
        {
            var QuestionTypeListViewModel = new QuestionTypeListViewModel();
            var questionTypeList = _context.QuestionType
                                        .Select(qt => new QuestionType
                                        {
                                            Id = qt.Id,
                                            QuestionTypeName = qt.QuestionTypeName,
                                        }).ToList();

            QuestionTypeListViewModel.QuestionTypeList = questionTypeList;
            return View(QuestionTypeListViewModel);
        }

        [HttpPost]
        public IActionResult QuestionTypeList(QuestionTypeListViewModel questionTypeListViewModel)
        {
            var QuestionTypeListViewModel = new QuestionTypeListViewModel();
            var questionTypeList = _context.QuestionType
                                        .Select(qt => new QuestionType
                                        {
                                            Id = qt.Id,
                                            QuestionTypeName = qt.QuestionTypeName,
                                        }).ToList();
            var QTListViewModel = new QuestionTypeListViewModel();
            QTListViewModel.QuestionTypeList = questionTypeList;
            return View(QTListViewModel);
        }


        // GET: QuestionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuestionTypeName")] QuestionType questionType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(QuestionTypeList));
            }
            return View(questionType);
        }

        // GET: QuestionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionType = await _context.QuestionType.FindAsync(id);
            if (questionType == null)
            {
                return NotFound();
            }
            return View(questionType);
        }

        // POST: QuestionTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuestionTypeName")] QuestionType questionType)
        {
            if (id != questionType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionTypeExists(questionType.Id))
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
            return View(questionType);
        }

        // GET: QuestionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionType = await _context.QuestionType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionType == null)
            {
                return NotFound();
            }

            return View(questionType);
        }

        // POST: QuestionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionType = await _context.QuestionType.FindAsync(id);
            _context.QuestionType.Remove(questionType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionTypeExists(int id)
        {
            return _context.QuestionType.Any(e => e.Id == id);
        }

        public JsonResult GetTypeList(string questionTypeList)
        {
            questionTypeList = questionTypeList.ToUpper();
            var qTypeList = _context.QuestionType
                .Where(a => a.QuestionTypeName.ToUpper().Contains(questionTypeList))
                .Select(a => new { a.Id, a.QuestionTypeName });
            return Json(qTypeList);
        }

        public JsonResult GetKeyword(string q)
        {
            string QuestionTypeKeyword = q.ToUpper();
            var qTypeList = _context.QuestionType
                .Where(a => a.QuestionTypeName.ToUpper().Contains(QuestionTypeKeyword))
                .Select(a => new { a.Id, a.QuestionTypeName });
            return Json(qTypeList);
        }


    }
}
