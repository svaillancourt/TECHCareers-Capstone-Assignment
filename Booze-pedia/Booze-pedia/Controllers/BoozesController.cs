// Controller for listing the liquor list which contains Index, Create, Details, Edit, Delete methods.
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

        //Constructor for class which host web environment and context
        public BoozesController(BoozeContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Boozes This function is list out all liquor list in the application
        public async Task<IActionResult> Index(string boozeCategory, string searchString, bool inStockSearchString)
        {
            // Use LINQ to get list of Liquors by category
            IQueryable<string> categoryQuery = from m in _context.Booze
                                            orderby m.Category
                                            select m.Category;

            var boozes = from m in _context.Booze
                         select m;

            //search by name and descriptoion of liquor query
            if (!string.IsNullOrEmpty(searchString))
            {
                boozes = boozes.Where(s => ((s.Name.Contains(searchString ) || (s.Description.Contains(searchString))) && (s.InStock == inStockSearchString)));
            }
            
            //search by stock (true or false) of liquor query
            if(inStockSearchString == true)
            {
                boozes = boozes.Where(i => i.InStock == inStockSearchString);
            }

            // If Liquor Category is not null then it will filter the list.
            if (!string.IsNullOrEmpty(boozeCategory))
            {
                boozes = boozes.Where(x => ((x.Category == boozeCategory) ));
            }

            //This logic devides liquor list by category and wait for asyc.
            var boozeCategoryVM = new BoozeCategoryViewModel
            {
                Category = new SelectList(await categoryQuery.Distinct().ToListAsync()),
                Boozes = await boozes.ToListAsync()
            };

            //return view of booze category which connect BoozeCategoryViewModel class
            return View(boozeCategoryVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // This is method for details of liquor part.
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

        // This method is for creating the Liquor which return the whole view create.cshtml
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
                // Saves the images to wwwroot/img
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

        // This method runs for edit the data of perticulart list which passes id as parameter.
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

        // Here the method name is DeleteConfirmed which run "Delete Action". we have already delete method
        // Due to preventing method overloading its a different name.
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
