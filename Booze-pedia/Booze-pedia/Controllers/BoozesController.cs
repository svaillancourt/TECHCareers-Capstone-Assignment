using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booze_pedia.Data;
using Booze_pedia.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Booze_pedia.Controllers
{
    [Authorize]
    public class BoozesController : Controller
    {
        private readonly BoozeContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BoozesController(BoozeContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Boozes
        public async Task<IActionResult> Index(string boozeCategory, string searchString, bool inStockSearchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> categoryQuery = from m in _context.Booze
                                            orderby m.Category
                                            select m.Category;

            var boozes = from m in _context.Booze
                         select m;

            //search by name and descriptoion
            if (!string.IsNullOrEmpty(searchString))
            {
                boozes = boozes.Where(s => ((s.Name.Contains(searchString ) || (s.Description.Contains(searchString))) && (s.InStock == inStockSearchString)));
            }
            
            if(inStockSearchString == true)
            {
                boozes = boozes.Where(i => i.InStock == inStockSearchString);
            }

            if (!string.IsNullOrEmpty(boozeCategory))
            {
                boozes = boozes.Where(x => ((x.Category == boozeCategory) ));
            }

            var boozeCategoryVM = new BoozeCategoryViewModel
            {
                Category = new SelectList(await categoryQuery.Distinct().ToListAsync()),
                Boozes = await boozes.ToListAsync()
            };

            return View(boozeCategoryVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
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
        public async Task<IActionResult> Create([Bind("Id,Name,Category,Description,Quantity,Price,InStock,PictureFile")] Booze booze)
        {
            if (ModelState.IsValid)
            {
                // IActionResult methods code: http://www.codaffection.com/asp-net-core-article/asp-net-core-mvc-image-upload-and-retrieve/
                // Saves the images to wwwroot/img.
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(booze.PictureFile.FileName);
                string extension = Path.GetExtension(booze.PictureFile.FileName);
                booze.PictureName=fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/img/", fileName);
                using (var fileStream = new FileStream(path,FileMode.Create))
                {
                    await booze.PictureFile.CopyToAsync(fileStream);
                }
                // Insert record
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Description,Quantity,Price,InStock,PictureFile")] Booze booze)
        {
            if (id != booze.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Edit with new picture.
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(booze.PictureFile.FileName);
                    string extension = Path.GetExtension(booze.PictureFile.FileName);
                    booze.PictureName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/img/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await booze.PictureFile.CopyToAsync(fileStream);
                    }

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

            // Delete image from wwwroot/img
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "img", booze.PictureName);
            if (System.IO.File.Exists(imagePath))
            // Delete the record
                System.IO.File.Delete(imagePath);

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
