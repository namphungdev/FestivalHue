using AutoMapper;
using FestivalHue.Dto;
using FestivalHue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountAdminController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public AccountAdminController(FestivalHueContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

       
        [HttpPost("Login")]
        public async Task<ActionResult<Admin>> Login(string email, string password)
        {
            try
            {
                var checkemail = _context.Admins.Where(x => x.Email == email).FirstOrDefault();
                if (checkemail == null)
                {
                    return BadRequest("Email không chính xác.");
                }
                var checkpassword = checkemail.Password == password;
                if (checkpassword == false)
                {
                    return BadRequest("Mật khẩu không chính xác.");
                }
                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, checkemail.AdminId.ToString()),
                    new Claim(ClaimTypes.GivenName, checkemail.AdminName.ToString()),
                    new Claim(ClaimTypes.Email, checkemail.Email.ToString()),
                    new Claim(ClaimTypes.Role, checkemail.RoleId.ToString())

                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwt.Key));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                                issuer: jwt.Issuer,
                                audience: jwt.Audience,
                                claims: claims,
                                  expires: DateTime.Now.AddDays(20),
                                  signingCredentials: signIn
                                );

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception ex)
            {
                return BadRequest("Đăng nhập không thành công, đã xảy ra lỗi trong quá trình đăng nhập");
            }
        }
    }
}
