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
    public class ClassesController : Controller
    {
        private readonly ExamStationDbContext _context;

        public ClassesController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: Classes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Class.ToListAsync());
        }

        // GET: Classes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        [HttpGet]
        public IActionResult ClassList()
        {
            var ClassListViewModel = new ClassListViewModel();
            var classList = _context.Class.AsEnumerable()
                                        .Select(c => new Class
                                        {
                                            Id = c.Id,
                                            ClassName = c.ClassName,
                                            ClassNumeric = c.ClassNumeric,
                                            TeacherName = c.TeacherName,
                                            Note = c.Note
                                        }).ToList();

            ClassListViewModel.ClassList = classList;
            return View(ClassListViewModel);
        }

        [HttpPost]
        public IActionResult ClassList(ClassListViewModel classListViewModel)
        {
            var ClassListViewModel = new ClassListViewModel();
            var classList = _context.Class.AsEnumerable()
                                        .Select(c => new Class
                                        {
                                            Id = c.Id,
                                            ClassName = c.ClassName,
                                            ClassNumeric = c.ClassNumeric,
                                            TeacherName = c.TeacherName,
                                            Note = c.Note
                                        }).ToList();
            var CListViewModel = new ClassListViewModel();
            CListViewModel.ClassList = classList;
            return View(ClassListViewModel);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName,ClassNumeric,TeacherName,Note")] Class @class)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@class);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassName,ClassNumeric,TeacherName,Note")] Class @class)
        {
            if (id != @class.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@class);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassExists(@class.Id))
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
            return View(@class);
        }

        // GET: Classes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @class = await _context.Class.FindAsync(id);
            _context.Class.Remove(@class);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassExists(int id)
        {
            return _context.Class.Any(e => e.Id == id);
        }
        public JsonResult GetClassList(string classList)
        {
            classList = classList.ToUpper();
            var cList = _context.Class
                .Where(a => a.TeacherName.ToUpper().Contains(classList))
                .Select(a => new { a.Id, a.ClassName });
            return Json(cList);
        }

        public JsonResult GetKeyword(string q)
        {
            string ClassKeyword = q.ToUpper();
            var cList = _context.Class
                .Where(a => a.ClassName.ToUpper().Contains(ClassKeyword))
                .Select(a => new { a.Id, a.ClassName });
            return Json(cList);
        }

    }
}
