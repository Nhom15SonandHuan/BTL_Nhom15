using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymRoom.Models;
using GymRoom.Data;

namespace GymRoom.Controllers
{
    public class ThietBiController : Controller
    {
        private readonly GymRoomContext _context;

        public ThietBiController(GymRoomContext context)
        {
            _context = context;
        }

        // GET: ThietBi
        public async Task<IActionResult> Index()
        {
            var gymRoomContext = _context.ThietBi.Include(t => t.TinhTrang);
            return View(await gymRoomContext.ToListAsync());
        }

        // GET: ThietBi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi
                .Include(t => t.TinhTrang)
                .FirstOrDefaultAsync(m => m.MaTB == id);
            if (thietBi == null)
            {
                return NotFound();
            }

            return View(thietBi);
        }

        // GET: ThietBi/Create
        public IActionResult Create()
        {
            ViewData["MaTinhTrang"] = new SelectList(_context.Set<TinhTrang>(), "MaTinhTrang", "TinhTrangND");
            return View();
        }

        // POST: ThietBi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTB,TenTB,size,Soluong,MaTinhTrang")] ThietBi thietBi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thietBi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaTinhTrang"] = new SelectList(_context.Set<TinhTrang>(), "MaTinhTrang", "TinhTrangND", thietBi.MaTinhTrang);
            return View(thietBi);
        }

        // GET: ThietBi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi.FindAsync(id);
            if (thietBi == null)
            {
                return NotFound();
            }
            ViewData["MaTinhTrang"] = new SelectList(_context.Set<TinhTrang>(), "MaTinhTrang", "TinhTrangND", thietBi.MaTinhTrang);
            return View(thietBi);
        }

        // POST: ThietBi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaTB,TenTB,size,Soluong,MaTinhTrang")] ThietBi thietBi)
        {
            if (id != thietBi.MaTB)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thietBi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThietBiExists(thietBi.MaTB))
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
            ViewData["MaTinhTrang"] = new SelectList(_context.Set<TinhTrang>(), "MaTinhTrang", "TinhTrangND", thietBi.MaTinhTrang);
            return View(thietBi);
        }

        // GET: ThietBi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thietBi = await _context.ThietBi
                .Include(t => t.TinhTrang)
                .FirstOrDefaultAsync(m => m.MaTB == id);
            if (thietBi == null)
            {
                return NotFound();
            }

            return View(thietBi);
        }

        // POST: ThietBi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var thietBi = await _context.ThietBi.FindAsync(id);
            _context.ThietBi.Remove(thietBi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThietBiExists(string id)
        {
            return _context.ThietBi.Any(e => e.MaTB == id);
        }
    }
}
