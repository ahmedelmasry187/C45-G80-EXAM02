using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exam01.Models
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(string header , string body , int mark):base(header , body , mark)
        {
            AnswerList.Add(new Answer(1, "true"));
            AnswerList.Add(new Answer(2, "flase"));

            
            
        }

        public override QuestionType Type => QuestionType.TrueOrFalse;
    }
}
