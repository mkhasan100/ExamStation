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
using ExamStation.Helper;

namespace ExamStation.Controllers
{
    public class QuestionBanksController : Controller
    {
        private readonly ExamStationDbContext _context;
        Utility _utility;
        public QuestionBanksController(ExamStationDbContext context)
        {
            _context = context;
            _utility = new Utility();
        }

        // GET: QuestionBanks
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionBank.ToListAsync());
        }

        // GET: QuestionBanks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        [HttpGet]
        public IActionResult QuestionBankList()
        {
            var QuestionBankListViewModel = new QuestionBankListViewModel();
            ViewBag.QuestionGroupList = _utility.GetGroupList();
            ViewBag.QuestionLevelList = _context.QuestionLevel.ToList();
            ViewBag.QuestionTypeList = _context.QuestionType.ToList();
            var questionBankList = _context.QuestionBank
                .Join(_context.QuestionGroup, qb => qb.QuestionGroup.Id, qg => qg.Id, (qb, qg) => new { qb, qg })
                .Join(_context.QuestionLevel, qbqg => qbqg.qb.DifficultyLevelId, ql => ql.Id, (qbqg, ql) => new { qbqg, ql })
                                        .Select(qbl => new QuestionBank
                                        {
                                            Id = qbl.qbqg.qg.Id,
                                            Question = qbl.qbqg.qb.Question,
                                            DifficultyLevel = qbl.ql.Title,
                                            QuestionGroupName = qbl.qbqg.qg.Title,
                                            QuestionType = qbl.qbqg.qb.QuestionTypeId.ToString(),
                                            Answers = string.Join(',',_context.AnswersOptions.Where(w=>w.QuestionBank == qbl.qbqg.qb).Select(s=>s.Option).ToList())
                                        }).ToList();

            QuestionBankListViewModel.QuestionBankList = questionBankList;
            return View(QuestionBankListViewModel);
        }
    
        [HttpPost]
        public IActionResult QuestionBankList(QuestionBankListViewModel questionBankListViewModel)
        {
            //var QuestionBankListViewModel = new QuestionBankListViewModel();
            ViewBag.QuestionGroupList = _utility.GetGroupList();
            ViewBag.QuestionLevelList = _context.QuestionLevel.ToList();
            ViewBag.QuestionTypeList = _context.QuestionType.ToList();
            int? dificultyLevelId = questionBankListViewModel.DificultyLevelId;
            int? questionGroupId = questionBankListViewModel.QuestionGroupId;
            var questionBankList = _context.QuestionBank
                .Join(_context.QuestionGroup, qb => qb.QuestionGroup.Id, qg => qg.Id, (qb, qg) => new { qb, qg })
                .Join(_context.QuestionLevel, qbqg => qbqg.qb.DifficultyLevelId, ql => ql.Id, (qbqg, ql) => new { qbqg, ql })
                                        .Select(qbl => new QuestionBank
                                        {
                                            Id = qbl.qbqg.qg.Id,
                                            Question = qbl.qbqg.qb.Question,
                                            DifficultyLevel = qbl.ql.Title,
                                            QuestionGroupName = qbl.qbqg.qg.Title,
                                            QuestionType = qbl.qbqg.qb.QuestionType,
                                            Answers = qbl.qbqg.qb.Answers,
                                            DifficultyLevelId = qbl.qbqg.qb.DifficultyLevelId,
                                            QuestionGroup = qbl.qbqg.qb.QuestionGroup,
                                        })
                                        .Where(qb => (dificultyLevelId == null || qb.DifficultyLevelId == dificultyLevelId)
                                        && (questionGroupId == null || qb.QuestionGroup.Id == questionGroupId))
                                        .ToList();
            //var QBListViewModel = new QuestionBankListViewModel();
            questionBankListViewModel.QuestionBankList = questionBankList;
            return View(questionBankListViewModel);
        }

        // GET: QuestionBanks/Create
        public IActionResult Create()
        {
            ViewBag.QuestionGroupList = _utility.GetGroupList();
            ViewBag.QuestionLevelList = _context.QuestionLevel.ToList();
            ViewBag.QuestionTypeList = _context.QuestionType.ToList();

            return View();
        }

        // POST: QuestionBanks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuestionGroup,DifficultyLevel,Question,Explanation,Upload,Hints,Mark,QuestionType")] QuestionBank questionBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(QuestionBankList));
            }
            return View(questionBank);
        }

        // GET: QuestionBanks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank.FindAsync(id);
            if (questionBank == null)
            {
                return NotFound();
            }
            return View(questionBank);
        }

        // POST: QuestionBanks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuestionGroup,DifficultyLevel,Question,Explanation,Upload,Hints,Mark,QuestionType")] QuestionBank questionBank)
        {
            if (id != questionBank.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionBankExists(questionBank.Id))
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
            return View(questionBank);
        }

        // GET: QuestionBanks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBank
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        // POST: QuestionBanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionBank = await _context.QuestionBank.FindAsync(id);
            _context.QuestionBank.Remove(questionBank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionBankExists(int id)
        {
            return _context.QuestionBank.Any(e => e.Id == id);
        }

        //public JsonResult GetBankList(string questionBankList)
        //{
        //    questionBankList = questionBankList.ToUpper();
        //    var qBankList = _context.QuestionBank
        //        .Where(a => a.QuestionGroup.ToUpper().Contains(questionBankList))
        //        .Select(a => new { a.Id, a.QuestionGroup });
        //    return Json(qBankList);
        //}

        //public JsonResult GetKeyword(string q)
        //{
        //    string QuestionBankKeyword = q.ToUpper();
        //    var qBankList = _context.QuestionBank
        //        .Where(a => a.QuestionGroup.ToUpper().Contains(QuestionBankKeyword))
        //        .Select(a => new { a.Id, a.QuestionGroup });
        //    return Json(qBankList);
        //}

        //[HttpPost]
        //public JsonResult SaveQuestions(string test)
        //{
        //    return Json("");
        //}

        [HttpPost]
        public JsonResult SaveQuestions(int questionGroupId, int difficultyLevelId, string question, string explanation, string hints, int mark, int questionTypeId, int[] answerArray,  string[] optionArray)
        {
            string message = string.Empty;
            try
            {
                QuestionGroup questionGroup = _context.QuestionGroup.Where(q => q.Id == questionGroupId).FirstOrDefault();
                QuestionBank questionBank = new QuestionBank();
                questionBank.QuestionGroup = questionGroup;
                questionBank.DifficultyLevelId = difficultyLevelId;
                questionBank.Question = question;
                questionBank.Explanation = explanation;
                questionBank.Hints = hints;
                questionBank.Mark = mark;
                questionBank.QuestionTypeId = questionTypeId;

                _context.Add(questionBank);

                for (int i = 0; i < optionArray.Length; i++)
                {
                    AnswersOption answers = new AnswersOption();
                    answers.QuestionBank = questionBank;
                    answers.Option = optionArray[i];
                    answers.IsAnswer = answerArray[i];                   

                    _context.Add(answers);                    
                }
                _context.SaveChanges();

                message = "Question Created";
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
            }
            return Json(message);
        }
    }
}
