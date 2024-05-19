using proiect_ip.Quiz;
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

        public QuizForm(int quizId)
        {
            InitializeComponent();
            _quizController = new QuizController();

            _quiz = _quizController.GetQuiz(quizId);
            _quiz.SetQuestions(_quizController.GetQuizQuestions(quizId));

            _quiz.OpenQuiz(this);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _quiz.PreviousQuestion(this);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _quiz.NextQuestion(this);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
