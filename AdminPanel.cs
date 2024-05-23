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
    public partial class AdminPanel : Form
    {
        private List<Quiz.Quiz> _quizzes;
        private QuizController _quizController;
        private int selectedQuizz;
        private int selectedQuestion;
        public AdminPanel(List<Quiz.Quiz> quizzez)
        {
            InitializeComponent();
            _quizzes = quizzez;
            _quizController = new QuizController();

            InitializeListView();
            InitializeQuestionView();
        }

        private void InitializeListView()
        {

            listViewQuizes.FullRowSelect = true;
            listViewQuizes.View = View.Details;
            listViewQuizes.GridLines = true;
            listViewQuizes.MultiSelect = false;

            listViewQuizes.Columns.Add("Quiz Name", 250);
            listViewQuizes.Columns.Add("Questions", 100);

            foreach (Quiz.Quiz quiz in _quizzes)
            {
                quiz.SetQuestions(_quizController.GetQuizQuestions(quiz.GetQuizId));
                ListViewItem item = new ListViewItem(quiz.GetTitle);
                item.SubItems.Add(quiz.GetQuestions.Count.ToString());

                item.Tag = quiz.GetQuizId;

                listViewQuizes.Items.Add(item);
            }

            this.Controls.Add(listViewQuizes);

        }
        private void InitializeQuestionView()
        {
            listViewQuestions.FullRowSelect = true;
            listViewQuestions.View = View.Details;
            listViewQuestions.GridLines = true;
            listViewQuestions.MultiSelect = false;

            listViewQuestions.Columns.Add("Intrebare", 200);
            listViewQuestions.Columns.Add("Raspunsuri", 200);


        }

        public void PopulateQuestionList(int index)
        {
            foreach(Question question in _quizzes.ElementAt(index).GetQuestions)
            {
                ListViewItem item = new ListViewItem(question.GetQuestion);
                string raspuns = "";

                foreach(Answer answer in question.GetAnswers)
                {
                    raspuns += answer.GetAnswerText + "; ";
                }

                item.SubItems.Add(raspuns);

                listViewQuestions.Items.Add(item);
            }
        }

        private void listViewQuizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewQuizes.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewQuizes.SelectedIndices[0];
                selectedQuizz = selectedIndex;
                PopulateQuestionList(selectedIndex);
            } 
            else
            {
                listViewQuestions.Items.Clear();
            }
        }

        private void PopulateLabels(int index)
        {
            Question question = _quizzes.ElementAt(selectedQuizz).GetQuestions.ElementAt(index);

            textBoxIntrebare.Text = question.GetQuestion;

            textBoxRaspuns1.Text = question.GetAnswers.ElementAt(0).GetAnswerText;
            textBoxRaspuns2.Text = question.GetAnswers.ElementAt(1).GetAnswerText;
            textBoxRaspuns3.Text = question.GetAnswers.ElementAt(2).GetAnswerText;
            textBoxRaspuns4.Text = question.GetAnswers.ElementAt(3).GetAnswerText;
        }

        private void listViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewQuestions.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewQuestions.SelectedIndices[0];
                selectedQuestion = selectedIndex;
                PopulateLabels(selectedIndex);
            }
        }

        private void EditQuestion_Click(object sender, EventArgs e)
        {
            string intrebare = textBoxIntrebare.Text.Trim();
            string raspuns1 = textBoxRaspuns1.Text.Trim();
            string raspuns2 = textBoxRaspuns2.Text.Trim();
            string raspuns3 = textBoxRaspuns3.Text.Trim();
            string raspuns4 = textBoxRaspuns4.Text.Trim();

            if (String.IsNullOrEmpty(intrebare) || String.IsNullOrEmpty(raspuns1) || String.IsNullOrEmpty(raspuns2) || String.IsNullOrEmpty(raspuns3) || String.IsNullOrEmpty(raspuns4))
            {
                MessageBox.Show("Campurile sunt goale.");
                return;
            }

            //
            Question question = _quizzes.ElementAt(selectedQuizz).GetQuestions.ElementAt(selectedQuestion);

            question.SetQuestion = intrebare;
            question.GetAnswers[0].SetAnswerText = raspuns1;
            question.GetAnswers[1].SetAnswerText = raspuns2;
            question.GetAnswers[2].SetAnswerText = raspuns3;
            question.GetAnswers[3].SetAnswerText = raspuns4;

            bool retVal = _quizController.EditQuizQuestion(selectedQuizz, question);

            if(retVal == false)
            {
                MessageBox.Show("Eroare la modificarea datelor.");
                return;
            }
            MessageBox.Show("Succes!");
        }
    }
}
