using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using BLL.Models;

namespace DataAccessLayer.Repositories
{
     public class QuestionRepository : IQuestionRepository
    {
        public IEnumerable<Question> GetQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
