using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz.States
{
    public class QuizInProgressState : IQuizState
    {
        List<Button> answerButtons = new List<Button>();
        List<Answer> _answers;

        public void OpenQuiz(Quiz quiz, QuizForm quizForm)
        {
            // deschide quiz-ul la intrebarea la care ai ramas
        }

        public void ShowQuestion(Quiz quiz, QuizForm quizForm)
        {

            quizForm.labelQuizTitle.Text = quiz.GetTitle;

            quizForm.textBoxQuestion.Text = quiz.GetQuestions[quiz.GetCurrentQuestionNumber].GetQuestion;

            _answers = quiz.GetQuestions[quiz.GetCurrentQuestionNumber].GetAnswers;
            answerButtons = new List<Button>();

            // Shuffle the List of Answers
            /*Random rand = new Random();
            int n = _answers.Count;
            Answer temp;
            while(n > 1) 
            {
                n--;
                int k = rand.Next(n + 1);
                temp = _answers[k];
                _answers[k] = _answers[n];
                _answers[n] = temp;
            }*/

            // Poate facem astfel incat butoanele sa fie create dinamic
            // Eventual si un shuffle la raspunsuri
            quizForm.buttonAnswer1.Text = "A) " + _answers[0].GetAnswerText;
            quizForm.buttonAnswer2.Text = "B) " + _answers[1].GetAnswerText;
            quizForm.buttonAnswer3.Text = "C) " + _answers[2].GetAnswerText;
            quizForm.buttonAnswer4.Text = "D) " + _answers[3].GetAnswerText;

            answerButtons.Add(quizForm.buttonAnswer1);
            answerButtons.Add(quizForm.buttonAnswer2);
            answerButtons.Add(quizForm.buttonAnswer3);
            answerButtons.Add(quizForm.buttonAnswer4);

            foreach (Button button in answerButtons)
            {
                if (button.BackColor == Color.Gold)
                    button.BackColor = Color.DarkGray;
            }

            int userAnswer = quiz.GetUserAnswer(quiz.GetCurrentQuestionNumber);
            if (userAnswer != -1)
            {
                answerButtons[userAnswer].BackColor = Color.Gold;
            }

            // Handle Buttons

            if (quiz.GetCurrentQuestionNumber > 0)
                quizForm.buttonBack.Visible = true;
            else
                quizForm.buttonBack.Visible = false;

            if (quiz.GetCurrentQuestionNumber < quiz.GetQuestions.Count - 1)
                quizForm.buttonNext.Visible = true;
            else
                quizForm.buttonNext.Visible = false;

            if (quiz.GetCurrentQuestionNumber == quiz.GetQuestions.Count - 1)
                quizForm.buttonSubmit.Visible = true;
            else
                quizForm.buttonSubmit.Visible = false;

            // Answer Buttons

            foreach (Button button in answerButtons)
            {
                button.Click += (sender, EventArgs) => { ClickButton(sender, EventArgs, quiz); };
            }

            // Labels

            quizForm.labelCurrentQuestion.Text = "Question: " + (quiz.GetCurrentQuestionNumber + 1) + " / " + quiz.GetQuestions.Count;
        }

        public void ClickButton(object sender, EventArgs e, Quiz quiz)
        {
            foreach (Button button in answerButtons)
            {
                if (button.BackColor == Color.Gold)
                    button.BackColor = Color.DarkGray;
            }

            Button selectedButton = (Button)sender;
            selectedButton.BackColor = Color.Gold;

            int answerIndex = 0;
            for(int i=0; i<answerButtons.Count; i++)
            {
                if(selectedButton == answerButtons[i])
                {
                        answerIndex = i;
                }
            }

            quiz.SetUserAnswer(quiz.GetCurrentQuestionNumber, answerIndex);
        }
    }
}
