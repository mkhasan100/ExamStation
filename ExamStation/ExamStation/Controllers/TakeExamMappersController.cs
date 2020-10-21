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
    public class TakeExamMappersController : Controller
    {
        private readonly ExamStationDbContext _context;

        public TakeExamMappersController(ExamStationDbContext context)
        {
            _context = context;
        }

        // GET: TakeExamMappers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakeExamMapper.ToListAsync());
        }

        public ActionResult TakeExamMap()
        {
            ViewBag.ExamTitleList = _context.OnlineExam.ToList();
            ViewBag.ExamGroupList = _context.QuestionGroup.ToList();
            return View("TakeExamMap");
        }

        // GET: TakeExamMappers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeExamMapper = await _context.TakeExamMapper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (takeExamMapper == null)
            {
                return NotFound();
            }

            return View(takeExamMapper);
        }

        // GET: TakeExamMappers/Create
        public IActionResult Create()
        {
            TakeExamMapperViewModel takeExamMapperViewModel = new TakeExamMapperViewModel();
            return View(takeExamMapperViewModel);
        }

        // POST: TakeExamMappers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TakeExamMapperViewModel takeExamMapperViewModel)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i <takeExamMapperViewModel.TakeExamMapperList.Count; i++)
                {
                    TakeExamMapper takeExamMapper = new TakeExamMapper();
                    takeExamMapper.ExamId = takeExamMapper.ExamId;
                    takeExamMapper.QuestionBankId = takeExamMapper.QuestionBankId;

                    _context.TakeExamMapper.Add(takeExamMapper);
                    _context.SaveChanges();

                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: TakeExamMappers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeExamMapper = await _context.TakeExamMapper.FindAsync(id);
            if (takeExamMapper == null)
            {
                return NotFound();
            }
            return View(takeExamMapper);
        }

        // POST: TakeExamMappers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExamId,QuestionGroupId")] TakeExamMapper takeExamMapper)
        {
            if (id != takeExamMapper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takeExamMapper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakeExamMapperExists(takeExamMapper.Id))
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
            return View(takeExamMapper);
        }

        // GET: TakeExamMappers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeExamMapper = await _context.TakeExamMapper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (takeExamMapper == null)
            {
                return NotFound();
            }

            return View(takeExamMapper);
        }

        // POST: TakeExamMappers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takeExamMapper = await _context.TakeExamMapper.FindAsync(id);
            _context.TakeExamMapper.Remove(takeExamMapper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakeExamMapperExists(int id)
        {
            return _context.TakeExamMapper.Any(e => e.Id == id);
        }

        //public JsonResult GetQuestions(String q)
        //{
        //    q = q.ToUpper();
        //    var examTitle = _context.OnlineExam
        //        .Where(a => a.ExamTitle.ToUpper().Contains(q))
        //        .Select(a => new { id = a.Id, name = a.ExamTitle });
        //    return Json(examTitle);
        //}

        [HttpGet]
        public JsonResult GetQuestionBankList(int questionGroupId) 
        {
            var questionBankList = _context.QuestionBank
                .Where(qb => qb.QuestionGroup.Id == questionGroupId)
                .Select(q => new { q.Id, q.Question }).ToList();
            return Json(questionBankList);
            
        }

        [HttpPost]
        public JsonResult SaveExamQuestionMapper(int examId, string questionBankIds )
        {
            string savedMessage = string.Empty;
            try
            {
                string[] questionBankIdArray = questionBankIds.Split(',');

                foreach (var item in questionBankIdArray)
                {
                    TakeExamMapper examQuestionMapper = new TakeExamMapper();

                    examQuestionMapper.ExamId = examId;
                    examQuestionMapper.QuestionBankId = Convert.ToInt32(item);

                    _context.Add(examQuestionMapper);
                    _context.SaveChanges();
                }

                savedMessage = "Saved Successfully";
            }
            catch (Exception ex)
            {
                savedMessage = "Save failed. "+ ex.Message.ToString() ;
            }


            return Json(savedMessage);
            

        }

    }
}
