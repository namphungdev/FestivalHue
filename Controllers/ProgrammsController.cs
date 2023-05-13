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
using System.Data;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammsController : ControllerBase
    {
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public ProgrammsController(FestivalHueContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Programms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgrammDto>>> GetProgramms()
        {
          if (_context.Programms == null)
          {
              return NotFound();
          }
            return await _context.Programms.Select(x => _mapper.Map<ProgrammDto>(x)).ToListAsync();
        }

        // GET: api/Programms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProgrammDto>> GetProgramm(int id)
        {
          if (_context.Programms == null)
          {
              return NotFound();
          }
            var programm = await _context.Programms.FindAsync(id);
            var programmDto = _mapper.Map<ProgrammDto>(programm);
            if (programm == null)
            {
                return NotFound();
            }
            var response = new
            {
                programmId = programmDto.ProgramId,
                programmName = programmDto.ProgramName,
                programmContent = programmDto.ProgramContent,
                type_inoff = programmDto.Type_inoff,
                price = programmDto.Price,
                type_program = programmDto.Type_program,
                arrange = programmDto.arrange,
                detail_list = new {
                    fdate = programmDto.Fdate,
                    tdate = programmDto.Tdate,
                    locationId = programmDto.LocationId,
                    locationName = _context.Locations.Find(programmDto.LocationId).LocationName,
                    groupId = programmDto.GroupId,
                    groupName = _context.Groups.Find(programmDto.GroupId).GroupName,
                },
                md5 = programmDto.Md5,
                pathImage_list = new {
                    programmDto.PathImage,
                }

            };

            return Ok(response);
        }

        // PUT: api/Programms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgramm(int id, ProgrammDto programm)
        {
            var programmEntity = _mapper.Map<Programm>(programm);
            if (id != programmEntity.ProgramId)
            {
                return BadRequest();
            }
          
            try
            {
                _context.Entry(programmEntity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgrammExists(id))
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

        // POST: api/Programms
        [HttpPost]
        public async Task<ActionResult<Programm>> PostProgramm(ProgrammDto programm)
        {
          if (_context.Programms == null)
          {
              return Problem("Entity set 'FestivalHueContext.Programms'  is null.");
          }
            var programmEntity = _mapper.Map<Programm>(programm);
            _context.Programms.Add(programmEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgramm", new { id = programm.ProgramId }, programm);
        }

        // DELETE: api/Programms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgramm(int id)
        {
            if (_context.Programms == null)
            {
                return NotFound();
            }
            var programm = await _context.Programms.FindAsync(id);
            if (programm == null)
            {
                return NotFound();
            }

            _context.Programms.Remove(programm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgrammExists(int id)
        {
            return (_context.Programms?.Any(e => e.ProgramId == id)).GetValueOrDefault();
        }
    }
}
