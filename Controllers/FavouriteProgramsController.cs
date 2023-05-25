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
            var favouriteProgramm = await _context.FavouritePrograms.Select(x => _mapper.Map<FavouriteProgramDto>(x)).ToListAsync();
            var favouriteProgrammDto = favouriteProgramm.GroupBy(x => x.UserId).Select(g => new FavouriteProgramDto
            {
                UserId = g.Key,

            });
            if (favouriteProgramm.Count == 0)
            {
                return NotFound("Không có chương trình yêu thích");
            }
            var response = favouriteProgrammDto.Select(x => new
            {
                UserId = x.UserId,
                FavouriteProgramm = favouriteProgramm.Where(y => y.UserId == x.UserId).Select(y => new
                {
                    ProgramId = y.ProgramId,
                    ProgramName = _context.Programms.Find(y.ProgramId).ProgramName
                })

            });
            return Ok(response);
        }

        // GET: api/FavouritePrograms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavouriteProgram>> GetFavouriteProgram(int id)
        {
            if (_context.FavouritePrograms == null)
            {
                return NotFound();
            }
            var favouriteProgramm = await _context.FavouritePrograms.Select(x => _mapper.Map<FavouriteProgramDto>(x)).ToListAsync();
            var check = favouriteProgramm.Find(x => x.UserId == id);
            if (check == null)
            {
                return NotFound("Chưa yêu thích chương trình nào");
            }
            var response = new
            {
                UserId = id,
                FavouriteProgramm = favouriteProgramm.Where(y => y.UserId == id).Select(y => new
                {
                    ProgramId = y.ProgramId,
                    ProgramName = _context.Programms.Find(y.ProgramId).ProgramName
                })

            };

            return Ok(response);
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
