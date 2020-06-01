using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Booze_pedia_API.Models;

namespace Booze_pedia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoozeItemsController : ControllerBase
    {
        private readonly BoozeContext _context;

        public BoozeItemsController(BoozeContext context)
        {
            _context = context;
        }

        // GET: api/BoozeItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoozeItem>>> GetBoozeItems()
        {
            return await _context.BoozeItems.ToListAsync();
        }

        // GET: api/BoozeItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoozeItem>> GetBoozeItem(int id)
        {
            var boozeItem = await _context.BoozeItems.FindAsync(id);

            if (boozeItem == null)
            {
                return NotFound();
            }

            return boozeItem;
        }

        // PUT: api/BoozeItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoozeItem(int id, BoozeItem boozeItem)
        {
            if (id != boozeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(boozeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoozeItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BoozeItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BoozeItem>> PostBoozeItem(BoozeItem boozeItem)
        {
            _context.BoozeItems.Add(boozeItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoozeItem", new { id = boozeItem.Id }, boozeItem);
        }

        // DELETE: api/BoozeItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BoozeItem>> DeleteBoozeItem(int id)
        {
            var boozeItem = await _context.BoozeItems.FindAsync(id);
            if (boozeItem == null)
            {
                return NotFound();
            }

            _context.BoozeItems.Remove(boozeItem);
            await _context.SaveChangesAsync();

            return boozeItem;
        }

        private bool BoozeItemExists(int id)
        {
            return _context.BoozeItems.Any(e => e.Id == id);
        }
    }
}
