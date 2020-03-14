using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testExperis.Data;
using testExperis.Models;

namespace testExperis.Controllers
{
    public class SalonesController : Controller
    {
        private readonly AlumnosContext _context;

        public SalonesController(AlumnosContext context)
        {
            _context = context;
        }

        // GET: Salones
        public async Task<IActionResult> Index()
        {
            return View(await _context.salones.ToListAsync());
        }

        // GET: Salones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salones = await _context.salones
                .FirstOrDefaultAsync(m => m.id == id);
            if (salones == null)
            {
                return NotFound();
            }

            return View(salones);
        }

        // GET: Salones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,sede,letra,numero,estado")] Salones salones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salones);
        }

        // GET: Salones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salones = await _context.salones.FindAsync(id);
            if (salones == null)
            {
                return NotFound();
            }
            return View(salones);
        }

        // POST: Salones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,sede,letra,numero,estado")] Salones salones)
        {
            if (id != salones.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalonesExists(salones.id))
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
            return View(salones);
        }

        // GET: Salones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salones = await _context.salones
                .FirstOrDefaultAsync(m => m.id == id);
            if (salones == null)
            {
                return NotFound();
            }

            return View(salones);
        }

        // POST: Salones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salones = await _context.salones.FindAsync(id);
            _context.salones.Remove(salones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalonesExists(int id)
        {
            return _context.salones.Any(e => e.id == id);
        }
    }
}
