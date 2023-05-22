using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FestivalHue.Models;
using AutoMapper;
using FestivalHue.Dto;
using System.Runtime.CompilerServices;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteProgramsController : ControllerBase
    {
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public FavouriteProgramsController(FestivalHueContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/FavouritePrograms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavouriteProgramDto>>> GetFavouritePrograms()
        {
          if (_context.FavouritePrograms == null)
          {
              return NotFound();
          }
          var favouritePrograms =  _context.FavouritePrograms.Select(x => _mapper.Map<FavouriteProgramDto>(x)).ToList();
            /*var groupby = favouritePrograms.GroupBy(x => x.UserId).Select(g => new FavouriteProgram { 
                UserId = g.Key,
                
            });*/
            
            var respone = favouritePrograms.Select(x => new
            {
                UserId = x.UserId,
                listFavorite = favouritePrograms.Select(y => new
                {
                     ProgramId = y.ProgramId,
                     ProgramName = _context.Programms.Find(y.ProgramId).ProgramName            
                })
            });
            return Ok(respone);
        }

        // GET: api/FavouritePrograms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavouriteProgram>> GetFavouriteProgram(int id)
        {
          if (_context.FavouritePrograms == null)
          {
              return NotFound();
          }
            var favouriteProgram = await _context.FavouritePrograms.FindAsync(id);

            if (favouriteProgram == null)
            {
                return NotFound();
            }

            return favouriteProgram;
        }

        // PUT: api/FavouritePrograms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavouriteProgram(int id, FavouriteProgram favouriteProgram)
        {
            if (id != favouriteProgram.UserId)
            {
                return BadRequest();
            }

            _context.Entry(favouriteProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavouriteProgramExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FavouritePrograms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FavouriteProgram>> PostFavouriteProgram(FavouriteProgramDto favouriteProgram)
        {
          if (_context.FavouritePrograms == null)
          {
              return Problem("Entity set 'FestivalHueContext.FavouritePrograms'  is null.");
          }
            var favouriteProgramEntity = _mapper.Map<FavouriteProgram>(favouriteProgram);
            _context.FavouritePrograms.Add(favouriteProgramEntity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FavouriteProgramExists(favouriteProgram.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFavouriteProgram", new { id = favouriteProgram.UserId }, favouriteProgram);
        }

        // DELETE: api/FavouritePrograms/5
        [HttpDelete]
        public async Task<IActionResult> DeleteFavouriteProgram(int UserId, int ProgramId)
        {
            if (_context.FavouritePrograms == null)
            {
                return NotFound();
            }
            var favouriteProgram = await _context.FavouritePrograms.Where(a => a.UserId == UserId).ToListAsync();
            if (favouriteProgram == null)
            {
                return NotFound("Id người dùng không tồn tại");
            }
            var checkfavouriteProgram = favouriteProgram.Find(a => a.ProgramId == ProgramId);
            if (checkfavouriteProgram == null)
            {
                return NotFound("Id chương trình người dùng yêu thích không tồn tại");
            }

            _context.FavouritePrograms.Remove(checkfavouriteProgram);
            await _context.SaveChangesAsync();

            return Ok("Xóa chương trình yêu thích thành công");
        }

        private bool FavouriteProgramExists(int id)
        {
            return (_context.FavouritePrograms?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
