using InterviewApp_BL.Dtos;
using InterviewApp_BL.Services;
using InterviewApp_DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp_AL_WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        //field privado de solo lectura
        private readonly IQuestionsService _questionsService;

        //Inyección de dependencia
        //Dependency injection
        public QuestionsController(IQuestionsService questionsService) 
        {
            _questionsService = questionsService;
        }

        //Traer todo
        [HttpGet]
        public List<Pregunta> GetQuestions()
        {
            return _questionsService.GetQuestions().ToList();
        }

        //Traer 1
        [HttpGet("{id}")]
        public Pregunta GetQuestion(int id)
        {
            return _questionsService.GetQuestion(id);
        }

        //Buscar preguntas por texto
        [HttpGet("search/{text}")]
        public List<Pregunta> SearchQuestion(string text)
        {
            return _questionsService.SearchQuestions(text).ToList();
        }

        //Crear
        [HttpPost]
        public void PostQuestion(PreguntaDto preguntaDto)
        {
            _questionsService.SaveQuestion(preguntaDto);
        }

        //Actualizar 1
        [HttpPut("{id}")]
        public void PutQuestion(int id, PreguntaDto preguntaDto)
        {
            _questionsService.UpdateQuestion(preguntaDto, id);
        }

        //Borrar 1
        [HttpDelete("{id}")]
        public void DeleteQuestion(int id)
        {
            _questionsService.DeleteQuestion(id);
        }
    }
}
