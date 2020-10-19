using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Contracts;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class ContractTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public ContractTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/ContractTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContractTypes.ToListAsync());
        }

        // GET: VendorService/ContractTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractType == null)
            {
                return NotFound();
            }

            return View(contractType);
        }

        // GET: VendorService/ContractTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/ContractTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type")] ContractType contractType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contractType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contractType);
        }

        // GET: VendorService/ContractTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractTypes.FindAsync(id);
            if (contractType == null)
            {
                return NotFound();
            }
            return View(contractType);
        }

        // POST: VendorService/ContractTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Type")] ContractType contractType)
        {
            if (id != contractType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contractType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractTypeExists(contractType.Id))
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
            return View(contractType);
        }

        // GET: VendorService/ContractTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractType == null)
            {
                return NotFound();
            }

            return View(contractType);
        }

        // POST: VendorService/ContractTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var contractType = await _context.ContractTypes.FindAsync(id);
            _context.ContractTypes.Remove(contractType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractTypeExists(long id)
        {
            return _context.ContractTypes.Any(e => e.Id == id);
        }

        
    }
}
