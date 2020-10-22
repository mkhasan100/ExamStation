using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamStation.Data;
using ExamStation.Models;
using ExamStation.Helper;
using ExamStation.Models.ViewModels;

namespace ExamStation.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ExamStationDbContext _context;
        Utility _utility;

        public StudentsController(ExamStationDbContext context)
        {
            _context = context;
            _utility = new Utility();
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        public ActionResult StudentProfile()
        {
            return View("StudentProfile");
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpGet]
        public IActionResult StudentList()
        {
            var StudentListViewModel = new StudentListViewModel();
            var studentList = _context.Student.AsEnumerable()
                                        .Select(s => new Student
                                        {
                                            StudentId = s.StudentId,
                                            StudentName = s.StudentName,
                                            Roll = s.Roll,
                                            Email = s.Email,
                                            Photo = s.Photo
                                        }).ToList();

            StudentListViewModel.StudentList = studentList;
            return View(StudentListViewModel);
        }

        [HttpPost]
        public IActionResult StudentList(StudentListViewModel studentListViewModel)
        {
            var StudentListViewModel = new StudentListViewModel();
            var studentList = _context.Student.AsEnumerable()
                                        .Select(s => new Student
                                        {
                                            StudentId = s.StudentId,
                                            StudentName = s.StudentName,
                                            Roll = s.Roll,
                                            Email = s.Email,
                                            Photo = s.Photo
                                        }).ToList();
            var SListViewModel = new StudentListViewModel();
            SListViewModel.StudentList = studentList;
            return View(StudentListViewModel);
        }



        // GET: Students/Create
        public IActionResult Create()
        {
            ViewBag.GuardianList = _utility.GetGuardianList();
            ViewBag.ClassList = _utility.GetClassList(); 
            ViewBag.SectionList = _utility.GetSectionList();
            ViewBag.GroupList = _utility.GetGroupList();
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,StudentName,Guardian,DateOfBirth,Gender,BloodGroup,Religion,Email,Phone,Address,State,Country,Class,Section,Group,OptionalSubject,RegisterNo,Roll,Photo,ExtraActivities,Remarks")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentName,Guardian,DateOfBirth,Gender,BloodGroup,Religion,Email,Phone,Address,State,Country,Class,Section,Group,OptionalSubject,RegisterNo,Roll,Photo,ExtraActivities,Remarks")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.StudentId == id);
        }

        public JsonResult GetStudentList(string studentList)
        {
            studentList = studentList.ToUpper();
            var sList = _context.Student
                .Where(a => a.StudentName.ToUpper().Contains(studentList))
                .Select(a => new { a.StudentId, a.StudentName });
            return Json(sList);
        }

        public JsonResult GetKeyword(string q)
        {
            string StudentKeyword = q.ToUpper();
            var sList = _context.Student
                .Where(a => a.StudentName.ToUpper().Contains(StudentKeyword))
                .Select(a => new { a.StudentId, a.StudentName });
            return Json(sList);
        }

    }
}
