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
    public class BranchAddressesController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchAddressesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchAddresses
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.BranchAddresses.Include(b => b.BranchInfrastructure).Include(b => b.BranchStaff).Include(b => b.BranchType);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/BranchAddresses/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchAddress = await _context.BranchAddresses
                .Include(b => b.BranchInfrastructure)
                .Include(b => b.BranchStaff)
                .Include(b => b.BranchType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchAddress == null)
            {
                return NotFound();
            }

            return View(branchAddress);
        }

        // GET: VendorService/BranchAddresses/Create
        public IActionResult Create()
        {
            ViewData["BranchInfrastructureId"] = new SelectList(_context.BranchInfrastructures, "Id", "Id");
            ViewData["BranchStaffId"] = new SelectList(_context.BranchStaffs, "Id", "Id");
            ViewData["BranchTypeId"] = new SelectList(_context.BranchTypes, "Id", "Id");
            return View();
        }

        // POST: VendorService/BranchAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Address,PostalCode,Tel,Fax,Email,Website,BranchTypeId,BranchStaffId,BranchInfrastructureId,UserId")] BranchAddress branchAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BranchInfrastructureId"] = new SelectList(_context.BranchInfrastructures, "Id", "Id", branchAddress.BranchInfrastructureId);
            ViewData["BranchStaffId"] = new SelectList(_context.BranchStaffs, "Id", "Id", branchAddress.BranchStaffId);
            ViewData["BranchTypeId"] = new SelectList(_context.BranchTypes, "Id", "Id", branchAddress.BranchTypeId);
            return View(branchAddress);
        }

        // GET: VendorService/BranchAddresses/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchAddress = await _context.BranchAddresses.FindAsync(id);
            if (branchAddress == null)
            {
                return NotFound();
            }
            ViewData["BranchInfrastructureId"] = new SelectList(_context.BranchInfrastructures, "Id", "Id", branchAddress.BranchInfrastructureId);
            ViewData["BranchStaffId"] = new SelectList(_context.BranchStaffs, "Id", "Id", branchAddress.BranchStaffId);
            ViewData["BranchTypeId"] = new SelectList(_context.BranchTypes, "Id", "Id", branchAddress.BranchTypeId);
            return View(branchAddress);
        }

        // POST: VendorService/BranchAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Address,PostalCode,Tel,Fax,Email,Website,BranchTypeId,BranchStaffId,BranchInfrastructureId,UserId")] BranchAddress branchAddress)
        {
            if (id != branchAddress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchAddressExists(branchAddress.Id))
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
            ViewData["BranchInfrastructureId"] = new SelectList(_context.BranchInfrastructures, "Id", "Id", branchAddress.BranchInfrastructureId);
            ViewData["BranchStaffId"] = new SelectList(_context.BranchStaffs, "Id", "Id", branchAddress.BranchStaffId);
            ViewData["BranchTypeId"] = new SelectList(_context.BranchTypes, "Id", "Id", branchAddress.BranchTypeId);
            return View(branchAddress);
        }

        // GET: VendorService/BranchAddresses/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchAddress = await _context.BranchAddresses
                .Include(b => b.BranchInfrastructure)
                .Include(b => b.BranchStaff)
                .Include(b => b.BranchType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchAddress == null)
            {
                return NotFound();
            }

            return View(branchAddress);
        }

        // POST: VendorService/BranchAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchAddress = await _context.BranchAddresses.FindAsync(id);
            _context.BranchAddresses.Remove(branchAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchAddressExists(long id)
        {
            return _context.BranchAddresses.Any(e => e.Id == id);
        }
    }
}
