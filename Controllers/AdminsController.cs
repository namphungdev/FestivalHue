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
using NuGet.Protocol;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "1")]
    public class AdminsController : ControllerBase
    {
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public AdminsController(FestivalHueContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Admins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminDto>>> GetAdmins()
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }   
            var admin = await _context.Admins.ToListAsync();
            var response = new
            {              
                admin = admin.Select(x => new { 
                    AdminId = x.AdminId,
                    AdminName = x.AdminName,
                    Email = x.Email,
                    Password = x.Password, 
                    Phone = x.Phone,
                    Address = x.Address,
                    Avatar = x.Avatar,
                    RoleId = x.RoleId,
                    RoleName = _context.Roles.Find(x.RoleId).RoleName,
                    Created_at = x.Created_at,
                    Updated_at = x.Updated_at,
                }).ToList()
            };



            return  Ok(response);
        }

        // GET: api/Admins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminDto>> GetAdmin(int id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }
            var admin = await _context.Admins.FindAsync(id);

            if (admin == null)
            {
                return NotFound();
            }

            return _mapper.Map<AdminDto>(admin);
        }

        // PUT: api/Admins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, AdminDto admin)
        {
            var adminUpdate = _mapper.Map<Admin>(admin);
            if (id != adminUpdate.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(adminUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
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

        // POST: api/Admins
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(AdminDto admin)
        {
            if (admin == null)
            {
                return Problem("Entity set 'FestivalHueContext.Admins'  is null.");
            }
            _context.Admins.Add(_mapper.Map<Admin>(admin));

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmin", new { id = admin.AdminId }, admin);
        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }
            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(int id)
        {
            return (_context.Admins?.Any(e => e.AdminId == id)).GetValueOrDefault();
        }
    }
}
