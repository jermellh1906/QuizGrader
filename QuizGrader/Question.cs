using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public abstract class Question: IQuestionable
    {
        public string Prompt { get; set; }
        public string Subject { get; set; }

        public Dictionary<string, bool> PossibleAnswers { get; private set; }

        public Question(string prompt, string subject)
        {
            this.Prompt = prompt;
            this.Subject = subject;
            this.PossibleAnswers = new Dictionary<string, bool>(); 
        }

        public Question(string prompt) : this(prompt, "") { }

        public abstract double GradeQuestion();
        public abstract void AdministerQuestion();

        public void AddPossibleAnswer(string answer, bool isCorrect)
        {
            this.PossibleAnswers.Add(answer, isCorrect);
        }
    }
}
