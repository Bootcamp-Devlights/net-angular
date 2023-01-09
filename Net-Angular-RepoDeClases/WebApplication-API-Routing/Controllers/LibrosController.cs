using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_API_Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        // GET: api/<LibrosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("autor/{nombre}")]
        public void GetLibroByAutor(string nombre)
        {

        }

        // GET api/<LibrosController>/5
        [HttpGet("{id}")]
        public string GetByIdOriginal(int id)
        {
            return "Devuelve un libro dado el id";
        }

        // GET api/<LibrosController>/5
        [HttpGet("search/id/{id}")]
        public string GetByIdCustom(int id)
        {
            return "Devuelve un libro dado el id";
        }

        //[HttpGet("/search/titulo/{titulo}")]
        //public string GetById2(string titulo)
        //{
        //    return "Devuelve un libro dado el id";
        //}

        // GET api/<LibrosController>/5
        [HttpGet("search/titulo/{titulo}")]
        public string GetByTitulo(string titulo)
        {
            return "Devuelve un libro dado el titulo";
        }

        // GET api/<LibrosController>/5
        [HttpGet("{id}/pagina/{numero}")]
        public string Get(int id, int numero)
        {
            return "value";
        }

        // /api/libros?libroId=1&libroTitulo=untitulo
        [HttpGet("search")]
        public string GetById2([FromQuery] int libroId, string libroTitulo)
        {
            return "value";
        }

        // GET api/<LibrosController>/5
        [HttpGet("{year}/{month}/{day}")]
        public string GetByDate(int year, int month, int day)
        {
            return "value " + year;
        }

        // POST api/<LibrosController> /libros?id=1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LibrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
