using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcGym.Data;
using MvcGym.Models;

namespace MvcGym.Controllers
{
    public class GoiTapController : Controller
    {
        private readonly MvcGymContext _context;

        public GoiTapController(MvcGymContext context)
        {
            _context = context;
        }

        // GET: GoiTap
        public async Task<IActionResult> Index()
        {
            var mvcGymContext = _context.GoiTap.Include(g => g.GiaGoi);
            return View(await mvcGymContext.ToListAsync());
        }

        // GET: GoiTap/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goiTap = await _context.GoiTap
                .Include(g => g.GiaGoi)
                .FirstOrDefaultAsync(m => m.GoiID == id);
            if (goiTap == null)
            {
                return NotFound();
            }

            return View(goiTap);
        }

        // GET: GoiTap/Create
        public IActionResult Create()
        {
            ViewData["MaGoiTap"] = new SelectList(_context.Set<GiaGoi>(), "MaGiaGoi", "MaGiaGoi");
            return View();
        }

        // POST: GoiTap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GoiID,MaGoiTap")] GoiTap goiTap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goiTap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaGoiTap"] = new SelectList(_context.Set<GiaGoi>(), "MaGiaGoi", "MaGiaGoi", goiTap.MaGoiTap);
            return View(goiTap);
        }

        // GET: GoiTap/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goiTap = await _context.GoiTap.FindAsync(id);
            if (goiTap == null)
            {
                return NotFound();
            }
            ViewData["MaGoiTap"] = new SelectList(_context.Set<GiaGoi>(), "MaGiaGoi", "MaGiaGoi", goiTap.MaGoiTap);
            return View(goiTap);
        }

        // POST: GoiTap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("GoiID,MaGoiTap")] GoiTap goiTap)
        {
            if (id != goiTap.GoiID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goiTap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoiTapExists(goiTap.GoiID))
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
            ViewData["MaGoiTap"] = new SelectList(_context.Set<GiaGoi>(), "MaGiaGoi", "MaGiaGoi", goiTap.MaGoiTap);
            return View(goiTap);
        }

        // GET: GoiTap/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goiTap = await _context.GoiTap
                .Include(g => g.GiaGoi)
                .FirstOrDefaultAsync(m => m.GoiID == id);
            if (goiTap == null)
            {
                return NotFound();
            }

            return View(goiTap);
        }

        // POST: GoiTap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var goiTap = await _context.GoiTap.FindAsync(id);
            _context.GoiTap.Remove(goiTap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoiTapExists(string id)
        {
            return _context.GoiTap.Any(e => e.GoiID == id);
        }
    }
}
