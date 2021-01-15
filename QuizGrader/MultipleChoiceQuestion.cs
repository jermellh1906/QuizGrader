using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class MultipleChoiceQuestion : Question
    {
        private const string OPTIONS = "ABCDE";

        private string userAnswer;

        public MultipleChoiceQuestion(string prompt) : base(prompt)
        {
            // User of this class must call AddPossibleAnswer to populate possible responses
        }

        // Example workflow
        /*
         * MultipleChoiceQuestion mcq = new MultipleChoiceQuestion("What is the capital of Moldova?");
         * mcq.AddPossibleAnswer("Jefferson City", false);
         * mcq.AddPossibleAnswer("Chișinău", true);
         * mcq.AddPossibleAnswer("Paris", false);
         * mcq.AddPossibleAnswer("Kiev", false);
         * 
         */
        // Assume user calls mcq.AddPossibleAnswer

        public override void AdministerQuestion()
        {
            Console.WriteLine($"Q: {this.Prompt}");

            int i = 0;
            foreach (string possibleAnswer in this.PossibleAnswers.Keys)
            {
                Console.WriteLine($" {OPTIONS[i]}: {possibleAnswer}");
                i++;
            }

            Console.Write("A: ");
            this.userAnswer = Console.ReadLine();
        }

        public override double GradeQuestion()
        {
            int userAnswerIndex = OPTIONS.IndexOf(this.userAnswer.ToUpper());
            int i = 0;
            foreach (KeyValuePair<string, bool> possibleAnswer in this.PossibleAnswers)
            {
                if (userAnswerIndex == i)
                {
                    return possibleAnswer.Value ? 1.0 : 0.0;
                }
                i++;
            }

            return 0.0;
        }
    }
}
