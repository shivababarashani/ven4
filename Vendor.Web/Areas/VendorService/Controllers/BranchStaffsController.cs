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
    public class BranchStaffsController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchStaffsController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchStaffs
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.BranchStaffs.Include(b => b.BranchStaffType);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/BranchStaffs/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaff = await _context.BranchStaffs
                .Include(b => b.BranchStaffType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchStaff == null)
            {
                return NotFound();
            }

            return View(branchStaff);
        }

        // GET: VendorService/BranchStaffs/Create
        public IActionResult Create()
        {
            ViewData["BranchStaffTypeId"] = new SelectList(_context.Set<BranchStaffType>(), "Id", "Id");
            return View();
        }

        // POST: VendorService/BranchStaffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TechnicalCount,NonTechnicalCount,BranchStaffTypeId,UploadInsurance")] BranchStaff branchStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BranchStaffTypeId"] = new SelectList(_context.Set<BranchStaffType>(), "Id", "Id", branchStaff.BranchStaffTypeId);
            return View(branchStaff);
        }

        // GET: VendorService/BranchStaffs/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaff = await _context.BranchStaffs.FindAsync(id);
            if (branchStaff == null)
            {
                return NotFound();
            }
            ViewData["BranchStaffTypeId"] = new SelectList(_context.Set<BranchStaffType>(), "Id", "Id", branchStaff.BranchStaffTypeId);
            return View(branchStaff);
        }

        // POST: VendorService/BranchStaffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TechnicalCount,NonTechnicalCount,BranchStaffTypeId,UploadInsurance")] BranchStaff branchStaff)
        {
            if (id != branchStaff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchStaffExists(branchStaff.Id))
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
            ViewData["BranchStaffTypeId"] = new SelectList(_context.Set<BranchStaffType>(), "Id", "Id", branchStaff.BranchStaffTypeId);
            return View(branchStaff);
        }

        // GET: VendorService/BranchStaffs/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaff = await _context.BranchStaffs
                .Include(b => b.BranchStaffType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchStaff == null)
            {
                return NotFound();
            }

            return View(branchStaff);
        }

        // POST: VendorService/BranchStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchStaff = await _context.BranchStaffs.FindAsync(id);
            _context.BranchStaffs.Remove(branchStaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchStaffExists(long id)
        {
            return _context.BranchStaffs.Any(e => e.Id == id);
        }
    }
}
