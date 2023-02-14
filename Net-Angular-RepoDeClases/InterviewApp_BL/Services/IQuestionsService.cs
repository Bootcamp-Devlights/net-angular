using InterviewApp_BL.Dtos;
using InterviewApp_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp_BL.Services
{
    public interface IQuestionsService
    {
        public IEnumerable<Pregunta> GetQuestions();
        public IEnumerable<Pregunta> SearchQuestions(string text);
        public Pregunta GetQuestion(int id);
        public void SaveQuestion(PreguntaDto preguntaDto);
        public void UpdateQuestion(PreguntaDto preguntaDto, int id);
        public void DeleteQuestion(int id);
    }
}
