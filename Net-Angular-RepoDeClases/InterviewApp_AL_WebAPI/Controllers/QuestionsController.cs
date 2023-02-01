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

        [HttpGet]
        public List<Pregunta> GetQuestions()
        {
            return _context.Questions.ToList();
        }
    }
}
