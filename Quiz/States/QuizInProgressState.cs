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

        // Deschide un Quiz de unde a ramas
        // Preia raspunsurile salvate din baza de date si le adauga in Quiz
        // Seteaza timer-ul si il porneste.
        // Afiseaza intrebarea curenta.
        public void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController)
        {
            _quiz = quiz;
            _quizForm = quizForm;
            _quizController = quizController;

            List<int> userAnswers = _quizController.GetQuizUserAnswers(quiz.UserId, quiz.GetQuizId);
            if(userAnswers.Count > 0)
                for (int i = 0; i < _quiz.GetUserAnswers.Count; i++)
                {
                    _quiz.SetUserAnswer(i, userAnswers[i]);
                }


            quizForm.TimerTimpScurs.Interval = 1000;
            quizForm.TimerTimpScurs.Tick += new System.EventHandler(this.TimerTimpScurs_Tick);

            _quiz.SetQuizTime(_quizController.GetQuizUserTime(_quiz.UserId, _quiz.GetQuizId));

            _quizForm.TimerTimpScurs.Enabled = true;

            ShowQuestion();
        }

        // Afiseaza intrebarea curenta
        // Pune textul (raspunsurile) pe fiecare buton de raspuns corespunzator
        // Reseteaza culoarea de fundal a butoanelor
        // Afiseaza sau ascunde butoanele pentru parcurgere in functie de numarul intrebarii curente.
        public void ShowQuestion()
        {

            _quizForm.labelQuizTitle.Text = _quiz.GetTitle;

            if (_quiz.GetQuestions[_quiz.GetCurrentQuestionNumber].GetQuestion == null)
                throw new Exception("Intrebarea curenta nu are text!");

            _quizForm.textBoxQuestion.Text = _quiz.GetQuestions[_quiz.GetCurrentQuestionNumber].GetQuestion;

            _answers = _quiz.GetQuestions[_quiz.GetCurrentQuestionNumber].GetAnswers;

            if (_answers.Count != 4)
                throw new Exception("Intrebarea nu are un numar valid de raspunsuri!");

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
                if (button.BackColor == Color.Gold)
                    button.BackColor = Color.Navy;
            }

            int userAnswer = _quiz.GetUserAnswer(_quiz.GetCurrentQuestionNumber);
            if (userAnswer != -1)
            {
                answerButtons[userAnswer].BackColor = Color.Gold;
            }

            // Handle Buttons

            //_quizForm.buttonSubmit. = "Submit";

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
                button.Click += (sender, EventArgs) => { ButtonAnswer_Click(sender, EventArgs); };
            }

            // Labels

            _quizForm.labelCurrentQuestion.Text = "Întrebarea: " + (_quiz.GetCurrentQuestionNumber + 1) + " / " + _quiz.GetQuestions.Count;
        }

        // Calculeaza scorul, salveaza raspunsurile si marcheaza quiz-ul ca fiind completat.
        public void SubmitAnswers()
        {
            if (_quiz.UserId == -1)
                throw new ArgumentNullException("Quiz-ul nu are un utilizator!");
            if (_quiz.GetQuizId == -1)
                throw new ArgumentNullException("Quiz-ul nu are un ID valid");

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
            else
            {
                if (userAnswers.Count == 0)
                    throw new Exception("Utilizatorul nu are raspunsuri!");
                else if (quizQuestions.Count == 0)
                    throw new Exception("Quiz-ul nu are intrebari!");
            }

            _quizController.SaveQuizAnswers(_quiz.UserId, _quiz.GetQuizId, answersString, _quiz.GetQuizTime, "Completed", score);
            _quiz.SetState(new QuizCompletedState());
            _quizForm.Close();
        }

        // Salveaza progresul partial si inchide quiz-ul curent.
        public void CloseQuiz()
        {
            List<int> userAnswers = _quiz.GetUserAnswers;
            String answersString = "";
            if (userAnswers.Count > 0)
            {
                // Adauga raspunsul la string-ul cu raspunsuri
                for (int i = 0; i < userAnswers.Count; i++)
                    answersString += (userAnswers[i] + "_");
            }
            else
                throw new Exception("Utilizatorul nu are raspunsuri!");
            _quizController.SaveQuizAnswers(_quiz.UserId, _quiz.GetQuizId, answersString, _quiz.GetQuizTime, "In Progress", -1);
        }

        // Evenimentul de Tick pentru Timer
        // Incrementeaza timpul scurs la fiecare secunda si actualizeaza textul corespunzator.
        private void TimerTimpScurs_Tick(object sender, EventArgs e)
        {
            _quiz.IncrementQuizTime();
            _quizForm.labelQuizTime.Text = "Contor timp: " + ConvertToMinutes((uint)_quiz.GetQuizTime);
        }

        // Converteste secundele in formatul: {x}:{y}
        // {x} - Minute , {y} - Secunde
        private static string ConvertToMinutes(uint seconds)
        {
            uint minute = seconds / 60;
            uint secunde = seconds % 60;

            return $"{minute:D2}:{secunde:D2}";
        }

        // Evenimentul care se ocupa cu apasarea unui buton de raspuns
        // Reseteaza culoarea celorlalte butoane, coloreaza cu 'Auriu' butonul selectat si trimite raspunsul catre quiz.
        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            foreach (Button button in answerButtons)
            {
                if (button.BackColor == Color.Gold)
                    button.BackColor = Color.Navy;
            }

            Button selectedButton = (Button)sender;
            selectedButton.BackColor = Color.Gold;

            int answerIndex = 0;
            for (int i = 0; i < answerButtons.Count; i++)
            {
                if (selectedButton == answerButtons[i])
                {
                    answerIndex = i;
                }
            }

            _quiz.SetUserAnswer(_quiz.GetCurrentQuestionNumber, answerIndex);
        }
    }
}
