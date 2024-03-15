using HgtvMusicAPI.Models;
using HgtvMusicAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HgtvMusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingersController : ControllerBase
    {
        private readonly ISingerRepository _singerRepository;
    
        public SingersController(ISingerRepository singerRepository)
        {
            _singerRepository = singerRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {

                return Ok(_singerRepository.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
          
            try
            {
                var data = _singerRepository.GetById(id);
                if(data != null) {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
                
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("id")]
        public IActionResult UpdateSingerById(int id, SingerVM model)
        {
            if(id != model.IdSinger)
            {
                return BadRequest();
            }
            try
            {
                _singerRepository.UpdateSingerById(model);
                return NoContent();

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                _singerRepository.Delete(id);
                return Ok();

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult CreateSinger(SingerModel model)
        {
            try
            {
                
                return Ok(_singerRepository.CreateSinger(model));

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
