using System;

namespace QuizGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueFalseQuestion tfq = new TrueFalseQuestion("Gus is still here", false);

            //tfq.AdministerQuestion();


            //double score = tfq.GradeQuestion();

            //Console.WriteLine(score);


            MultipleChoiceQuestion mcq = new MultipleChoiceQuestion("What is the capital of Moldova?");

            mcq.AddPossibleAnswer("Jefferson City", false);
            mcq.AddPossibleAnswer("Chișinău", true);
            mcq.AddPossibleAnswer("Paris", false);
            mcq.AddPossibleAnswer("Kiev", false);

            //mcq.AdministerQuestion();

            //double score2 = mcq.GradeQuestion();

            Quiz quiz = new Quiz("TestQuiz");
            quiz.AddQuestion(tfq);
            quiz.AddQuestion(mcq);

            quiz.AdministerQuiz();
            quiz.GradeQuiz();

            Console.WriteLine(quiz.Grade);
        }
    }
}
