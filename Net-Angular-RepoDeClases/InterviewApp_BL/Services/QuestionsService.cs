using InterviewApp_BL.Dtos;
using InterviewApp_DAL;
using InterviewApp_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp_BL.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly InterviewAppDbContext _context;
        
        public QuestionsService(InterviewAppDbContext interviewAppDbContext)
        {
            _context = interviewAppDbContext;
        }

        public IEnumerable<Pregunta> GetQuestions()
        {
            return _context.Questions;
        }

        public IEnumerable<Pregunta> SearchQuestions(string text)
        {
            return _context.Questions.Where(q => q.Description.Contains(text));
        }

        public Pregunta GetQuestion(int id)
        {
            return _context.Questions.Find(id);
        }

        public void SaveQuestion(PreguntaDto preguntaDto)
        {
            Pregunta question = new Pregunta()
            {
                Description = preguntaDto.Descripcion
            };

            _context.Questions.Add(question);

            _context.SaveChanges();
        }

        public void UpdateQuestion(PreguntaDto preguntaDto, int id)
        {
            var question = _context.Questions.Find(id);

            if (question != null)
            {
                question.Description = preguntaDto.Descripcion;

                _context.Questions.Update(question);
                _context.SaveChanges();
            }
        }

        public void DeleteQuestion(int id)
        {
            var question = _context.Questions.Find(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}
