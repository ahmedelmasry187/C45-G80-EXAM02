using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public class FinalExam:Exam
    {

        public FinalExam(int timeOfExam , int NumberOfQuestions ):base (timeOfExam , NumberOfQuestions)
        {
            
        }

        public override void ShowExam()
        {
            int grade = 0;
            Console.WriteLine("final exam");
            for (int i = 0; i < Questions.Count; i++)
            {
                var q = Questions[i];
                int choosen = StudentAnswers[i];
                bool correct = q.CheckAnswer(choosen);
                Console.WriteLine($"{i+1}:{q.Header}");
                foreach(var a in q.AnswerList)
                {
                    string mark = a.AnswerID == q.CorrectAnswerId ? " right answer" :"";
                    Console.WriteLine($"{a}{mark}");
                }
                Console.WriteLine(correct?"your answer is right":"your answer is wrong");

                if (correct) grade += q.Mark;
                Console.WriteLine($"final mark {grade}");
            }
        }
    }
}
