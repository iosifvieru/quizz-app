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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _quiz.PreviousQuestion();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _quiz.NextQuestion();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            _quiz.SubmitAnswers();
        }
    }
}
