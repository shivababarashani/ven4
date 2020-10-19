using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Branch;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class BranchInfrastructuresController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchInfrastructuresController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchInfrastructures
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.BranchInfrastructures.Include(b => b.BranchInfrastructureType);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/BranchInfrastructures/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructure = await _context.BranchInfrastructures
                .Include(b => b.BranchInfrastructureType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchInfrastructure == null)
            {
                return NotFound();
            }

            return View(branchInfrastructure);
        }

        // GET: VendorService/BranchInfrastructures/Create
        public IActionResult Create()
        {
            ViewData["BranchInfrastructureTypeId"] = new SelectList(_context.BranchInfrastructureType, "Id", "Id");
            return View();
        }

        // POST: VendorService/BranchInfrastructures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Area,BranchInfrastructureTypeId,InfrastructureType,UploadOwnershipDocuments")] BranchInfrastructure branchInfrastructure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchInfrastructure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BranchInfrastructureTypeId"] = new SelectList(_context.BranchInfrastructureType, "Id", "Id", branchInfrastructure.BranchInfrastructureTypeId);
            return View(branchInfrastructure);
        }

        // GET: VendorService/BranchInfrastructures/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructure = await _context.BranchInfrastructures.FindAsync(id);
            if (branchInfrastructure == null)
            {
                return NotFound();
            }
            ViewData["BranchInfrastructureTypeId"] = new SelectList(_context.BranchInfrastructureType, "Id", "Id", branchInfrastructure.BranchInfrastructureTypeId);
            return View(branchInfrastructure);
        }

        // POST: VendorService/BranchInfrastructures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Area,BranchInfrastructureTypeId,InfrastructureType,UploadOwnershipDocuments")] BranchInfrastructure branchInfrastructure)
        {
            if (id != branchInfrastructure.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchInfrastructure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchInfrastructureExists(branchInfrastructure.Id))
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
            ViewData["BranchInfrastructureTypeId"] = new SelectList(_context.BranchInfrastructureType, "Id", "Id", branchInfrastructure.BranchInfrastructureTypeId);
            return View(branchInfrastructure);
        }

        // GET: VendorService/BranchInfrastructures/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructure = await _context.BranchInfrastructures
                .Include(b => b.BranchInfrastructureType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchInfrastructure == null)
            {
                return NotFound();
            }

            return View(branchInfrastructure);
        }

        // POST: VendorService/BranchInfrastructures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchInfrastructure = await _context.BranchInfrastructures.FindAsync(id);
            _context.BranchInfrastructures.Remove(branchInfrastructure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchInfrastructureExists(long id)
        {
            return _context.BranchInfrastructures.Any(e => e.Id == id);
        }
    }
}
