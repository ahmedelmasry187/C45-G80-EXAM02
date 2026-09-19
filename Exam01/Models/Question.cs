using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Exam01.Models
{
    public abstract class Question :ICloneable , IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList  { get; set; }
        public int CorrectAnswerId  { get; set; }

        public abstract QuestionType Type { get; }

        protected Question(string header , string body , int mark)
        {
           Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }

        public virtual void DisplayQuestion ()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");
            foreach (var a in AnswerList)
            {
                Console.WriteLine(a);
            }
        }

        public bool CheckAnswer (int choosenAnswerId)
        {
            return choosenAnswerId == CorrectAnswerId;
        }


        //iclonable

        public object Clone()
        {
            Question Clone = (Question)this.MemberwiseClone();
            Clone.AnswerList=new List<Answer>();
            foreach (var a in AnswerList)
            {
                Clone.AnswerList.Add(new Answer(a.AnswerID , a.AnswerText) );
            }
                return Clone;

        }

        //icombarable 

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"[{Type}] {Header} mark:{Mark} ";
        }






    }
}
