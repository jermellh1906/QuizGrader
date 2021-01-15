using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class Quiz
    {
        public List<IQuestionable> AllQuestions { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public DateTime Date { get; set; }

        public Quiz(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;

            this.AllQuestions = new List<IQuestionable>();
            this.Grade = 0;
        }   

        public Quiz(string name): this(name, DateTime.Now){}

        public void AddQuestion(IQuestionable question)
        {
            this.AllQuestions.Add(question);
        }

        public void AdministerQuiz()
        {
          foreach(IQuestionable question in this.AllQuestions)
            {
                question.AdministerQuestion();
            }  
        }

        public void GradeQuiz()
        {
            foreach (IQuestionable question in this.AllQuestions)
            {
                this.Grade += question.GradeQuestion();
            }
        }
    }
}
