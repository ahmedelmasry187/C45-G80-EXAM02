using Exam01.Models;
using System.Runtime.CompilerServices;

namespace Exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the subject name");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(1,subjectName);
            Console.WriteLine("choose exam type :");
            Console.WriteLine("1)final");
            Console.WriteLine("2)practical");

            int examTypeChoice = Exam.ReadValidInt("your choice : ");
            string examType = examTypeChoice == 1 ? "final" : "practical";

            int time;

            do
            {
                time = Exam.ReadValidInt("enter the time of the exam (must be between 30 : 120)");
                if (time <30||time>120)
                {
                    Console.WriteLine("wrong input , time must be between 30 and 120 m");
                }
               
            }
            while (time<30||time>120);
            int numOfQuestions = Exam.ReadValidInt("enter the number of questions : ");

            //creating exam
            subject.CreateExam(examType, time, numOfQuestions);

            //entering each question
            //
            for (int i = 0;i<numOfQuestions; i++)
            {
                Console.WriteLine($"question number {i+1}  ");
                Console.WriteLine("enter header :");
                string header = Console.ReadLine();
                Console.WriteLine("enter the question body : ");
                string body = Console.ReadLine();
                int mark = Exam.ReadValidInt("mark : ");
                Question question; 

                if (examType.Equals("final" , StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("choose the type of the question");
                    Console.WriteLine("1)true or false ");
                    Console.WriteLine("2)MCQ ");
                    int QTypeChoice = Exam.ReadValidInt("your choice  : ");
                    if (QTypeChoice == 1)
                    {
                        var tf = new TrueOrFalse(header, body,mark);
                        Console.WriteLine("1.true");
                        Console.WriteLine("2.false");
                        tf.CorrectAnswerId = Exam.ReadValidInt("the correct answer id is : ");
                        question = tf;
                    }
                    else
                    {
                        question=  CreateMCQQuestion (header, body,mark);  // -------------
                    }
                }
                else  //practical , mcq only
                {
                    question= CreateMCQQuestion(header, body,mark);
                }

                subject.SubjectExam.Questions.Add(question);
            }

            Console.WriteLine($"{subject}");
            Console.WriteLine($"{subject.SubjectExam}");

            Console.Clear();
            

            subject.SubjectExam.StartExam();
            Console.Clear();

            subject.SubjectExam.ShowExam();

            
            


            
        }

        static MCQQuestion CreateMCQQuestion (string header, string body,int mark )
        {
            var question = new MCQQuestion(header, body, mark);
            int numAnswers = Exam.ReadValidInt("enter number of choices : ");
            for (int i = 1; i <= numAnswers; i++)
            {
                Console.WriteLine($"{i}. choice : ");
                string text = Console .ReadLine();
                question.AnswerList.Add(new Answer(i, text));
            }
                question.CorrectAnswerId = Exam.ReadValidInt("the number of the coreect answer is : ");


                return question;

        }
    }
}
