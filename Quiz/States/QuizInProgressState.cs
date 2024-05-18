using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz.States
{
    public class QuizInProgressState : IQuizState
    {
        public void OpenQuiz(Quiz quiz, QuizForm quizForm)
        {
            // deschide quiz-ul la intrebarea la care ai ramas
        }

        public void ShowQuestion(Quiz quiz, QuizForm quizForm)
        {

            quizForm.labelQuizTitle.Text = quiz.GetTitle;

            quizForm.textBoxQuestion.Text = quiz.GetQuestions[quiz.GetCurrentQuestionNumber].GetQuestion;

            List<Answer> _answers = quiz.GetQuestions[quiz.GetCurrentQuestionNumber].GetAnswers;

            // Poate facem astfel incat butoanele sa fie create dinamic
            // Eventual si un shuffle la raspunsuri
            quizForm.buttonAnswer1.Text = "A) " + _answers[0].GetAnswerText;
            quizForm.buttonAnswer2.Text = "B) " + _answers[1].GetAnswerText;
            quizForm.buttonAnswer3.Text = "C) " + _answers[2].GetAnswerText;
            quizForm.buttonAnswer4.Text = "D) " + _answers[3].GetAnswerText;

            // Handle Buttons

            if (quiz.GetCurrentQuestionNumber > 0)
                quizForm.buttonBack.Visible = true;
            else
                quizForm.buttonBack.Visible = false;

            if (quiz.GetCurrentQuestionNumber < quiz.GetQuestions.Count - 1)
                quizForm.buttonNext.Visible = true;
            else
                quizForm.buttonNext.Visible = false;

            quizForm.labelCurrentQuestion.Text = "Question: " + (quiz.GetCurrentQuestionNumber + 1) + " / " + quiz.GetQuestions.Count;
        }
    }
}
