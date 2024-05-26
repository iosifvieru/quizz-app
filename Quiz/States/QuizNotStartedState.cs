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
        private QuizForm _quizForm;

        public void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController)
        {
            _quiz = quiz;
            _quizForm = quizForm;

            _quizForm.TimerTimpScurs.Enabled = true;

            _quiz.SetState(new QuizInProgressState());
            _quiz.OpenQuiz(quizForm, quizController);
            _quiz.ShowQuestion();
    }

        public void ShowQuestion()
        {
            throw new InvalidOperationException("Nu se poate afisa intrebarea! Quiz-ul nu a inceput inca!");
        }

        public void SubmitAnswers()
        {
            throw new InvalidOperationException("Nu se pot trimite raspunsurile! Quiz-ul nu a inceput inca!");
        }

        public void CloseQuiz()
        {
            throw new InvalidOperationException("Nu se poate inchide quiz-ul! Quiz-ul nu a inceput inca!");
        }

    }
}
