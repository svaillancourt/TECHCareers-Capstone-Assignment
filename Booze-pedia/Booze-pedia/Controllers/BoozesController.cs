using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booze_pedia.Data;
using Booze_pedia.Models;

namespace Booze_pedia.Controllers
{
    public class BoozesController : Controller
    {
        private readonly BoozeContext _context;

        public BoozesController(BoozeContext context)
        {
            _context = context;
        }

        // GET: Boozes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Booze.ToListAsync());
        }

        // GET: Boozes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booze = await _context.Booze
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booze == null)
            {
                return NotFound();
            }

            return View(booze);
        }

        // GET: Boozes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boozes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Category,Description,Quantity,Price,InStock")] Booze booze)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booze);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booze);
        }

        // GET: Boozes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booze = await _context.Booze.FindAsync(id);
            if (booze == null)
            {
                return NotFound();
            }
            return View(booze);
        }

        // POST: Boozes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Description,Quantity,Price,InStock")] Booze booze)
        {
            if (id != booze.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booze);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoozeExists(booze.Id))
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
            return View(booze);
        }

        // GET: Boozes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booze = await _context.Booze
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booze == null)
            {
                return NotFound();
            }

            return View(booze);
        }

        // POST: Boozes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booze = await _context.Booze.FindAsync(id);
            _context.Booze.Remove(booze);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoozeExists(int id)
        {
            return _context.Booze.Any(e => e.Id == id);
        }
    }
}
