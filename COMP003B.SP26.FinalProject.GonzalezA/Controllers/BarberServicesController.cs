using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP003B.SP26.FinalProject.GonzalezA.Data;
using COMP003B.SP26.FinalProject.GonzalezA.Models;

namespace COMP003B.SP26.FinalProject.GonzalezA.Controllers
{
    public class BarberServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarberServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BarberServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.BarberServices.ToListAsync());
        }

        // GET: BarberServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barberService = await _context.BarberServices
                .FirstOrDefaultAsync(m => m.BarberServiceId == id);
            if (barberService == null)
            {
                return NotFound();
            }

            return View(barberService);
        }

        // GET: BarberServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BarberServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BarberServiceId,ServiceName,Description,Price,EstimatedMinutes")] BarberService barberService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(barberService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(barberService);
        }

        // GET: BarberServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barberService = await _context.BarberServices.FindAsync(id);
            if (barberService == null)
            {
                return NotFound();
            }
            return View(barberService);
        }

        // POST: BarberServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BarberServiceId,ServiceName,Description,Price,EstimatedMinutes")] BarberService barberService)
        {
            if (id != barberService.BarberServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(barberService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BarberServiceExists(barberService.BarberServiceId))
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
            return View(barberService);
        }

        // GET: BarberServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barberService = await _context.BarberServices
                .FirstOrDefaultAsync(m => m.BarberServiceId == id);
            if (barberService == null)
            {
                return NotFound();
            }

            return View(barberService);
        }

        // POST: BarberServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var barberService = await _context.BarberServices.FindAsync(id);
            if (barberService != null)
            {
                _context.BarberServices.Remove(barberService);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BarberServiceExists(int id)
        {
            return _context.BarberServices.Any(e => e.BarberServiceId == id);
        }
    }
}
