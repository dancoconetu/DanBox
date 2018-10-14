using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;

namespace DataAccessLayer.Repositories
{
    class QuestionRepository : IQuestionRepository
    {
        public IEnumerable<Question> getQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
