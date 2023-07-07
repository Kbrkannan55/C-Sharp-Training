using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalAPIProject.Models;

namespace FinalAPIProject.Controllers
{
    public class ProductdetailsController : Controller
    {
        private readonly FinalProjectContext _context;

        public ProductdetailsController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: Productdetails
        public async Task<IActionResult> Index()
        {
              return _context.Productdetails != null ? 
                          View(await _context.Productdetails.ToListAsync()) :
                          Problem("Entity set 'FinalProjectContext.Productdetails'  is null.");
        }

        // GET: Productdetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productdetails == null)
            {
                return NotFound();
            }

            var productdetail = await _context.Productdetails
                .FirstOrDefaultAsync(m => m.Productid == id);
            if (productdetail == null)
            {
                return NotFound();
            }

            return View(productdetail);
        }

        // GET: Productdetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productdetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Productid,Productname,Producttype,Quantity,Costperquantity")] Productdetail productdetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productdetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productdetail);
        }

        // GET: Productdetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Productdetails == null)
            {
                return NotFound();
            }

            var productdetail = await _context.Productdetails.FindAsync(id);
            if (productdetail == null)
            {
                return NotFound();
            }
            return View(productdetail);
        }

        // POST: Productdetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Productid,Productname,Producttype,Quantity,Costperquantity")] Productdetail productdetail)
        {
            if (id != productdetail.Productid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productdetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductdetailExists(productdetail.Productid))
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
            return View(productdetail);
        }

        // GET: Productdetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Productdetails == null)
            {
                return NotFound();
            }

            var productdetail = await _context.Productdetails
                .FirstOrDefaultAsync(m => m.Productid == id);
            if (productdetail == null)
            {
                return NotFound();
            }

            return View(productdetail);
        }

        // POST: Productdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Productdetails == null)
            {
                return Problem("Entity set 'FinalProjectContext.Productdetails'  is null.");
            }
            var productdetail = await _context.Productdetails.FindAsync(id);
            if (productdetail != null)
            {
                _context.Productdetails.Remove(productdetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductdetailExists(int id)
        {
          return (_context.Productdetails?.Any(e => e.Productid == id)).GetValueOrDefault();
        }
    }
}
