using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz.States
{
    public class QuizNotStartedState : IQuizState
    {
        private Quiz _quiz;
        private QuizForm _form;

        public void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController)
        {
            _quiz = quiz;
            _form = quizForm;

            quizForm.TimerTimpScurs.Enabled = true;

            _quiz.SetState(new QuizInProgressState());
            _quiz.OpenQuiz(quizForm, quizController);
            _quiz.ShowQuestion();
    }

        public void ShowQuestion()
        {
            // to be implemented
        }

        public void ClickButton(object sender, EventArgs e)
        {
            //
        }

        public void SubmitAnswers()
        {

        }


        
    }
}
