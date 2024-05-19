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
    public partial class QuizzesListForm : Form
    {
        private QuizController _quizController;
        private List<Quiz.Quiz> _quizzes;
        private ListViewItem _selectedItem;

        public QuizzesListForm()
        {
            InitializeComponent();

            _quizController = new QuizController();
            _quizzes = _quizController.GetAllQuizzes();

            InitializeListView();
        }

        private void InitializeListView()
        {

            listViewQuizes.FullRowSelect = true;
            listViewQuizes.View = View.Details;
            listViewQuizes.GridLines = true;
            listViewQuizes.MultiSelect = false;

            listViewQuizes.Columns.Add("Quiz Name", 250);
            listViewQuizes.Columns.Add("Questions", 100);

            foreach(Quiz.Quiz quiz in  _quizzes)
            {
                quiz.SetQuestions(_quizController.GetQuizQuestions(quiz.GetQuizId));
                ListViewItem item = new ListViewItem(quiz.GetTitle);
                item.SubItems.Add(quiz.GetQuestions.Count.ToString());

                item.Tag = quiz.GetQuizId;
                
                listViewQuizes.Items.Add(item);
            }

            this.Controls.Add(listViewQuizes);

            listViewQuizes.SelectedIndexChanged += ListView_SelectedIndexChanged;
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                _selectedItem = listView.SelectedItems[0];

                labelQuizTitle.Text = "Quiz: " + _selectedItem.Text;
                labelQuizQuestions.Text = "Questions: " + _selectedItem.SubItems[1].Text;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                QuizForm quizForm = new QuizForm((int)_selectedItem.Tag);

                // daca fereasta Quizz este inchisa repare fereastra principala.
                quizForm.FormClosed += (s, args) => this.Show();
                quizForm.Show();

                // ascunde ferastra curenta.
                this.Hide();
            }
            else
                MessageBox.Show("Trebuie sa selectezi un quiz!");
        }
    }
}
