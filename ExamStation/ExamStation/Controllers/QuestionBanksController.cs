﻿using System;
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
    public class QuestionBanksController : Controller
    {
        private readonly ExamStationDbContext _context;

        public QuestionBanksController(ExamStationDbContext context)
        {
            _context = context;
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
            var questionBankList = _context.QuestionBank.AsEnumerable()
                                        .Select(qbl => new QuestionBank
                                        {
                                            Id = qbl.Id,
                                            Question = qbl.Question,
                                            DifficultyLevel = qbl.DifficultyLevel,
                                            QuestionGroup = qbl.QuestionGroup,
                                            QuestionType = qbl.QuestionType
                                        }).ToList();

            QuestionBankListViewModel.QuestionBankList = questionBankList;
            return View(QuestionBankListViewModel);
        }

        [HttpPost]
        public IActionResult QuestionGroupList(QuestionGroupListViewModel questionGroupListViewModel)
        {
            var QuestionBankListViewModel = new QuestionBankListViewModel();
            var questionBankList = _context.QuestionBank.AsEnumerable()
                                        .Select(qbl => new QuestionBank
                                        {
                                            Id = qbl.Id,
                                            Question = qbl.Question,
                                            DifficultyLevel = qbl.DifficultyLevel,
                                            QuestionGroup = qbl.QuestionGroup,
                                            QuestionType = qbl.QuestionType
                                        }).ToList();
            var QBListViewModel = new QuestionBankListViewModel();
            QBListViewModel.QuestionBankList = questionBankList;
            return View(QBListViewModel);
        }

        // GET: QuestionBanks/Create
        public IActionResult Create()
        {
            ViewBag.QuestionGroupList = _context.QuestionGroup.ToList();
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
                return RedirectToAction(nameof(Index));
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

        public JsonResult GetBankList(string questionBankList)
        {
            questionBankList = questionBankList.ToUpper();
            var qBankList = _context.QuestionBank
                .Where(a => a.QuestionGroup.ToUpper().Contains(questionBankList))
                .Select(a => new { a.Id, a.QuestionGroup });
            return Json(qBankList);
        }

        public JsonResult GetKeyword(string q)
        {
            string QuestionBankKeyword = q.ToUpper();
            var qBankList = _context.QuestionBank
                .Where(a => a.QuestionGroup.ToUpper().Contains(QuestionBankKeyword))
                .Select(a => new { a.Id, a.QuestionGroup });
            return Json(qBankList);
        }
    }
}