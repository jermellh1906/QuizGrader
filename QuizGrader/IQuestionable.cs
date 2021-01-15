using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGrader
{
    public interface IQuestionable
    {
        public void AdministerQuestion();

        // all interface methods are public by default the keyword Public isn't really needed
        double GradeQuestion();
    }
}
