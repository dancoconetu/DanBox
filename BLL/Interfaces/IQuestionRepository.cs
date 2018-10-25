using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();
        Question GetQuestion(Guid id);
        Guid CreateQuestion(Question question);
        bool DeleteQuestion(Guid id);
        bool UpdateQuestion(Guid id, Question question);


    }
}
