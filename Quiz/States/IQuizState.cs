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
        void OpenQuiz(Quiz quiz, QuizForm quizForm);

        void ShowQuestion(Quiz quiz, QuizForm quizForm);

        void ClickButton(object sender, EventArgs e, Quiz quiz);

        //void SubmitAnswers()

        // Alte metode (cand imi vin idei)
    }
}
