﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppShopOnline.Areas.Identity.Data;
using AppShopOnline.Models;

namespace AppShopOnline.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class ColorsController : Controller
    {
        private readonly AppShopOnlineDbContext _context;

        public ColorsController(AppShopOnlineDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Colors
        public async Task<IActionResult> Index()
        {
              return View(await _context.Color.ToListAsync());
        }

        // GET: Admins/Colors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Color == null)
            {
                return NotFound();
            }

            var color = await _context.Color
                .FirstOrDefaultAsync(m => m.ColorId == id);
            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        // GET: Admins/Colors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Colors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ColorId,ColorName")] Color color)
        {
            if (ModelState.IsValid)
            {
                _context.Add(color);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(color);
        }

        // GET: Admins/Colors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Color == null)
            {
                return NotFound();
            }

            var color = await _context.Color.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }
            return View(color);
        }

        // POST: Admins/Colors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ColorId,ColorName")] Color color)
        {
            if (id != color.ColorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(color);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColorExists(color.ColorId))
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
            return View(color);
        }

        // GET: Admins/Colors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Color == null)
            {
                return NotFound();
            }

            var color = await _context.Color
                .FirstOrDefaultAsync(m => m.ColorId == id);
            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        // POST: Admins/Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Color == null)
            {
                return Problem("Entity set 'AppShopOnlineDbContext.Color'  is null.");
            }
            var color = await _context.Color.FindAsync(id);
            if (color != null)
            {
                _context.Color.Remove(color);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColorExists(int id)
        {
          return _context.Color.Any(e => e.ColorId == id);
        }
    }
}
