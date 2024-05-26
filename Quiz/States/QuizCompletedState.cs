using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz.States
{
    public class QuizCompletedState : IQuizState
    {
        private QuizController _quizController;
        private List<Button> answerButtons = new List<Button>();
        private List<Answer> _answers;
        private List<int> _userAnswers;
        private Quiz _quiz;
        private QuizForm _quizForm;

        // Deschide un Quiz in modul 'Review'
        // Permite vizualizarea raspunsurilor corecte si raspunsurilor alese de catre utilizator
        // Permite reluarea quiz-ului
        public void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController)
        {
            _quiz = quiz;
            _quizForm = quizForm;
            _quizController = quizController;
            _userAnswers = quizController.GetQuizUserAnswers(quiz.UserId, quiz.GetQuizId);

            ShowQuestion();
        }

        // Afiseaza intrebarea curenta
        // Pune textul (raspunsul) corespunzator fiecarui buton
        // Coloreaza cu 'Verde' raspunsurile corecte, iar cu 'Auriu', raspunsurile selectate de utilizator.
        public void ShowQuestion()
        {
            Question question = _quiz.GetQuestion();
            _quizForm.labelQuizTitle.Text = _quiz.GetTitle;

            _quizForm.textBoxQuestion.Text = question.GetQuestion;

            _answers = _quiz.GetAnswers();
            answerButtons = new List<Button>();


            _quizForm.buttonAnswer1.Text = "A) " + _answers[0].GetAnswerText;
            _quizForm.buttonAnswer2.Text = "B) " + _answers[1].GetAnswerText;
            _quizForm.buttonAnswer3.Text = "C) " + _answers[2].GetAnswerText;
            _quizForm.buttonAnswer4.Text = "D) " + _answers[3].GetAnswerText;

            answerButtons.Add(_quizForm.buttonAnswer1);
            answerButtons.Add(_quizForm.buttonAnswer2);
            answerButtons.Add(_quizForm.buttonAnswer3);
            answerButtons.Add(_quizForm.buttonAnswer4);

            foreach (Button button in answerButtons)
            {
                button.BackColor = Color.DarkGray;
            }

            int userAnswer = _userAnswers[_quiz.GetCurrentQuestionNumber];
            if (userAnswer != -1)
            {
                answerButtons[userAnswer].BackColor = Color.Gold;
            }


            answerButtons[question.GetCorrectAnswerIndex()].BackColor = Color.Green;

            // Handle Buttons

            _quizForm.buttonSubmit.Visible = true;
            _quizForm.buttonSubmit.Text = "Retry";

            if (_quiz.GetCurrentQuestionNumber > 0)
                _quizForm.buttonBack.Visible = true;
            else
                _quizForm.buttonBack.Visible = false;

            if (_quiz.GetCurrentQuestionNumber < _quiz.GetQuestions.Count - 1)
                _quizForm.buttonNext.Visible = true;
            else
                _quizForm.buttonNext.Visible = false;


            // Labels

            _quizForm.labelCurrentQuestion.Text = "Question: " + (_quiz.GetCurrentQuestionNumber + 1) + " / " + _quiz.GetQuestions.Count;
        }

        // Reseteaza progresul quiz-ului
        // Butonul aici nu are semnificatie de 'Submit', ci de 'Retry'
        public void SubmitAnswers()
        {
            _quizController.DeleteQuizProgress(_quiz.UserId, _quiz.GetQuizId);
            _quizForm.Close();
        }

        public void CloseQuiz()
        {
            // Evenimentul de inchidere este deja declansat altundeva.
        }
    }
}
