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
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using ExamStation.Areas.Identity.Data;

namespace ExamStation.Controllers
{
    public class OnlineExamsController : Controller
    {

        private readonly ExamStationDbContext _context;
        private readonly UserManager<ExamStationUser> userManager;
        Utility _utility;


        public OnlineExamsController(ExamStationDbContext context,UserManager<ExamStationUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
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
            ViewBag.ClassList = _utility.GetClassList();
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
                return RedirectToAction(nameof(OnlineExamList));
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
            ViewBag.UserEmail = userManager.FindByNameAsync(userManager.GetUserName(User)).Result.Email;
            return PartialView();
        }
        
        [HttpGet]
        public IActionResult _FinishExam(int examId)
        {


            ViewBag.UserEmail = userManager.FindByNameAsync(userManager.GetUserName(User)).Result.Email;
            ViewBag.ExamId = examId;

            List<TakeExamMapper> examQuestionList = new List<TakeExamMapper>();
            examQuestionList = _context.TakeExamMapper.Where(w=>w.ExamId==examId).ToList();

            string commaSeparatedQuestion = string.Empty;
            
            int[] intQuestionBankId = examQuestionList.Select(s => s.QuestionBankId).ToArray();

            for (int i = 0; i < intQuestionBankId.Length; i++)
            {
                if (i==0)
                {
                    commaSeparatedQuestion = intQuestionBankId[i].ToString();
                }

                else
                {
                    commaSeparatedQuestion += "," + intQuestionBankId[i].ToString();
                }
            }

            List<QuestionBank> questionList = _context.QuestionBank.Where(w=>commaSeparatedQuestion.Contains(w.Id.ToString())).ToList();

            ViewBag.TotalQuestion = questionList.Count;
            ViewBag.TotalMarks = questionList.Sum(s => s.Mark);

             List<AnswersOption> answerOptionList = _context.AnswersOptions.Where(w => commaSeparatedQuestion.Contains(w.QuestionBank.Id.ToString())).ToList();

            List<Answer> answerList = _context.Answers.Where(w => commaSeparatedQuestion.Contains(w.QuestionBankId.ToString())).ToList();

            ViewBag.TotalAnswer = answerList.Count;
            int totalCorrect = 0;
            double totalObtainedMarks = 0;
            foreach (var item in questionList)
            {
                var mark = item.Mark;
                bool isCorrect = false;
                if (item.QuestionTypeId==1)
                {
                    int answerId = 0;
                    if (answerList.Count(w => w.QuestionBankId == item.Id) > 0)
                    {
                        answerId = Convert.ToInt32(answerList.Where(w => w.QuestionBankId == item.Id).FirstOrDefault().StudentAnswer);
                    }

                    int count = answerOptionList.Count(w => w.IsAnswer == 1 && w.Id == answerId);

                    if (count>0)
                    {
                        isCorrect = true;
                    }
                }
                else if (item.QuestionTypeId==2)
                {
                    
                    if (answerList.Count(w => w.QuestionBankId == item.Id) > 0)
                    {
                        int studentAnswerCount =answerList.Where(w => w.QuestionBankId == item.Id).FirstOrDefault().StudentAnswer.Split(',').Length;
                        int actualAnswerCount = answerOptionList.Count(w => w.IsAnswer == 1 && w.QuestionBank.Id == item.Id);

                        if (studentAnswerCount==actualAnswerCount)
                        {
                            isCorrect = true;
                        }
                    }
                }
                else if (item.QuestionTypeId==3)
                {
                    string studentAnswer = string.Empty;
                    string actualAnswer = answerOptionList.Where(w => w.QuestionBank.Id == item.Id).FirstOrDefault().Option;
                    if (answerList.Count(w => w.QuestionBankId == item.Id) > 0)
                    {
                        studentAnswer = answerList.Where(w => w.QuestionBankId == item.Id).FirstOrDefault().StudentAnswer;
                        if (string.Compare(studentAnswer,actualAnswer,true)==0)
                        {
                            isCorrect = true;
                        }
                    }
                }

                if (isCorrect)
                {
                    ++totalCorrect;
                    totalObtainedMarks += mark;
                }
            }

            ViewBag.TotalCorrect = totalCorrect;
            ViewBag.TotalObtainedMarks = totalObtainedMarks;
            var student = _context.Student.Find(examId);
            return PartialView ("_FinishExam", student);
        }
        

[HttpGet]
        public IActionResult _ShowQuestion()
        {
            return View();
        }

        //public JsonResult GetQuestionById(int Id)
        //{
        //    string test = "empty";
        //    return Json(test);
        //}

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

        [HttpGet]
        public JsonResult GetNextQuestion(int questionBankId)
        {
            QuestionBank questionBank = GetNextQuestionText(questionBankId);

            var answerOptions = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Option).ToList());
            List<String> qa = new List<string>();
            qa.Add(questionBank.QuestionTypeId.ToString());
            qa.Add(questionBank.Id.ToString());
            qa.Add(questionBank.Question); 
            qa.Add(answerOptions);

            var ids = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Id).ToList());

            qa.Add(ids);

            return Json(qa);
        }


        [HttpGet]
        public JsonResult GetQuestionById(int questionBankId)
        {
            QuestionBank questionBank = _context.QuestionBank.Where(w=>w.Id==questionBankId).FirstOrDefault();

            var answerOptions = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Option).ToList());
            List<String> qa = new List<string>();
            qa.Add(questionBank.QuestionTypeId.ToString());
            qa.Add(questionBank.Id.ToString());
            qa.Add(questionBank.Question);
            qa.Add(answerOptions);

            var ids = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Id).ToList());

            qa.Add(ids);

            return Json(qa);
        }


        [HttpGet]
        public JsonResult GetPrevQuestion(int questionBankId) 
        {

            var prevQuestionBankId = _context.TakeExamMapper
                .Where(q => q.QuestionBankId < questionBankId).Max(qb => qb.QuestionBankId);

            var questionBank = _context.QuestionBank
                                   .Where(q => q.Id == prevQuestionBankId)
                                   .FirstOrDefault();
            
            var answerOptions = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Option).ToList());
            List<String> qa = new List<string>();
            qa.Add(questionBank.QuestionTypeId.ToString());
            qa.Add(questionBank.Id.ToString());
            qa.Add(questionBank.Question);
            qa.Add(answerOptions);


            var ids = string.Join(',', _context.AnswersOptions.Where(w => w.QuestionBank.Id == questionBank.Id).Select(s => s.Id).ToList());

            qa.Add(ids);
            return Json(qa);
        }



        [HttpPost]
        public JsonResult SaveAnswers(string StudentEmail, int ExamId, int QuestionBankId, string StudentAnswer)
        {
            string message = SaveStudentAnswer(StudentEmail, ExamId, QuestionBankId, StudentAnswer);
            return Json(message);
        }        

        public string SaveStudentAnswer(string StudentEmail, int ExamId, int QuestionBankId, string StudentAnswer)
        {
            string message = string.Empty;
            try
            {
                Answer answerDetails = new Answer();
                answerDetails.StudentEmail = StudentEmail;
                answerDetails.ExamId = ExamId;
                answerDetails.QuestionBankId = QuestionBankId;
                answerDetails.StudentAnswer = StudentAnswer;

                _context.Add(answerDetails);
                _context.SaveChanges();

                message = "Save successfully";
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();           
            }
            return message;
        }

        private QuestionBank GetNextQuestionText(int questionBankId)
        {
            var NextQuestionBankId = _context.TakeExamMapper
                   .Where(q => q.QuestionBankId > questionBankId).Min(qb => qb.QuestionBankId);

            QuestionBank questionBank = _context.QuestionBank
                                   .Where(q => q.Id == NextQuestionBankId)
                                   .FirstOrDefault();
            return questionBank;
        }

        [HttpPost]
        public IActionResult SaveAnswersAndGetNextQuestion(string StudentEmail, int ExamId, int QuestionBankId, string StudentAnswer)
        {
            string message = SaveStudentAnswer(StudentEmail, ExamId, QuestionBankId, StudentAnswer);
            QuestionBank questionBank = GetNextQuestionText(QuestionBankId);
            return Json(questionBank);
        }

    }
}
