using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        // GET: api/libros
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/libros/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/libros //Datos no vienen en la url
        // Header
        // Body
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //Creando un libro nuevo
        }

        // PUT api/libros/5
        // Header
        // Body
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //Actualizar un libro ya existente, representado por el id
        }

        // DELETE api/<LibrosController>/5
        [HttpDelete("{id}")]
        // Header
        public void Delete(int id)
        {
            //Borra un libro ya existente, representado por el id
        }
    }
}
