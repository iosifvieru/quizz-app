using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz.States
{
    public class QuizCompletedState : IQuizState
    {
        public void OpenQuiz(Quiz quiz, QuizForm quizForm)
        {
            // deschide quiz-ul in modul review?
            // nu porneste instanta de timer
        }

        public void ShowQuestion(Quiz quiz, QuizForm quizForm)
        {
            // to be implemented
        }

        public void ClickButton(object sender, EventArgs e, Quiz quiz)
        {
            //
        }
    }
}
