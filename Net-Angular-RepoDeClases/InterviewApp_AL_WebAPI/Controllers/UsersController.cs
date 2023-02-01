using InterviewApp_BL.Dtos;
using InterviewApp_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp_AL_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //ViewUsers
        //api/users
        [HttpGet]
        public List<UsuarioDto> GetUsers()
        {

        }

        //ViewUser
        //api/users/5
        [HttpGet("/{id}")]
        public UsuarioDto GetUserById(int id) 
        { 

        }

    }
}
