using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public class Answer
    {
        public Answer(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }

        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        public override string ToString()
        {
            return $"{AnswerID} {AnswerText}";
        }
    }
}
