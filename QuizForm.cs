using proiect_ip.Quiz;
using proiect_ip.Quiz.States;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip
{
    public partial class QuizForm : Form
    {
        private QuizController _quizController;
        private Quiz.Quiz _quiz;
        private int _userId;

        // Constructorul clasei QuizForm
        // Preia Quiz-ul din baza de date
        // Populeaza quiz-ul cu intrebari si raspunsuri
        // Determina statusul quiz-ului si il deschide.
        public QuizForm(int quizId, int userId)
        {
            InitializeComponent();
            _userId = userId;
            _quizController = new QuizController();

            _quiz = _quizController.GetQuiz(quizId);
            _quiz.SetQuestions(_quizController.GetQuizQuestions(quizId));
            _quiz.UserId = userId;

            String quizStatus = _quizController.GetQuizStatus(userId, quizId);
            switch (quizStatus)
            {
                case "Not Started":
                    _quiz.SetState(new QuizNotStartedState());
                    break;
                case "In Progress":
                    _quiz.SetState(new QuizInProgressState());
                    break;
                case "Completed":
                    _quiz.SetState(new QuizCompletedState());
                    break;
            }

            _quiz.OpenQuiz(this, _quizController);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evenimentul butonului de Back
        // Apeleaza metoda corespunzatoare din Quiz pentru a trece la intrebarea precedenta.
        private void buttonBack_Click(object sender, EventArgs e)
        {
            _quiz.PreviousQuestion();
        }

        // Evenimentul butonului Next
        // Apeleaza metoda corespunzatoare din Quiz pentru a trece la intrebarea urmatoare.
        private void buttonNext_Click(object sender, EventArgs e)
        {
            _quiz.NextQuestion();
        }

        // Evenimentul butonului de submit
        // Apeleaza metoda de Submit corespunzatoare quiz-ului.
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            _quiz.SubmitAnswers();
        }

        // Evenimentul de inchidere al form-ului.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _quiz.CloseQuiz();
        }

        private void bunifuButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Prep4AutomaticaHelp.chm");
        }
    }
}
