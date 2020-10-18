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
    public class OnlineExamsController : Controller
    {
        private readonly ExamStationDbContext _context;
        Utility _utility;


        public OnlineExamsController(ExamStationDbContext context)
        {
            _context = context;
            _utility = new Utility();
        }

        // GET: OnlineExams
        public async Task<IActionResult> Index()
        {
            return View(await _context.OnlineExam.ToListAsync());
        }

        // GET: OnlineExams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var onlineExam = await _context.OnlineExam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (onlineExam == null)
            {
                return NotFound();
            }

            return View(onlineExam);
        }


        [HttpGet]
        public IActionResult OnlineExamList()
        {
            var OnlineExamListListViewModel = new OnlineExamListViewModel();
            var onlineExamList = _context.OnlineExam.AsEnumerable()
                                        .Select(oe => new OnlineExam
                                        {
                                            Id = oe.Id,
                                            ExamTitle = oe.ExamTitle,
                                            Published = oe.Published,
                                            Duration = oe.Duration,
                                            PaymentStatus = oe.PaymentStatus,
                                            Cost = oe.Cost
                                        }).ToList();

            OnlineExamListListViewModel.OnlineExamList = onlineExamList;
            return View(OnlineExamListListViewModel);
        }

        [HttpPost]
        public IActionResult OnlineExamList(SubjectListViewModel subjectListViewModel)
        {

            var OnlineExamListListViewModel = new OnlineExamListViewModel();
            var onlineExamList = _context.OnlineExam.AsEnumerable()
                                        .Select(oe => new OnlineExam
                                        {
                                            Id = oe.Id,
                                            ExamTitle = oe.ExamTitle,
                                            Published = oe.Published,
                                            Duration = oe.Duration,
                                            PaymentStatus = oe.PaymentStatus,
                                            Cost = oe.Cost
                                        }).ToList();
            var OEListViewModel = new OnlineExamListViewModel();
            OEListViewModel.OnlineExamList = onlineExamList;
            return View(OnlineExamListListViewModel);
        }


        // GET: OnlineExams/Create
        public IActionResult Create()
        {
            ViewBag.ClassList =_utility.GetClassList();
            ViewBag.SectionList = _utility.GetSectionList();
            ViewBag.GroupList = _utility.GetGroupList();
            ViewBag.SubjectList = _utility.GetSubjectList();
            ViewBag.InstructionList = _utility.GetInstructionList();
            return View();
        }

        // POST: OnlineExams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExamTitle,Description,Class,Section,StudentGroup,Subject,Instruction,ExamStatus,ExamType,Duration,MarkType,PassValue,PaymentStatus,Published")] OnlineExam onlineExam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(onlineExam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(onlineExam);
        }

        // GET: OnlineExams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var onlineExam = await _context.OnlineExam.FindAsync(id);
            if (onlineExam == null)
            {
                return NotFound();
            }
            return View(onlineExam);
        }

        // POST: OnlineExams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExamTitle,Description,Class,Section,StudentGroup,Subject,Instruction,ExamStatus,ExamType,Duration,MarkType,PassValue,PaymentStatus,Published")] OnlineExam onlineExam)
        {
            if (id != onlineExam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(onlineExam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OnlineExamExists(onlineExam.Id))
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
            return View(onlineExam);
        }

        // GET: OnlineExams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var onlineExam = await _context.OnlineExam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (onlineExam == null)
            {
                return NotFound();
            }

            return View(onlineExam);
        }

        // POST: OnlineExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var onlineExam = await _context.OnlineExam.FindAsync(id);
            _context.OnlineExam.Remove(onlineExam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OnlineExamExists(int id)
        {
            return _context.OnlineExam.Any(e => e.Id == id);
        }

        [HttpGet]
        public IActionResult _TakeExam(int id)
        {
            ViewBag.ExamId = id;
            return PartialView();
        }

        public JsonResult GetQuestionById(int Id)
        {
            string test = "empty";
            return Json(test);
        }

        public JsonResult GetOnlineExamList(string onlineExamList)
        {
            onlineExamList = onlineExamList.ToUpper();
            var OEList = _context.OnlineExam
                .Where(a => a.ExamTitle.ToUpper().Contains(onlineExamList))
                .Select(a => new { a.Id, a.ExamTitle });
            return Json(OEList);
        }

        public JsonResult GetKeyword(string q)
        {
            string OnlineExamKeyword = q.ToUpper();
            var OEList = _context.OnlineExam
                .Where(a => a.ExamTitle.ToUpper().Contains(OnlineExamKeyword))
                .Select(a => new { a.Id, a.ExamTitle });
            return Json(OEList);
        }

    }
}
