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
    public class TeachersController : Controller
    {
        private readonly ExamStationDbContext _context;

        public TeachersController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teacher.ToListAsync());
        }

        public ActionResult TeacherProfile()
        {
            return View("TeacherProfile");
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        [HttpGet]
        public IActionResult TeacherList()
        {
            var TeacherListViewModel = new TeacherListViewModel();
            var teacherList = _context.Teacher.AsEnumerable()
                                        .Select(t => new Teacher
                                        {
                                            TeacherId = t.TeacherId,
                                            TeacherName = t.TeacherName,
                                            Email = t.Email,
                                            Photo = t.Photo
                                        }).ToList();

            TeacherListViewModel.TeacherList = teacherList;
            return View(TeacherListViewModel);
        }

        [HttpPost]
        public IActionResult TeacherList(TeacherListViewModel teacherListViewModel)
        {
            var TeacherListViewModel = new TeacherListViewModel();
            var teacherList = _context.Teacher.AsEnumerable()
                                        .Select(t => new Teacher
                                        {
                                            TeacherId = t.TeacherId,
                                            TeacherName = t.TeacherName,
                                            Email = t.Email,
                                            Photo = t.Photo
                                        }).ToList();
            var TListViewModel = new TeacherListViewModel();
            TListViewModel.TeacherList = teacherList;
            return View(TeacherListViewModel);
        }


        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,TeacherName,Designation,DateOfBirth,Gender,Religion,Email,Phone,Address,JoiningDate,Photo")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,TeacherName,Designation,DateOfBirth,Gender,Religion,Email,Phone,Address,JoiningDate,Photo")] Teacher teacher)
        {
            if (id != teacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.TeacherId))
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
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.TeacherId == id);
        }

        public JsonResult GetTeacherList(string teacherList)
        {
            teacherList = teacherList.ToUpper();
            var tList = _context.Teacher
                .Where(a => a.TeacherName.ToUpper().Contains(teacherList))
                .Select(a => new { a.TeacherId, a.TeacherName });
            return Json(tList);
        }

        public JsonResult GetKeyword(string q)
        {
            string TeacherKeyword = q.ToUpper();
            var tList = _context.Teacher
                .Where(a => a.TeacherName.ToUpper().Contains(TeacherKeyword))
                .Select(a => new { a.TeacherId, a.TeacherName });
            return Json(tList);
        }
    }
}
