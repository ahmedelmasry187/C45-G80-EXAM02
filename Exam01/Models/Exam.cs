using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public List<int> StudentAnswers { get; set; }

        protected Exam(int timeOfExam,int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions= new List<Question>();
            StudentAnswers= new List<int>();
            
        }

        public void StartExam()
        {
            Console.WriteLine("start the exam");

            foreach(Question q in Questions)
            {
                q.DisplayQuestion();
                int chosen = ReadValidInt("enter your answer id");
                StudentAnswers.Add(chosen);

            }
            Console.WriteLine("the exam is done");
        }

        public static int ReadValidInt(string prompt)
        {
            int value;
            Console.WriteLine(prompt);
            while(!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("please enter correct number");
            }
            return value;

        }

        public override string ToString()
        {
            return $"exam time {TimeOfExam}m , questions:{NumberOfQuestions} ";
        }
        
        public abstract void ShowExam();
    }
}
