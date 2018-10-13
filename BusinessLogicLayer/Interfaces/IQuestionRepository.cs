using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Interfaces
{
    public interface IQuestionRepository
    {
       IEnumerable<Question> getQuestions();
    }
}
