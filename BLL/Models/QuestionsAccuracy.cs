using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Models
{
    public class QuestionsAccuracy
    {
        public int CorrectAnswers { get; set; }
        public int TotalAnswers { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }


    }
}
