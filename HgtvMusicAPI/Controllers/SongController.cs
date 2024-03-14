using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace HgtvMusicAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
        private readonly MyDbContext _context;
        public SongController(MyDbContext context)
        {
            _context = context;


        }
        // lay danh sach Song
        [HttpGet]
        public IActionResult GetAll()
        {
            var songs = _context.Singers.ToList();
            return Ok(songs);

        }
        // lay Song qua ID

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var songs = _context.Songs.SingleOrDefault(si => si.IdSong == id);
            if (songs == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(songs);
            }
        }

        // tao moi song
        [HttpPost]
        public IActionResult CreateSong(SongModel model)
        {
            try
            {
                var song = new Song
                {
                    NameSong = model.NameSong,
                    Path_Img = model.Path_Img,
                };
                _context.Add(song);
                _context.SaveChanges();
                return Ok(song);
            }
            catch
            {
                return BadRequest();
            }

        }


        // chinh sua song.
        [HttpPut("id")]
        public IActionResult UpdateSingerById(int id, SongModel model)
        {
            var so = _context.Songs.SingleOrDefault(si => si.IdSong == id);
            if (so == null)
            {
                return NotFound();
            }
            else
            {
                so.NameSong = model.NameSong;
                so.Path_Img = model.Path_Img;
                _context.SaveChanges();
                return NoContent();
            }
        }

        //Xoa ban ghi voi ID
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                var song = _context.Songs.FirstOrDefault(e => e.IdSinger == id);
                if (song != null)
                {
                    _context.Songs.Remove(song);
                    _context.SaveChanges();
                    return Ok($"Deleted item with ID: {id}");
                }
                return Ok($"Deleted item with ID: {id}");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Error deleting item with ID: {id}. Error message: {ex.Message}");
                return StatusCode(500, $"Error deleting item with ID: {id}");
            }
        }

    }
}
