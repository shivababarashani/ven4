using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Cars;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CarsController : Controller
    {
        private readonly VendorDbContext _context;
        private readonly IWebHostEnvironment _enviroment;

        public CarsController(VendorDbContext context,IWebHostEnvironment enviroment)
        {
            _context = context;
            _enviroment = enviroment;
        }

        // GET: VendorService/Cars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        // GET: VendorService/Cars/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: VendorService/Cars/Create
        public IActionResult Create()
        {
            ViewData["CarTypeId"] = new SelectList(_context.CarTypes, "Id", "Name");
            ViewData["ContryId"] = new SelectList(_context.Contries, "Id", "Name");
            return View();
        }

        // POST: VendorService/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Count,Capacity,Description,CarTypeId,ContryId")] Car car, string ManufactureDate)
        {
            DateTime sdate = Convert.ToDateTime(ManufactureDate);
            if (ModelState.IsValid)
            {
                car.ManufactureDate = sdate;
                _context.Add(car);
                await _context.SaveChangesAsync();
                ViewData["CarTypeId"] = new SelectList(_context.CarTypes, "Id", "Id", car.CarType.Id);
                ViewData["ContryId"] = new SelectList(_context.Contries, "Id", "Id", car.Contry.Id);

                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: VendorService/Cars/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: VendorService/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Count,Capacity,Description")] Car car, string ManufactureDate)
        {
            DateTime sdate = Convert.ToDateTime(ManufactureDate);
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    car.ManufactureDate = sdate;
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
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
            return View(car);
        }

        // GET: VendorService/Cars/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: VendorService/Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(long id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
