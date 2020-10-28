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
    public class SectionsController : Controller
    {
        private readonly ExamStationDbContext _context;

        public SectionsController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: Sections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Section.ToListAsync());
        }

        // GET: Sections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section
                .FirstOrDefaultAsync(m => m.Id == id);
            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        [HttpGet]
        public IActionResult SectionList()
        {
            var SectionListViewModel = new SectionListViewModel();
            var sectionList = _context.Section.AsEnumerable()
                                        .Select(s => new Section
                                        {
                                            Id = s.Id,
                                            SectionName = s.SectionName,
                                            Category = s.Category,
                                            Capacity = s.Capacity,
                                            TeacherName = s.TeacherName,
                                            Note = s.Note
                                        }).ToList();

            SectionListViewModel.SectionList = sectionList;
            return View(SectionListViewModel);
        }

        [HttpPost]
        public IActionResult SectionList(SectionListViewModel sectionListViewModel)        {
            
                var SectionListViewModel = new SectionListViewModel();
                var sectionList = _context.Section.AsEnumerable()
                                            .Select(s => new Section
                                            {
                                                Id = s.Id,
                                                SectionName = s.SectionName,
                                                Category = s.Category,
                                                Capacity = s.Capacity,
                                                TeacherName = s.TeacherName,
                                                Note = s.Note
                                            }).ToList();
                var SListViewModel = new SectionListViewModel();
            SListViewModel.SectionList = sectionList;
            return View(SectionListViewModel);
        }


        // GET: Sections/Create
        public IActionResult Create()
        {
            ViewBag.ClassList = _context.Class.ToList();
            ViewBag.TeacherList = _context.Teacher.ToList();
            return View();
        }

        // POST: Sections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SectionName,Category,Capacity,Class,TeacherName,Note")] Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Add(section);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SectionList));
            }
            return View(section);
        }

        // GET: Sections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section.FindAsync(id);
            if (section == null)
            {
                return NotFound();
            }
            return View(section);
        }

        // POST: Sections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SectionName,Category,Capacity,Class,TeacherName,Note")] Section section)
        {
            if (id != section.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(section);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionExists(section.Id))
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
            return View(section);
        }

        // GET: Sections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section
                .FirstOrDefaultAsync(m => m.Id == id);
            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var section = await _context.Section.FindAsync(id);
            _context.Section.Remove(section);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionExists(int id)
        {
            return _context.Section.Any(e => e.Id == id);
        }

        public JsonResult GetSectionList(string sectionList)
        {
            sectionList = sectionList.ToUpper();
            var sList = _context.Section
                .Where(a => a.SectionName.ToUpper().Contains(sectionList))
                .Select(a => new { a.Id, a.SectionName });
            return Json(sList);
        }

        public JsonResult GetKeyword(string q)
        {
            string SectionKeyword = q.ToUpper();
            var sList = _context.Section
                .Where(a => a.SectionName.ToUpper().Contains(SectionKeyword))
                .Select(a => new { a.Id, a.SectionName });
            return Json(sList);
        }

    }
}
