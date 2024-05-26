using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz
{
    public interface IQuizState
    {

        void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController);

        void ShowQuestion();

        void SubmitAnswers();

        void CloseQuiz();

        // Alte metode (cand imi vin idei)
    }
}
