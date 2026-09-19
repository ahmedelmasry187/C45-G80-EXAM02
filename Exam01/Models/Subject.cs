using System;
using System.Collections.Generic;
using System.Text;

namespace Exam01.Models
{
    public class Subject
    {
      

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
     
        public void CreateExam(string examType , int time , int numberOfQuestions)
        {
            if (examType.Equals( "final" , StringComparison.OrdinalIgnoreCase ))
            {
                SubjectExam = new FinalExam(time, numberOfQuestions);
            }
            else if (examType.Equals("practical",StringComparison.OrdinalIgnoreCase))
            {
                SubjectExam = new PracticalExam(time, numberOfQuestions);
            }
            else
                throw new ArgumentException("unknown exam type");
        }

        public override string ToString()
        {
            return $"subject : {SubjectName} , id : {SubjectId}";
        }
    }
}
