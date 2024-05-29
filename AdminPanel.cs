using proiect_ip.Quiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip
{
    public partial class AdminPanel : Form
    {
        private List<Quiz.Quiz> _quizzes;
        private QuizController _quizController;
        private int selectedQuizz = -1;
        private int selectedQuestion = -1;
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

                if(quiz.IsVisible == true)
                {
                    listViewQuizes.Items.Add(item);
                    
                }

                // pt modul de admin, quiz urile trecute ca fiind invizibile vor aparea taiate.

                if (quiz.IsVisible == false)
                {
                    Font strikeoutFont = new Font(item.Font, FontStyle.Strikeout);
                    item.Font = strikeoutFont;

                    listViewQuizes.Items.Add(item);
                  
                }
            }

          //  this.Controls.Add(listViewQuizes);


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

                textBoxTitluQuizz.Text = _quizzes.ElementAt(selectedIndex).GetTitle;
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

            checkBoxRaspuns1.Checked = question.GetAnswers.ElementAt(0).IsCorrect;
            checkBoxRaspuns2.Checked = question.GetAnswers.ElementAt(1).IsCorrect;
            checkBoxRaspuns3.Checked = question.GetAnswers.ElementAt(2).IsCorrect;
            checkBoxRaspuns4.Checked = question.GetAnswers.ElementAt(3).IsCorrect;
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

            question.GetAnswers[0].IsCorrect = checkBoxRaspuns1.Checked;
            question.GetAnswers[1].IsCorrect = checkBoxRaspuns2.Checked;
            question.GetAnswers[2].IsCorrect = checkBoxRaspuns3.Checked;
            question.GetAnswers[3].IsCorrect = checkBoxRaspuns4.Checked;

            bool retVal = _quizController.EditQuizQuestion(selectedQuizz, question);

            if(retVal == false)
            {
                MessageBox.Show("Eroare la modificarea datelor.");
                return;
            }
            MessageBox.Show("Succes!");
        }

        private void StergeIntrebareaButton_Click(object sender, EventArgs e)
        {
            if (selectedQuestion < 0)
            {
                MessageBox.Show("Trebuie sa selectezi o intrebare.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Esti sigur ca vrei sa stergi intrebarea?",
                "Da",
                MessageBoxButtons.YesNo
                );

            if(result == DialogResult.Yes)
            {
                listViewQuestions.Items.RemoveAt(selectedQuestion);

                Question question = _quizzes.ElementAt(selectedQuizz).GetQuestions.ElementAt(selectedQuestion);

                _quizController.DeleteQuizQuestion(question.ID);
            }
        }

        private void buttonAdaugaQuizz_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxTitluQuizz.Text))
            {
                MessageBox.Show("Trebuie sa introduci un titlu.");
                return;
            }

            _quizController.AddQuiz(textBoxTitluQuizz.Text);
            RefreshListView();
        }

        private void RefreshListView()
        {
            listViewQuizes.Clear();
          
            listViewQuestions.Clear();

            _quizzes = _quizController.GetAllQuizzes();
            InitializeListView();
            InitializeQuestionView();
        }

        private void DeleteQuizButton_Click(object sender, EventArgs e)
        {
            if(selectedQuizz < 0)
            {
                return;
            }

            _quizController.DeleteQuiz(selectedQuizz+1);
            RefreshListView();
        }

        private void buttonAdaugaIntrebare_Click(object sender, EventArgs e)
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

            List<Answer> answerList = new List<Answer>
            {
                new Answer(0, raspuns1, checkBoxRaspuns1.Checked),
                new Answer(0, raspuns2, checkBoxRaspuns2.Checked),
                new Answer(0, raspuns3, checkBoxRaspuns3.Checked),
                new Answer(0, raspuns4, checkBoxRaspuns4.Checked)
            };

            Question question = new Question(0, intrebare, answerList);

            _quizController.AddQuizQuestion(selectedQuizz+1, question);

            RefreshListView();
        }

        private void bunifuButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Prep4AutomaticaHelp.chm");
        }
    }
}
