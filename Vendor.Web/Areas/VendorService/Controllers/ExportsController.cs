using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Exports;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class ExportsController : Controller
    {
        private readonly VendorDbContext _context;

        public ExportsController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/Exports
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.Exports.Include(e => e.Product);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/Exports/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var export = await _context.Exports
                .Include(e => e.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (export == null)
            {
                return NotFound();
            }

            return View(export);
        }

        // GET: VendorService/Exports/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: VendorService/Exports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Employer,ContractNumber,WeightNumber,Description,UserId,ProductId")] Export export)
        {
            if (ModelState.IsValid)
            {
                _context.Add(export);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", export.ProductId);
            return View(export);
        }

        // GET: VendorService/Exports/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var export = await _context.Exports.FindAsync(id);
            if (export == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", export.ProductId);
            return View(export);
        }

        // POST: VendorService/Exports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Year,Employer,ContractNumber,WeightNumber,Description,UserId,ProductId")] Export export)
        {
            if (id != export.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(export);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExportExists(export.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", export.ProductId);
            return View(export);
        }

        // GET: VendorService/Exports/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var export = await _context.Exports
                .Include(e => e.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (export == null)
            {
                return NotFound();
            }

            return View(export);
        }

        // POST: VendorService/Exports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var export = await _context.Exports.FindAsync(id);
            _context.Exports.Remove(export);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExportExists(long id)
        {
            return _context.Exports.Any(e => e.Id == id);
        }
    }
}
