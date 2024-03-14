using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace HgtvMusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingerController : ControllerBase
    {
        private readonly MyDbContext _context;
       public SingerController(MyDbContext context) {
            _context = context;
            

       }
        // lay danh sach singer
        [HttpGet]
        public IActionResult GetAll() {
            var Singers = _context.Singers.ToList();
            return Ok(Singers);

        }
        // lay qua ID

        [HttpGet("id")]
        public IActionResult GetById(int id) {
            var Singers = _context.Singers.SingleOrDefault(si => si.IdSinger == id); 
            if (Singers == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Singers);
            }
        }

        // tao moi singer
        [HttpPost]
        public IActionResult CreateSinger(SingerModel model)
        {
            try {
                var singer = new Singer
                {
                    NameSinger = model.NameSinger,
                    Follower = model.Follower,
                    Path_Img = model.Path_Img,
                };
                _context.Add(singer);
                _context.SaveChanges();
                return Ok(singer);
            }
            catch {
                return BadRequest();
            }
            
        }


        // chinh sua singer.
        [HttpPut("id")]
        public IActionResult UpdateSingerById(int id, SingerModel model)
        {
            var si = _context.Singers.SingleOrDefault(si => si.IdSinger == id);
            if (si == null)
            {
                return NotFound();
            }
            else
            {   
                si.NameSinger = model.NameSinger;
                si.Follower = model.Follower;
                si.Path_Img = model.Path_Img;
                _context.SaveChanges();
                return NoContent();
            }
        }

    }   
}

