using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public class PracticalExam:Exam
    {
        public PracticalExam(int TimeOfExam , int NumberOfQuestions):base (TimeOfExam , NumberOfQuestions)
        {
            
        }
         
        //shows only the right answer
        public override void ShowExam()
        {
            Console.WriteLine(" the right answers : ");
            for (int i = 0; i < Questions.Count; i++)
            {
                var q = Questions[i];
                var correctAnswer = q.AnswerList.Find(a => a.AnswerID == q.CorrectAnswerId);
                Console.WriteLine($"{i+1}:{q.Header} => right naswer is {correctAnswer}");
            }
        }
    }
}
