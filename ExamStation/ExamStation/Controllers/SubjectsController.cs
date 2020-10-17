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
    public class SubjectsController : Controller
    {
        private readonly ExamStationDbContext _context;

        public SubjectsController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: Subjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subject.ToListAsync());
        }

        // GET: Subjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        [HttpGet]
        public IActionResult SubjectList()
        {
            var SubjectListViewModel = new SubjectListViewModel();
            var subjectList = _context.Subject.AsEnumerable()
                                        .Select(s => new Subject
                                        {
                                            Id = s.Id,
                                            SubjectName = s.SubjectName,
                                            SubjectAuthor = s.SubjectAuthor,
                                            SubjectCode = s.SubjectCode,
                                            TeacherName = s.TeacherName,
                                            PassMark = s.PassMark,
                                            FinalMark = s.FinalMark,
                                            Type = s.Type
                                        }).ToList();

            SubjectListViewModel.SubjectList = subjectList;
            return View(SubjectListViewModel);
        }

        [HttpPost]
        public IActionResult SubjectList(SubjectListViewModel subjectListViewModel)
        {

            var SubjectListViewModel = new SubjectListViewModel();
            var subjectList = _context.Subject.AsEnumerable()
                                        .Select(s => new Subject
                                        {
                                            Id = s.Id,
                                            SubjectName = s.SubjectName,
                                            SubjectAuthor = s.SubjectAuthor,
                                            SubjectCode = s.SubjectCode,
                                            TeacherName = s.TeacherName,
                                            PassMark = s.PassMark,
                                            FinalMark = s.FinalMark,
                                            Type = s.Type
                                        }).ToList();
            var SubListViewModel = new SubjectListViewModel();
            SubListViewModel.SubjectList = subjectList;
            return View(SubjectListViewModel);
        }


        // GET: Subjects/Create
        public IActionResult Create()
        {
            ViewBag.ClassList = _context.Class.ToList();
            ViewBag.TeacherList = _context.Teacher.ToList();
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName,TeacherName,Type,PassMark,FinalMark,SubjectName,SubjectCode")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: Subjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassName,TeacherName,Type,PassMark,FinalMark,SubjectName,SubjectCode")] Subject subject)
        {
            if (id != subject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(subject.Id))
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
            return View(subject);
        }

        // GET: Subjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await _context.Subject.FindAsync(id);
            _context.Subject.Remove(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }

        public JsonResult GetSubjectList(string subjectList)
        {
            subjectList = subjectList.ToUpper();
            var subList = _context.Subject
                .Where(a => a.SubjectName.ToUpper().Contains(subjectList))
                .Select(a => new { a.Id, a.SubjectName });
            return Json(subList);
        }

        public JsonResult GetKeyword(string q)
        {
            string SubjectKeyword = q.ToUpper();
            var subList = _context.Subject
                .Where(a => a.SubjectName.ToUpper().Contains(SubjectKeyword))
                .Select(a => new { a.Id, a.SubjectName });
            return Json(subList);
        }

    }
}
