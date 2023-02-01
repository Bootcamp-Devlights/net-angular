using InterviewApp_BL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp_AL_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //Login
        [HttpPost("Login")]
        public string Login(LoginDto loginDto)
        {
            //Corroborar el username este en la base de datos
            //Si existe, traer el usuario
            //Si no existe, lanzar un mensaje de credenciales invalidas
            //Comparar las contraseñas (tienen que coincidir)
            //Si son iguales, devuelvo un mensaje diciendo que esta logueado
            //Si no, lanzar un mensaje de credenciales invalidas

            //El error siempre debe ser en general: usuario o contraseña invalidos
            return "";
        }

        //Register
        [HttpPost("Register")]
        public string Register(RegisterDto registerDto)
        {
            //Corroborar el email NO este en la base de datos (email as username)
            //si existe, lanzar un mensaje: datos ya existen la base de datos
            //si no existe, intentamos registrar
            ///Validar campos
            //Comparar las contraseñas (Password y RepeatedPassword) (tienen que coincidir)
            //Si son iguales, registro
            //Si no, lanzo un mensaje de error
            return "";
        }
    }
}
