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
    public class QuestionGroupsController : Controller
    {
        private readonly ExamStationDbContext _context;

        public QuestionGroupsController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionGroup.ToListAsync());
        }

        // GET: QuestionGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionGroup = await _context.QuestionGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionGroup == null)
            {
                return NotFound();
            }

            return View(questionGroup);
        }


        [HttpGet]
        public IActionResult QuestionGroupList()
        {
            var QuestionGroupListViewModel = new QuestionGroupListViewModel();
            var questionGroupList = _context.QuestionGroup.AsEnumerable()                                        
                                        .Select(qgl => new QuestionGroup
                                        {
                                            Id = qgl.Id,
                                            Title = qgl.Title
                                        }).ToList();

            QuestionGroupListViewModel.QuestionGroupList = questionGroupList;
            return View(QuestionGroupListViewModel);
        }

        [HttpPost]
        public IActionResult QuestionGroupList(QuestionGroupListViewModel questionGroupListViewModel)
        {
            var QuestionGroupListViewModel = new QuestionGroupListViewModel();
            var questionGroupList = _context.QuestionGroup.AsEnumerable()
                                        .Select(qgl => new QuestionGroup
                                        {
                                            Id = qgl.Id,
                                            Title = qgl.Title
                                        }).ToList();
            var QGListViewModel = new QuestionGroupListViewModel();
            QGListViewModel.QuestionGroupList = questionGroupList;
            return View(QGListViewModel);
        }



        // GET: QuestionGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionGroup questionGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(QuestionGroupList));
            }
            return View(questionGroup);
        }

        // GET: QuestionGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionGroup = await _context.QuestionGroup.FindAsync(id);
            if (questionGroup == null)
            {
                return NotFound();
            }
            return View(questionGroup);
        }

        // POST: QuestionGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] QuestionGroup questionGroup)
        {
            if (id != questionGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionGroupExists(questionGroup.Id))
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
            return View(questionGroup);
        }

        // GET: QuestionGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionGroup = await _context.QuestionGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionGroup == null)
            {
                return NotFound();
            }

            return View(questionGroup);
        }

        // POST: QuestionGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionGroup = await _context.QuestionGroup.FindAsync(id);
            _context.QuestionGroup.Remove(questionGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionGroupExists(int id)
        {
            return _context.QuestionGroup.Any(e => e.Id == id);
        }



        public JsonResult GetGroupList(string questionGroupList)
        {
            questionGroupList = questionGroupList.ToUpper();
            var qGroupList = _context.QuestionGroup
                .Where(a => a.Title.ToUpper().Contains(questionGroupList))
                .Select(a => new { a.Id, a.Title});
            return Json(qGroupList);
        }

        public JsonResult GetKeyword(string q)
        {
            string QuestionGroupKeyword = q.ToUpper();
            var qGroupList = _context.QuestionGroup
                .Where(a => a.Title.ToUpper().Contains(QuestionGroupKeyword))
                .Select(a => new { a.Id, a.Title});
            return Json(qGroupList);
        }
    }
}
