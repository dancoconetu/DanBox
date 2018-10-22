﻿using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IQuestionRepository
    {
       IEnumerable<Question> GetQuestions();
    }
}
