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
        Guid CreateQuestion(string text, string answer1, string answer2, string answer3, string answer4, string correctAnswer, ICollection<QuestionTag> questionTags);
        bool DeleteQuestion(Guid id);
        bool UpdateQuestion(Guid id, string text, string answer1, string answer2, string answer3, string answer4, string correctAnswer, ICollection<QuestionTag> questionTags);
    }
}
