using InterviewApp_BL.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp_AL_WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //ViewUsers
        //api/users
        [HttpGet]
        public List<UsuarioDto> GetUsers()
        {
            return new List<UsuarioDto>();
        }

        //ViewUser
        //api/users/5
        [HttpGet("/{id}")]
        public UsuarioDto GetUserById(int id) 
        { 
            return new UsuarioDto { Id = id };
        }

    }
}
