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
        private QuizController _quizController;
        private List<Button> answerButtons = new List<Button>();
        private List<Answer> _answers;
        private Quiz _quiz;
        private QuizForm _quizForm;

        public void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController)
        {
            _quiz = quiz;
            _quizForm = quizForm;
            _quizController = quizController;
            // deschide quiz-ul la intrebarea la care ai ramas

            quizForm.TimerTimpScurs.Interval = 1000;
            quizForm.TimerTimpScurs.Tick += new System.EventHandler(this.TimerTimpScurs_Tick);
        }

        public void ShowQuestion()
        {

            _quizForm.labelQuizTitle.Text = _quiz.GetTitle;

            _quizForm.textBoxQuestion.Text = _quiz.GetQuestions[_quiz.GetCurrentQuestionNumber].GetQuestion;

            _answers = _quiz.GetQuestions[_quiz.GetCurrentQuestionNumber].GetAnswers;
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
                if (button.BackColor == Color.Gold)
                    button.BackColor = Color.DarkGray;
            }

            int userAnswer = _quiz.GetUserAnswer(_quiz.GetCurrentQuestionNumber);
            if (userAnswer != -1)
            {
                answerButtons[userAnswer].BackColor = Color.Gold;
            }

            // Handle Buttons

            _quizForm.buttonSubmit.Text = "Submit";

            if (_quiz.GetCurrentQuestionNumber > 0)
                _quizForm.buttonBack.Visible = true;
            else
                _quizForm.buttonBack.Visible = false;

            if (_quiz.GetCurrentQuestionNumber < _quiz.GetQuestions.Count - 1)
                _quizForm.buttonNext.Visible = true;
            else
                _quizForm.buttonNext.Visible = false;

            if (_quiz.GetCurrentQuestionNumber == _quiz.GetQuestions.Count - 1)
                _quizForm.buttonSubmit.Visible = true;
            else
                _quizForm.buttonSubmit.Visible = false;

            // Answer Buttons

            foreach (Button button in answerButtons)
            {
                button.Click += (sender, EventArgs) => { ClickButton(sender, EventArgs); };
            }

            // Labels

            _quizForm.labelCurrentQuestion.Text = "Question: " + (_quiz.GetCurrentQuestionNumber + 1) + " / " + _quiz.GetQuestions.Count;
        }

        public void ClickButton(object sender, EventArgs e)
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

            _quiz.SetUserAnswer(_quiz.GetCurrentQuestionNumber, answerIndex);
        }

        public void SubmitAnswers()
        {
            List<int> userAnswers = _quiz.GetUserAnswers;
            List<Question> quizQuestions = _quiz.GetQuestions;
            String answersString = "";
            int score = 0;
            int maxScore = 0;
            if(userAnswers.Count > 0 && quizQuestions.Count > 0)
            {
                // Calculeaza scorul si adauga raspunsul la string-ul cu raspunsuri
                for (int i = 0; i < userAnswers.Count; i++)
                {
                    answersString += (userAnswers[i] + "_");
                    maxScore += quizQuestions[i].GetScore;
                    if (quizQuestions[i].GetCorrectAnswerIndex() == userAnswers[i])
                    {
                        score += quizQuestions[i].GetScore;
                    }
                }
            }
            _quizController.SaveQuizAnswers(_quiz.UserId, _quiz.GetQuizId, answersString, _quiz.GetQuizTime, "Completed");
            _quiz.SetState(new QuizInProgressState());
            _quizForm.Close();
            MessageBox.Show("User Answers: " + answersString + "\n Score: " + score + " / " + maxScore + "\n Completed in: {x}:{y}");
        }

        private void TimerTimpScurs_Tick(object sender, EventArgs e)
        {
            _quiz.IncrementQuizTime();
            _quizForm.labelQuizTime.Text = "Contor Timp: " + ConvertToMinutes((uint)_quiz.GetQuizTime);
        }

        private static string ConvertToMinutes(uint seconds)
        {
            uint minute = seconds / 60;
            uint secunde = seconds % 60;

            return $"{minute:D2}:{secunde:D2}";
        }
    }
}
