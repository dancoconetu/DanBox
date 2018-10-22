using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public DateTime Created { get; set; }

        public ICollection<QuestionTag> QuestionTags { get; set; }
    }
}
