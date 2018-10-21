using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<QuestionTag> QuestionTags { get; set; }
        public ICollection<QuestionsAccuracy> QuestionsAccuracy { get; set; }
    }
}
