﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HgtvMusicAPI.Data;

namespace HgtvMusicAPI.Controllers
{
    public class SongController : Controller
    {
        private readonly MyDbContext _context;

        public SongController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Song
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Songs.Include(s => s.Album).Include(s => s.Category).Include(s => s.Singer);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Song/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Album)
                .Include(s => s.Category)
                .Include(s => s.Singer)
                .FirstOrDefaultAsync(m => m.IdSong == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Song/Create
        public IActionResult Create()
        {
            ViewData["IdAlbum"] = new SelectList(_context.Albums, "IdAlbum", "NameAlbum");
            ViewData["IdCategory"] = new SelectList(_context.Set<Category>(), "IdCategory", "NameCategory");
            ViewData["IdSinger"] = new SelectList(_context.Singers, "IdSinger", "NameSinger");
            return View();
        }

        // POST: Song/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSong,NameSong,Path_Img,IdCategory,IdSinger,IdAlbum")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAlbum"] = new SelectList(_context.Albums, "IdAlbum", "NameAlbum", song.IdAlbum);
            ViewData["IdCategory"] = new SelectList(_context.Set<Category>(), "IdCategory", "NameCategory", song.IdCategory);
            ViewData["IdSinger"] = new SelectList(_context.Singers, "IdSinger", "NameSinger", song.IdSinger);
            return View(song);
        }

        // GET: Song/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            ViewData["IdAlbum"] = new SelectList(_context.Albums, "IdAlbum", "NameAlbum", song.IdAlbum);
            ViewData["IdCategory"] = new SelectList(_context.Set<Category>(), "IdCategory", "NameCategory", song.IdCategory);
            ViewData["IdSinger"] = new SelectList(_context.Singers, "IdSinger", "NameSinger", song.IdSinger);
            return View(song);
        }

        // POST: Song/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSong,NameSong,Path_Img,IdCategory,IdSinger,IdAlbum")] Song song)
        {
            if (id != song.IdSong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.IdSong))
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
            ViewData["IdAlbum"] = new SelectList(_context.Albums, "IdAlbum", "NameAlbum", song.IdAlbum);
            ViewData["IdCategory"] = new SelectList(_context.Set<Category>(), "IdCategory", "NameCategory", song.IdCategory);
            ViewData["IdSinger"] = new SelectList(_context.Singers, "IdSinger", "NameSinger", song.IdSinger);
            return View(song);
        }

        // GET: Song/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Album)
                .Include(s => s.Category)
                .Include(s => s.Singer)
                .FirstOrDefaultAsync(m => m.IdSong == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Song/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            if (song != null)
            {
                _context.Songs.Remove(song);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
            return _context.Songs.Any(e => e.IdSong == id);
        }
    }
}
