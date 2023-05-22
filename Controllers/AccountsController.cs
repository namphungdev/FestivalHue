using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FestivalHue.Models;
using FestivalHue.Dto;
using System.Data;
using AutoMapper;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace FestivalHue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly FestivalHueContext _context;
        private readonly IMapper _mapper;

        public AccountsController(FestivalHueContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> Register(UserDto user)
        {
            try
            {
                //code to create user and hash password with bcrypt
                var check = _context.Users.Where(x => x.Email == user.Email).FirstOrDefault();
                if (check != null)
                {
                    return BadRequest("Email đã tồn tại.");
                }
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                user.RoleId = 2;
                var newUser = _mapper.Map<User>(user);
                // hash password with bcrypt
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();
                return Ok("Đăng ký thành công");
            }
            catch (Exception ex)
            {
                return BadRequest("Đăng ký không thành công, đã xảy ra lỗi trong quá trình đăng ký");
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(string email, string password)
        {
            try
            {
                var checkemail = _context.Users.Where(x => x.Email == email).FirstOrDefault();
                if (checkemail == null)
                {
                    return BadRequest("Email không chính xác.");
                }
                var checkpassword = BCrypt.Net.BCrypt.Verify(password, checkemail.Password);
                if (checkpassword == false)
                {
                    return BadRequest("Mật khẩu không chính xác.");
                }
                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                var claims = new[]
                {                 
                    new Claim(ClaimTypes.NameIdentifier, checkemail.UserId.ToString()),
                    new Claim(ClaimTypes.GivenName, checkemail.UserName.ToString()),
                    new Claim(ClaimTypes.Email, checkemail.Email.ToString()),
                    new Claim(ClaimTypes.Role, checkemail.RoleId.ToString())

                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwt.Key));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                                issuer:  jwt.Issuer,
                                audience: jwt.Audience,
                                claims:  claims,
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

        // PUT: api/Accounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{email}")]
        public async Task<IActionResult> PutUser(string email, string password, string newpassword)
        {
            try
            {
                var checkemail = _context.Users.Where(x => x.Email == email).FirstOrDefault();
                if (checkemail == null)
                {
                    return BadRequest("Email không chính xác.");
                }
                var checkpassword = BCrypt.Net.BCrypt.Verify(password, checkemail.Password);
                if (checkpassword == false)
                {
                    return BadRequest("Mật khẩu không chính xác.");
                }
                if (newpassword == password)
                {
                    return BadRequest("Mật khẩu mới không được trùng mật khẩu cũ.");
                }
                checkemail.Password = BCrypt.Net.BCrypt.HashPassword(newpassword);
                _context.Entry(checkemail).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok("Đổi mật khẩu thành công");

            }
            catch (Exception ex)
            {
                return BadRequest("Đổi mật khẩu không thành công, đã xảy ra lỗi trong quá trình đổi mật khẩu");
            }
        }


        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
