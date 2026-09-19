using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public class MCQQuestion :Question
    {
        public MCQQuestion(string header , string body , int mark):base (header , body , mark)
        {

            
        }

        public override QuestionType Type => QuestionType.MCQ;
    }
}
