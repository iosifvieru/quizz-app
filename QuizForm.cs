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
        private uint _timp_scurs = 0;

        public QuizForm(int quizId)
        {
            InitializeComponent();
            _quizController = new QuizController();

            _quiz = _quizController.GetQuiz(quizId);
            _quiz.SetQuestions(_quizController.GetQuizQuestions(quizId));

            _quiz.OpenQuiz(this);

            TimerTimpScurs.Enabled = true;
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

        private void TimerTimpScurs_Tick(object sender, EventArgs e)
        {
            _timp_scurs += 1;
            TimpQuizz.Text = "Time Left: " + ConvertToMinutes(_timp_scurs);
        }

        private static string ConvertToMinutes(uint seconds)
        {
            uint minute = seconds / 60;
            uint secunde = seconds % 60;

            return $"{minute:D2}:{secunde:D2}";
        }
    }
}
