using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Models
{
    public class User
    {   
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int FirstPlace { get; set; }
        public int SecondPlace { get; set; }
        public int ThirdPlace { get; set; }
        public int OtherPlaces { get; set; }

        public ICollection<QuestionsAccuracy> QuestionsAccuracies { get; set; }
    }
}
