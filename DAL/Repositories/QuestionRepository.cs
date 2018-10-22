using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using BLL.Models;

namespace DataAccessLayer.Repositories
{
     public class QuestionRepository : IQuestionRepository
    {
        public Guid CreateQuestion(string text, string answer1, string answer2, string answer3, string answer4, string correctAnswer, ICollection<QuestionTag> questionTags)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuestion(Guid id)
        {
            throw new NotImplementedException();
        }

        public Question GetQuestion(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetQuestions()
        {
            throw new NotImplementedException();
        }

        public bool UpdateQuestion(Guid id, string text, string answer1, string answer2, string answer3, string answer4, string correctAnswer, ICollection<QuestionTag> questionTags)
        {
            throw new NotImplementedException();
        }
    }
}
