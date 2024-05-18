using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz
{
    public interface IQuizState
    {
        void OpenQuiz(Quiz quiz, QuizForm quizForm);

        void ShowQuestion(Quiz quiz, QuizForm quizForm);

        // Alte metode (cand imi vin idei)
    }
}
