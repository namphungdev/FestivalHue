using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FestivalHue.Models;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubMenusController : ControllerBase
    {
        private readonly FestivalHueContext _context;

        public SubMenusController(FestivalHueContext context)
        {
            _context = context;
        }

        // GET: api/SubMenus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubMenu>>> GetSubMenus()
        {
          if (_context.SubMenus == null)
          {
              return NotFound();
          }
            return await _context.SubMenus.ToListAsync();
        }

        // GET: api/SubMenus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubMenu>> GetSubMenu(int id)
        {
          if (_context.SubMenus == null)
          {
              return NotFound();
          }
            var subMenu = await _context.SubMenus.FindAsync(id);

            if (subMenu == null)
            {
                return NotFound();
            }

            return subMenu;
        }

        // PUT: api/SubMenus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubMenu(int id, SubMenu subMenu)
        {
            if (id != subMenu.SubMenuId)
            {
                return BadRequest();
            }

            _context.Entry(subMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubMenuExists(id))
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

        // POST: api/SubMenus
        [HttpPost]
        public async Task<ActionResult<SubMenu>> PostSubMenu(SubMenu subMenu)
        {
          if (_context.SubMenus == null)
          {
              return Problem("Entity set 'FestivalHueContext.SubMenus'  is null.");
          }
            _context.SubMenus.Add(subMenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubMenu", new { id = subMenu.SubMenuId }, subMenu);
        }

        // DELETE: api/SubMenus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubMenu(int id)
        {
            if (_context.SubMenus == null)
            {
                return NotFound();
            }
            var subMenu = await _context.SubMenus.FindAsync(id);
            if (subMenu == null)
            {
                return NotFound();
            }

            _context.SubMenus.Remove(subMenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubMenuExists(int id)
        {
            return (_context.SubMenus?.Any(e => e.SubMenuId == id)).GetValueOrDefault();
        }
    }
}
