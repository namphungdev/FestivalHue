using AutoMapper;
using FestivalHue.Dto;
using FestivalHue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteServicesController : ControllerBase
    {
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public FavouriteServicesController(FestivalHueContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/FavouriteServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavouriteServiceDto>>> GetFavouriteServices()
        {
            if (_context.FavouriteServices == null)
            {
                return NotFound();
            }
            var FavouriteService = await _context.FavouriteServices.Select(x => _mapper.Map<FavouriteServiceDto>(x)).ToListAsync();
            var favouriteServiceDto = FavouriteService.GroupBy(x => x.UserId).Select(g => new FavouriteServiceDto
            {
                UserId = g.Key,

            });
            if (FavouriteService.Count == 0)
            {
                return NotFound("Không có chương trình yêu thích");
            }
            var response = favouriteServiceDto.Select(x => new
            {
                UserId = x.UserId,
                FavouriteService = FavouriteService.Where(y => y.UserId == x.UserId).Select(y => new
                {
                    ServiceId = y.ServiceId,
                    ServiceName = _context.Services.Find(y.ServiceId).Title
                })

            });
            return Ok(response);
        }

        // GET: api/FavouriteServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavouriteService>> GetFavouriteService(int id)
        {
            if (_context.FavouriteServices == null)
            {
                return NotFound();
            }
            var FavouriteServices = await _context.FavouriteServices.Select(x => _mapper.Map<FavouriteServiceDto>(x)).ToListAsync();
            var check = FavouriteServices.Find(x => x.UserId == id);
            if (check == null)
            {
                return NotFound("Chưa yêu thích địa điểm nào");
            }
            var response = new
            {
                UserId = id,
                FavouriteServices = FavouriteServices.Where(y => y.UserId == id).Select(y => new
                {
                    ServiceId = y.ServiceId,
                    ServiceName = _context.Services.Find(y.ServiceId).Title
                })

            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<FavouriteService>> PostFavouriteService(FavouriteServiceDto favouriteService)
        {
            if (_context.FavouriteServices == null)
            {
                return Problem("Entity set 'FestivalHueContext.FavouriteService'  is null.");
            }
            var favouriteServiceEntity = _mapper.Map<FavouriteService>(favouriteService);
            _context.FavouriteServices.Add(favouriteServiceEntity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (favouriteServiceExists(favouriteService.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFavouriteService", new { id = favouriteService.UserId }, favouriteService);
        }

        // DELETE: api/FavouritePrograms/5
        [HttpDelete]
        public async Task<IActionResult> DeleteFavouriteService(int UserId, int ServiceId)
        {
            if (_context.FavouriteServices == null)
            {
                return NotFound();
            }
            var favouriteService = await _context.FavouriteServices.Where(a => a.UserId == UserId).ToListAsync();
            if (favouriteService == null)
            {
                return NotFound("Id người dùng không tồn tại");
            }
            var checkfavouriteService = favouriteService.Find(a => a.ServiceId == ServiceId);
            if (checkfavouriteService == null)
            {
                return NotFound("Id địa điểm người dùng yêu thích không tồn tại");
            }

            _context.FavouriteServices.Remove(checkfavouriteService);
            await _context.SaveChangesAsync();

            return Ok("Xóa địa điểm yêu thích thành công");
        }
        private bool favouriteServiceExists(int id)
        {
            return (_context.FavouriteServices?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
