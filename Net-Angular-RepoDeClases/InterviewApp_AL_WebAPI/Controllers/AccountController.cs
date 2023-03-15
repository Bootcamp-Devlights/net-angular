using InterviewApp_BL.Dtos;
using InterviewApp_BL.Services;
using InterviewApp_DAL;
using InterviewApp_DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace InterviewApp_AL_WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly InterviewAppDbContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(InterviewAppDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        //Login
        [HttpPost("Login")]
        public ActionResult<UserResponseDto> Login(LoginDto loginDto)
        {
            
            try
            {
                //Corroborar el username este en la base de datos
                var user = _context.Users.FirstOrDefault(u => u.Username.ToUpper() == loginDto.Username.ToUpper());

                //Si no existe, lanzar un mensaje de credenciales invalidas
                if (user == null)
                    return BadRequest("Error: Credenciales invalidas");

                //Si existe, traer el usuario
                //Comparar las contraseñas (tienen que coincidir)
                //Si no, lanzar un mensaje de credenciales invalidas

                var hmac = new HMACSHA512(user.PasswordSalt);

                var computedPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

                for (int i = 0; i < computedPass.Length; i++)
                {
                    if (computedPass[i] != user.PasswordHash[i]) return Unauthorized("Error: Credenciales invalidas");
                }
                //Si son iguales, devuelvo un mensaje diciendo que esta logueado
                var token = _tokenService.CreateToken(user);

                return Ok(new UserResponseDto() { Token = token, Username = user.Username });
                //El error siempre debe ser en general: usuario o contraseña invalidos
            }
            catch (ArgumentNullException anex)
            {
                throw anex;
            }
            catch (ObjectDisposedException odex) 
            {
                throw odex;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                throw ex;
            }
            finally
            {

            }
        }

        //Register
        [HttpPost("Register")]
        public ActionResult<UserResponseDto> Register(RegisterDto registerDto)
        {
            //Corroborar el email NO este en la base de datos (email as username)
            var user = _context.Users.FirstOrDefault(u => u.Username == registerDto.Email);

            if (user != null)
                return BadRequest("Error: Username ya existente");

            //si no existe, intentamos registrar

            ///Validar campos
            //Comparar las contraseñas (Password y RepeatedPassword) (tienen que coincidir)
            if (registerDto.Password != registerDto.RepeatedPassword)
                return BadRequest("Error: password y repeat password deben ser iguales");

            Usuario newUser;
            //Si son iguales, registro

            var hmac = new HMACSHA512();

            if (registerDto.Entrevistado)
            {
                newUser = new Entrevistado()
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    City = registerDto.City,
                    DateOfBirth = registerDto.DateOfBirth,
                    Phone = registerDto.Phone,

                    CreationDate = DateTime.Now,

                    Email = registerDto.Email,
                    Username = registerDto.Email,

                    //Password = registerDto.Password,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key
                };
            }
            else
            {
                newUser = new Entrevistador()
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    City = registerDto.City,
                    DateOfBirth = registerDto.DateOfBirth,
                    Phone = registerDto.Phone,

                    Email = registerDto.Email,
                    Username = registerDto.Email,

                    //Password = registerDto.Password,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key
                };
            }

            _context.Users.Add(newUser);
            _context.SaveChanges();

            var token = _tokenService.CreateToken(newUser);

            return Ok(new UserResponseDto() { Token = token, Username = user.Username });
        }
    }
}
