using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FestivalHue.Models;
using System.Drawing.Imaging;
using System.Drawing;
using ZXing;
using ZXing.Windows.Compatibility;
using FestivalHue.Dto;
using AutoMapper;
using ZXing.QrCode;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly FestivalHueContext _context;

        public TicketsController(FestivalHueContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("createqrcode")]
        public async Task<ActionResult<Ticket>> GenerateQRCode(TicketDto ticket)
        {
            BarcodeWriter writer = new BarcodeWriter();
            QrCodeEncodingOptions options = new QrCodeEncodingOptions
            {
                Width = 300,
                Height = 300,
                DisableECI = true,
                CharacterSet = "UTF-8"
            };
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var data = new {
                TicketName = ticket.Name,
                TicketTypeName = _context.TicketTypes.Where(x => x.TicketTypeId == ticket.TicketTypeId).Select(x => x.TicketName).FirstOrDefault(),
                ProgramName = _context.Programms.Where(x => x.ProgramId == ticket.ProgramId).Select(x => x.ProgramName).FirstOrDefault(),
                UserName = _context.Users.Where(x => x.UserId == ticket.UserId).Select(x => x.UserName).FirstOrDefault(),
                Fdate = ticket.Fdate
            }.ToString();

            Console.WriteLine(data);
            Bitmap qrCodeBitmap = writer.Write(data);

            MemoryStream ms = new MemoryStream();
            qrCodeBitmap.Save(ms, ImageFormat.Png);
            byte[] qrCodeBytes = ms.ToArray();

            string imagePath = "Img/QRTicket/qrticket" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".png" ;
            qrCodeBitmap.Save(imagePath, ImageFormat.Png);

            var ticketEntity = _mapper.Map<Ticket>(ticket);
            _context.Tickets.Add(ticketEntity);
            await _context.SaveChangesAsync();

            return File(qrCodeBytes, "image/png");
        }

        [HttpPost("qrcode")]
        public IActionResult DecodeQRCode(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            using (var stream = file.OpenReadStream())
            {
                var reader = new BarcodeReader();
                var result = reader.Decode(new BitmapLuminanceSource(new Bitmap(stream)));

                if (result != null)
                {
                    string decodedData = result.Text;
                    return Ok(decodedData);
                }
                else
                {
                    return BadRequest("Unable to decode QR code.");
                }
            }
        }
        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
        {
          if (_context.Tickets == null)
          {
              return NotFound();
          }
            return await _context.Tickets.Select(x => _mapper.Map<TicketDto>(x)).ToListAsync();
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
          if (_context.Tickets == null)
          {
              return NotFound();
          }
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // PUT: api/Tickets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return BadRequest();
            }

            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(id))
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

        // POST: api/Tickets
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTicket(TicketDto ticket)
        {
          if (_context.Tickets == null)
          {
              return Problem("Entity set 'FestivalHueContext.Tickets'  is null.");
          }
            var ticketEntity = _mapper.Map<Ticket>(ticket);
            _context.Tickets.Add(ticketEntity);
            /* await _context.SaveChangesAsync();*/
            Console.WriteLine(ticketEntity);

            return CreatedAtAction("GetTicket", new { id = ticket.TicketId }, ticket);
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            if (_context.Tickets == null)
            {
                return NotFound();
            }
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketExists(int id)
        {
            return (_context.Tickets?.Any(e => e.TicketId == id)).GetValueOrDefault();
        }
    }
}
