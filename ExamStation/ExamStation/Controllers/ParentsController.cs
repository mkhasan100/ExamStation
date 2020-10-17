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
    public class ParentsController : Controller
    {
        private readonly ExamStationDbContext _context;
        
        public ParentsController(ExamStationDbContext context)
        {
            _context = context;
            
        }

        // GET: Parents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parent.ToListAsync());
        }

        // GET: Parents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parent = await _context.Parent
                .FirstOrDefaultAsync(m => m.GuardianId == id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        [HttpGet]
        public IActionResult ParentList()
        {
            var ParentListViewModel = new ParentListViewModel();
            var parentList = _context.Parent.AsEnumerable()
                                        .Select(p => new Parent
                                        {
                                            GuardianId = p.GuardianId,
                                            GuardianName = p.GuardianName,
                                            Email = p.Email,
                                            Photo = p.Photo
                                        }).ToList();

            ParentListViewModel.ParentList = parentList;
            return View(ParentListViewModel);
        }

        [HttpPost]
        public IActionResult ParentList(ParentListViewModel parentListViewModel)
        {
            var ParentListViewModel = new ParentListViewModel();
            var parentList = _context.Parent.AsEnumerable()
                                       .Select(p => new Parent
                                       {
                                           GuardianId = p.GuardianId,
                                           GuardianName = p.GuardianName,
                                           Email = p.Email,
                                           Photo = p.Photo
                                       }).ToList();
            var PListViewModel = new ParentListViewModel();
            PListViewModel.ParentList = parentList;
            return View(ParentListViewModel);
        }

        // GET: Parents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GuardianId,GuardianName,FatherName,MotherName,FatherProfession,MotherProfession,Email,Phone,Address,Photo")] Parent parent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parent);
        }

        // GET: Parents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parent = await _context.Parent.FindAsync(id);
            if (parent == null)
            {
                return NotFound();
            }
            return View(parent);
        }

        // POST: Parents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GuardianId,GuardianName,FatherName,MotherName,FatherProfession,MotherProfession,Email,Phone,Address,Photo")] Parent parent)
        {
            if (id != parent.GuardianId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentExists(parent.GuardianId))
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
            return View(parent);
        }

        // GET: Parents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parent = await _context.Parent
                .FirstOrDefaultAsync(m => m.GuardianId == id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        // POST: Parents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parent = await _context.Parent.FindAsync(id);
            _context.Parent.Remove(parent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentExists(int id)
        {
            return _context.Parent.Any(e => e.GuardianId == id);
        }

        public JsonResult ParentList(string parentList)
        {
            parentList = parentList.ToUpper();
            var pList = _context.Parent
                .Where(a => a.GuardianName.ToUpper().Contains(parentList))
                .Select(a => new { a.GuardianId, a.GuardianName });
            return Json(pList);
        }

        public JsonResult GetKeyword(string q)
        {
            string ParentKeyword = q.ToUpper();
            var pList = _context.Parent
                .Where(a => a.GuardianName.ToUpper().Contains(ParentKeyword))
                .Select(a => new { a.GuardianId, a.GuardianName });
            return Json(pList);
        }
    }
}
