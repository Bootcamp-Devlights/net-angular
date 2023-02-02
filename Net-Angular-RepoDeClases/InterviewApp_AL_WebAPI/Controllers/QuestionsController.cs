using InterviewApp_AL_WebAPI.Dtos;
using InterviewApp_DAL;
using InterviewApp_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp_AL_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly InterviewAppDbContext _context;

        public QuestionsController(InterviewAppDbContext interviewAppDbContext) 
        { 
            _context = interviewAppDbContext;
        }

        //Traer todo
        [HttpGet]
        public List<Pregunta> GetQuestions()
        {
            return _context.Questions.ToList();
        }

        //Traer 1
        [HttpGet("{id}")]
        public Pregunta GetQuestion(int id)
        {
            return _context.Questions.Find(id);
        }

        //Buscar preguntas por texto
        [HttpGet("search/{text}")]
        public List<Pregunta> SearchQuestion(string text)
        {
            return _context.Questions.Where(q => q.Description.Contains(text)).ToList();
        }

        //Crear
        [HttpPost]
        public void PostQuestion(PreguntaDto preguntaDto)
        {
            //Usar Dto: Data Transfer Object
            Pregunta question = new Pregunta()
            {
                Description = preguntaDto.Descripcion
            };

            _context.Questions.Add(question);

            _context.SaveChanges();
        }

        //Actualizar 1
        [HttpPut("{id}")]
        public void PutQuestion(int id, PreguntaDto preguntaDto)
        {
            var question = _context.Questions.Find(id);

            if(question != null)
            {
                question.Description = preguntaDto.Descripcion;
                
                _context.Questions.Update(question);
                _context.SaveChanges();
            }
        }

        //Borrar 1
        [HttpDelete("{id}")]
        public void DeleteQuestion(int id)
        {
            var question = _context.Questions.Find(id);
            if(question != null )
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}
