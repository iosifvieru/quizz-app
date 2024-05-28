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
        private User _user;

        public QuizzesListForm(User user)
        {
            InitializeComponent();

            _quizController = new QuizController();
            _quizzes = _quizController.GetAllQuizzes();

            _user = user;

            InitializeListView();
           

            // daca flagul isAdmin este != 0 at. utilizatorul este admininstrator.
            if(_user.Admin == 0)
            {
                buttonAdmin.Enabled = false;
                buttonAdmin.Visible = false;
            }
        }

        // Reimprospateaza lista cu quiz-uri.
        private void RefreshList()
        {
            foreach(ListViewItem item in listViewQuizes.Items)
            {
                item.SubItems[1].Text = (_quizzes[Convert.ToInt32(item.Tag.ToString())-1].GetQuestions.Count.ToString());
                item.SubItems[2].Text = (_quizController.GetQuizStatus(_user.ID, _quizzes[Convert.ToInt32(item.Tag.ToString())-1].GetQuizId));
                item.SubItems[3].Text = (_quizController.GetQuizUserScore(_user.ID, _quizzes[Convert.ToInt32(item.Tag.ToString())-1].GetQuizId).ToString());
                item.SubItems[4].Text = (ConvertToMinutes((uint)_quizController.GetQuizUserTime(_user.ID, _quizzes[Convert.ToInt32(item.Tag.ToString())-1].GetQuizId)));
            }

        }

        // Initializeaza lista cu quiz-uri.
        private void InitializeListView()
        {
            listViewQuizes.Clear();

            listViewQuizes.FullRowSelect = true;
            listViewQuizes.View = View.Details;
            listViewQuizes.GridLines = true;
            listViewQuizes.MultiSelect = false;

            listViewQuizes.Columns.Add("Quiz", 250);
            listViewQuizes.Columns.Add("Întrebări", 100);
            listViewQuizes.Columns.Add("Status", 100);
            listViewQuizes.Columns.Add("Scor", 100);
            listViewQuizes.Columns.Add("Timpul tău", 100);

            foreach (Quiz.Quiz quiz in  _quizzes)
            {
                quiz.SetQuestions(_quizController.GetQuizQuestions(quiz.GetQuizId));
                ListViewItem item = new ListViewItem(quiz.GetTitle);
                item.SubItems.Add(quiz.GetQuestions.Count.ToString());
                item.SubItems.Add(_quizController.GetQuizStatus(_user.ID,quiz.GetQuizId));
                item.SubItems.Add(_quizController.GetQuizUserScore(_user.ID, quiz.GetQuizId).ToString());
                item.SubItems.Add(ConvertToMinutes((uint)_quizController.GetQuizUserTime(_user.ID, quiz.GetQuizId)));

                item.Tag = quiz.GetQuizId;
                
                if(quiz.IsVisible == true)
                {
                    listViewQuizes.Items.Add(item);
                }

                // pt modul de admin, quiz urile trecute ca fiind invizibile vor aparea taiate.
                if(_user.Admin > 0)
                {
                    if(quiz.IsVisible == false)
                    {
                        Font strikeoutFont = new Font(item.Font, FontStyle.Strikeout);
                        item.Font = strikeoutFont;

                        listViewQuizes.Items.Add(item);
                    }
                }

            }

            this.Controls.Add(listViewQuizes);
            this.listViewQuizes.BringToFront();

            labelQuizTitle.Visible = false;
            labelQuizQuestions.Visible = false;
            labelQuizStatus.Visible = false;

            listViewQuizes.SelectedIndexChanged += ListView_SelectedIndexChanged;
        }

        // Evenimentul care determina quiz-ul selectat.
        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                _selectedItem = listView.SelectedItems[0];

                labelQuizTitle.Text = "Quiz: " + _selectedItem.Text;
                labelQuizQuestions.Text = "Întrebări: " + _selectedItem.SubItems[1].Text;
                labelQuizStatus.Text = "Status: " + _selectedItem.SubItems[2].Text;

                labelQuizTitle.Visible = true;
                labelQuizQuestions.Visible = true;
                labelQuizStatus.Visible = true;
            }
        }

        // Evenimentul butonului care te intoarce la meniul precedent.
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evenimentul butonului care deschide un quiz.
        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                try
                {
                    QuizForm quizForm = new QuizForm((int)_selectedItem.Tag, _user.ID);

                    // daca fereasta Quizz este inchisa repare fereastra principala.
                    quizForm.FormClosed += (s, args) => { this.RefreshList(); this.Show(); };
                    quizForm.Show();

                    // ascunde ferastra curenta.
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Eroare la deschiderea quiz-ului: \n" + ex.Message);
                }
            }
            else
                MessageBox.Show("Trebuie sa selectezi un quiz!");
        }
        private void butonAdmin_Click(object sender, EventArgs e)
        {
            if (_user.Admin == 0)
            {
                MessageBox.Show("Nu esti administrator");
                return;
            }

            AdminPanel adminPanelForm = new AdminPanel(_quizzes);

            adminPanelForm.FormClosed += (s, args) => this.Show();
            adminPanelForm.Show();

            this.Hide();
        }

        /// <summary>
        /// Converteste un numar in minute si secunde.
        /// </summary>
        /// <param name="seconds">Numarul de secunde</param>
        /// <returns>String-ul ce contine numarul in noul format</returns>
        private static string ConvertToMinutes(uint seconds)
        {
            uint minute = seconds / 60;
            uint secunde = seconds % 60;

            return $"{minute:D2}:{secunde:D2}";
        }
    }
}
