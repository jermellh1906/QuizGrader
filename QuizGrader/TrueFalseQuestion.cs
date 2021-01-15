using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class TrueFalseQuestion : Question
    {
        // Could be private
        public string UserAnswer { get; set; }

        public TrueFalseQuestion(string prompt, bool correctAnswer) :
            base(prompt)
        {
            this.AddPossibleAnswer("True", correctAnswer);
            this.AddPossibleAnswer("False", !correctAnswer);
        }
        // TrueFalseQuestion tfq = new TrueFalseQuestion("Gus is still here", false)

        public override void AdministerQuestion()
        {
            Console.WriteLine($"Q: {this.Prompt}");

            foreach (string possibleAnswer in this.PossibleAnswers.Keys)
            {
                Console.WriteLine($" - {possibleAnswer}");
            }

            Console.Write("\nA: ");
            this.UserAnswer = Console.ReadLine();
        }


        /*
         * Possible answers:
         *  "True" -> false
         *  "False" -> true
         */
        public override double GradeQuestion()
        {
            foreach (KeyValuePair<string, bool> possibleAnswer in this.PossibleAnswers)
            {
                if (this.UserAnswer.ToLower() == possibleAnswer.Key.ToLower())
                {
                    return possibleAnswer.Value ? 1.0 : 0.0;

                    //if (possibleAnswer.Value)
                    //{
                    //    return 1.0;
                    //} else
                    //{
                    //    return 0.0;
                    //}
                }
            }

            return 0.0;
        }
    }
}
