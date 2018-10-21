using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class QuestionTag
    {
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
